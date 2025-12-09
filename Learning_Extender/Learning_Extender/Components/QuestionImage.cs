using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaPlayer;
using System.Media;
using NAudio.Wave;

namespace Learning_Extender.Components
{
    public partial class QuestionImage : UserControl
    {
        public string temp_word = "";
        public string in_word = "";
        public QuestionImage()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void QuestionImage_Load(object sender, EventArgs e)
        {
           
        }
        System.Drawing.Image image1;
        public void setImage(Image image)
        {
            image1 = (System.Drawing.Image)image;
        }
        public void setWord(string word)
        {
            this.lbword.Text = word;
            this.temp_word = word;
        }
        public void setTranscription(string transcription)
        {
            this.lbtranscription.Text = transcription;
        }
        public void setMeaning(string meaning)
        {
            this.lbexplain_meaning.Text = meaning;
        }
        string audio_ = null;
        public void setAudioURL(string audio)
        {
            audio_ = audio;
        }

        public event EventHandler textEnter;

        private void btnspeaker_Click(object sender, EventArgs e)
        {

            using (var audioFile = new AudioFileReader(audio_))
            using (var outputDevice = new WaveOutEvent())
            {
                outputDevice.Init(audioFile);
                outputDevice.Play();
                while (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    System.Threading.Thread.Sleep(1000);
                }
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            btnspeaker_Click(null, null);
        }

        private void txtAwnser_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.in_word = txtAwnser.Text.Trim();
                textEnter?.Invoke(this, e);
            }
        }

        private void lbexplain_meaning_Click(object sender, EventArgs e)
        {
            this.picture_word.BackgroundImage = image1;
            this.picture_word.Refresh();
        }
    }
}
