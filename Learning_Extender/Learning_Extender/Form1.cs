using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.IO;
using Learning_Extender.Models;
using Learning_Extender.Components;

namespace Learning_Extender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        timer_define time_count = new timer_define();
        private void timer_counter_Tick(object sender, EventArgs e)
        {
            timer_counter.Enabled =false;
            time_count.setCount();
            lbcounter.Text = time_count.getTime();
            timer_counter.Enabled = true;
        }

        public DataTable read_excel_file(string file_path)
        {
            DataTable tableExcel = new DataTable();

            using (ExcelPackage package = new ExcelPackage(new FileInfo(file_path)))
            {
                ExcelWorksheet sheet = package.Workbook.Worksheets[1];
                int col = sheet.Dimension.End.Column;
                int row = sheet.Dimension.End.Row;


                for (int j = 1; j <= col; j++)
                {
                    string rowCol_Data = "";
                    if (sheet.Cells[1, j].Value != null)
                    {
                        rowCol_Data = sheet.Cells[1, j].Value.ToString();
                        tableExcel.Columns.Add(rowCol_Data);
                    }
                }

                for (int i = 2; i <= row; i++)
                {
                    DataRow newrow = tableExcel.NewRow();
                    for (int j = 1; j < col; j++)
                    {
                        newrow[j-1] = sheet.Cells[i, j].Value;
                    }
                    tableExcel.Rows.Add(newrow);

                }

            }
            return tableExcel;
        }

        Course EnglishCourse = new Course();
        int right_anwser = 0;
        int count_down = 3;
        int anwsered_question = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            int wid = this.Width;
            int hei = this.Height;

            int panel_width = this.panelQuestion.Width;
            int panel_height = this.panelQuestion.Height;
            this.panelQuestion.Left = wid/2 - panel_width/2;
            this.panelQuestion.Top = hei / 2 - panel_height / 2;


            DataTable tb_questions = read_excel_file("words.xlsx");
            EnglishCourse.id=1;
            EnglishCourse.number_of_questions = 10;
            EnglishCourse.Text = "Hãy cùng kiểm tra lại từng vựng Flyer nhé";
            foreach(DataRow row in tb_questions.Rows)
            {
                Question quest = new Question();
                quest.Text = row["Word"].ToString();
                string img = $"picutres//{quest.Text}";
                if (File.Exists(img+".png"))
                {
                    quest.setImage(img + ".png");
                }
                else if (File.Exists(img + ".jpg"))
                {
                    quest.setImage(img + ".jpg");
                }

                string audio = $"sounds//{quest.Text}";
                if (File.Exists(audio + ".wav"))
                {
                    quest.setAudio(audio + ".wav");
                }
                else if (File.Exists(audio + ".mp3"))
                {
                    quest.setAudio(audio + ".mp3");
                }

                quest.subText.Add(row["Meaning"].ToString() + "\n" + row["Short Vietnamese"].ToString());
                quest.subText.Add(row["Transcription"].ToString());
                quest.subText.Add(row["Explanation"].ToString());
                quest.subText.Add(row["Example"].ToString());

                Awnser awnser = new Awnser();
                awnser.Text = row["Word"].ToString();

                quest.list_anwser.Add(awnser);

                EnglishCourse.Questions.Add(quest);
            }


            labeTitle.Text = EnglishCourse.Text;
            
           load_quest(0);
        }
        
        void load_quest(int index_quest)
        {
            panelQuestion.Controls.Clear();
            QuestionImage Questionbox = new QuestionImage();
            var Question = EnglishCourse.Questions.ElementAt(index_quest);
            Questionbox.setImage(Question._Image);
            Questionbox.setAudioURL(Question._Sound);
            Questionbox.setMeaning(Question.subText[0]);
            Questionbox.setTranscription(Question.subText[1]);
            Questionbox.setWord (Question.Text);
            panelQuestion.Controls.Add(Questionbox);
            Questionbox.textEnter += delegate{
                anwsered_question++;
                if (Questionbox.in_word.ToLower() == Questionbox.temp_word.ToLower())
                {
                    right_anwser++;
                    lbnumber_of_question.Text = $"{right_anwser}/{10}";
                    lb_time_use_computer.Text = $"{right_anwser*5} Min";
                    count_down = right_anwser * 5*60;
                }
            };

        }

        private void timer_lock_machine_Tick(object sender, EventArgs e)
        {
            timer_lock_machine.Enabled = false;
            count_down--;
            if(count_down<0)
            {
                this.Show();
            }
            else if(anwsered_question>=10)
            {
                this.Hide();
            }
            timer_lock_machine.Enabled = true;
        }
    }
    public class timer_define
    {
        private int hours = 0;
        private int minutes = 0;
        private int seconds = 0;
        private int count_seconds = 0;
        public void setCount()
        {
            this.count_seconds +=1;
            hours = this.count_seconds / 3600;
            minutes = (this.count_seconds -  hours*3600)/60;
            seconds = this.count_seconds - hours * 3600 - minutes*60;
        }
        public string getTime()
        {
            return $"{hours}:{minutes}:{seconds}";
        }
    }
}
