
namespace Learning_Extender.Components
{
    partial class MediaElement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaElement));
            this.lbtitle = new System.Windows.Forms.Label();
            this.btnspeaker = new System.Windows.Forms.Button();
            this.elQuestionText = new System.Windows.Forms.RichTextBox();
            this.elImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.elImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbtitle
            // 
            this.lbtitle.AutoSize = true;
            this.lbtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitle.Location = new System.Drawing.Point(13, 16);
            this.lbtitle.Name = "lbtitle";
            this.lbtitle.Size = new System.Drawing.Size(90, 20);
            this.lbtitle.TabIndex = 0;
            this.lbtitle.Text = "Question 1:";
            // 
            // btnspeaker
            // 
            this.btnspeaker.FlatAppearance.BorderSize = 0;
            this.btnspeaker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnspeaker.Image = ((System.Drawing.Image)(resources.GetObject("btnspeaker.Image")));
            this.btnspeaker.Location = new System.Drawing.Point(641, 12);
            this.btnspeaker.Name = "btnspeaker";
            this.btnspeaker.Size = new System.Drawing.Size(38, 24);
            this.btnspeaker.TabIndex = 2;
            this.btnspeaker.UseVisualStyleBackColor = true;
            // 
            // elQuestionText
            // 
            this.elQuestionText.Location = new System.Drawing.Point(130, 10);
            this.elQuestionText.Name = "elQuestionText";
            this.elQuestionText.Size = new System.Drawing.Size(505, 67);
            this.elQuestionText.TabIndex = 3;
            this.elQuestionText.Text = "";
            // 
            // elImage
            // 
            this.elImage.Location = new System.Drawing.Point(130, 93);
            this.elImage.Name = "elImage";
            this.elImage.Size = new System.Drawing.Size(505, 199);
            this.elImage.TabIndex = 4;
            this.elImage.TabStop = false;
            // 
            // MediaElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.elImage);
            this.Controls.Add(this.elQuestionText);
            this.Controls.Add(this.btnspeaker);
            this.Controls.Add(this.lbtitle);
            this.Name = "MediaElement";
            this.Size = new System.Drawing.Size(682, 314);
            ((System.ComponentModel.ISupportInitialize)(this.elImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbtitle;
        private System.Windows.Forms.Button btnspeaker;
        private System.Windows.Forms.RichTextBox elQuestionText;
        private System.Windows.Forms.PictureBox elImage;
    }
}
