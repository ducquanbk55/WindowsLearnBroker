
namespace Learning_Extender.Components
{
    partial class QuestionImage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionImage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbexplain_meaning = new System.Windows.Forms.Label();
            this.lbword = new System.Windows.Forms.Label();
            this.lbtranscription = new System.Windows.Forms.Label();
            this.btnspeaker = new System.Windows.Forms.Button();
            this.txtAwnser = new System.Windows.Forms.TextBox();
            this.picture_word = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_word)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 76);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(197, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sentence Delivery";
            // 
            // lbexplain_meaning
            // 
            this.lbexplain_meaning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbexplain_meaning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbexplain_meaning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbexplain_meaning.Location = new System.Drawing.Point(1, 76);
            this.lbexplain_meaning.Name = "lbexplain_meaning";
            this.lbexplain_meaning.Size = new System.Drawing.Size(649, 87);
            this.lbexplain_meaning.TabIndex = 1;
            this.lbexplain_meaning.Text = "Speak the word and get pronunciation feedback for each sound.";
            this.lbexplain_meaning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbexplain_meaning.Click += new System.EventHandler(this.lbexplain_meaning_Click);
            // 
            // lbword
            // 
            this.lbword.AutoSize = true;
            this.lbword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbword.Location = new System.Drawing.Point(118, 431);
            this.lbword.Name = "lbword";
            this.lbword.Size = new System.Drawing.Size(231, 46);
            this.lbword.TabIndex = 2;
            this.lbword.Text = "interesting";
            // 
            // lbtranscription
            // 
            this.lbtranscription.AutoSize = true;
            this.lbtranscription.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtranscription.Location = new System.Drawing.Point(132, 483);
            this.lbtranscription.Name = "lbtranscription";
            this.lbtranscription.Size = new System.Drawing.Size(119, 31);
            this.lbtranscription.TabIndex = 3;
            this.lbtranscription.Text = "/ˈɪn.trɪ.stɪŋ/";
            // 
            // btnspeaker
            // 
            this.btnspeaker.FlatAppearance.BorderSize = 0;
            this.btnspeaker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnspeaker.Image = ((System.Drawing.Image)(resources.GetObject("btnspeaker.Image")));
            this.btnspeaker.Location = new System.Drawing.Point(471, 393);
            this.btnspeaker.Name = "btnspeaker";
            this.btnspeaker.Size = new System.Drawing.Size(38, 24);
            this.btnspeaker.TabIndex = 4;
            this.btnspeaker.UseVisualStyleBackColor = true;
            this.btnspeaker.Click += new System.EventHandler(this.btnspeaker_Click);
            // 
            // txtAwnser
            // 
            this.txtAwnser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAwnser.Location = new System.Drawing.Point(87, 567);
            this.txtAwnser.Multiline = true;
            this.txtAwnser.Name = "txtAwnser";
            this.txtAwnser.Size = new System.Drawing.Size(434, 48);
            this.txtAwnser.TabIndex = 5;
            this.txtAwnser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtAwnser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAwnser_KeyDown);
            // 
            // picture_word
            // 
            this.picture_word.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picture_word.BackgroundImage")));
            this.picture_word.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picture_word.Location = new System.Drawing.Point(163, 166);
            this.picture_word.Name = "picture_word";
            this.picture_word.Size = new System.Drawing.Size(288, 251);
            this.picture_word.TabIndex = 6;
            this.picture_word.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // QuestionImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.picture_word);
            this.Controls.Add(this.txtAwnser);
            this.Controls.Add(this.btnspeaker);
            this.Controls.Add(this.lbtranscription);
            this.Controls.Add(this.lbword);
            this.Controls.Add(this.lbexplain_meaning);
            this.Controls.Add(this.panel1);
            this.Name = "QuestionImage";
            this.Size = new System.Drawing.Size(652, 697);
            this.Load += new System.EventHandler(this.QuestionImage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_word)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbexplain_meaning;
        private System.Windows.Forms.Label lbword;
        private System.Windows.Forms.Label lbtranscription;
        private System.Windows.Forms.Button btnspeaker;
        private System.Windows.Forms.TextBox txtAwnser;
        private System.Windows.Forms.PictureBox picture_word;
        private System.Windows.Forms.Timer timer1;
    }
}
