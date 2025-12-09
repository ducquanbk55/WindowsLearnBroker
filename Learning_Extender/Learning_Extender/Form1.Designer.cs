
namespace Learning_Extender
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnclose = new System.Windows.Forms.Button();
            this.labeTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbnumber_of_question = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_time_use_computer = new System.Windows.Forms.Label();
            this.panelQuestion = new System.Windows.Forms.Panel();
            this.panel_footer = new System.Windows.Forms.Panel();
            this.btnprevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.timer_lock_machine = new System.Windows.Forms.Timer(this.components);
            this.timer_turn_of_the_machine = new System.Windows.Forms.Timer(this.components);
            this.timer_counter = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.lbcounter = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_body = new System.Windows.Forms.Panel();
            this.panelQuestion.SuspendLayout();
            this.panel_footer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.Location = new System.Drawing.Point(897, 6);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 0;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // labeTitle
            // 
            this.labeTitle.BackColor = System.Drawing.Color.Transparent;
            this.labeTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labeTitle.Location = new System.Drawing.Point(0, 0);
            this.labeTitle.Name = "labeTitle";
            this.labeTitle.Size = new System.Drawing.Size(984, 72);
            this.labeTitle.TabIndex = 1;
            this.labeTitle.Text = "AMKOR SPEAKER";
            this.labeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số câu trả lời đúng";
            // 
            // lbnumber_of_question
            // 
            this.lbnumber_of_question.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbnumber_of_question.AutoSize = true;
            this.lbnumber_of_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnumber_of_question.Location = new System.Drawing.Point(279, 35);
            this.lbnumber_of_question.Name = "lbnumber_of_question";
            this.lbnumber_of_question.Size = new System.Drawing.Size(61, 25);
            this.lbnumber_of_question.TabIndex = 3;
            this.lbnumber_of_question.Text = "0 / 10";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thời gian tích lũy";
            // 
            // lb_time_use_computer
            // 
            this.lb_time_use_computer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_time_use_computer.AutoSize = true;
            this.lb_time_use_computer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_time_use_computer.Location = new System.Drawing.Point(274, 61);
            this.lb_time_use_computer.Name = "lb_time_use_computer";
            this.lb_time_use_computer.Size = new System.Drawing.Size(59, 25);
            this.lb_time_use_computer.TabIndex = 5;
            this.lb_time_use_computer.Text = "0 min";
            // 
            // panelQuestion
            // 
            this.panelQuestion.Controls.Add(this.panel_body);
            this.panelQuestion.Controls.Add(this.panel_footer);
            this.panelQuestion.Location = new System.Drawing.Point(25, 210);
            this.panelQuestion.Name = "panelQuestion";
            this.panelQuestion.Size = new System.Drawing.Size(700, 900);
            this.panelQuestion.TabIndex = 6;
            // 
            // panel_footer
            // 
            this.panel_footer.Controls.Add(this.btnprevious);
            this.panel_footer.Controls.Add(this.btnNext);
            this.panel_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_footer.Location = new System.Drawing.Point(0, 860);
            this.panel_footer.Name = "panel_footer";
            this.panel_footer.Size = new System.Drawing.Size(700, 40);
            this.panel_footer.TabIndex = 0;
            // 
            // btnprevious
            // 
            this.btnprevious.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnprevious.Image = ((System.Drawing.Image)(resources.GetObject("btnprevious.Image")));
            this.btnprevious.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnprevious.Location = new System.Drawing.Point(0, 0);
            this.btnprevious.Name = "btnprevious";
            this.btnprevious.Size = new System.Drawing.Size(93, 40);
            this.btnprevious.TabIndex = 1;
            this.btnprevious.Text = "Previous";
            this.btnprevious.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnprevious.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(607, 0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(93, 40);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Next";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // timer_lock_machine
            // 
            this.timer_lock_machine.Enabled = true;
            this.timer_lock_machine.Interval = 1000;
            this.timer_lock_machine.Tick += new System.EventHandler(this.timer_lock_machine_Tick);
            // 
            // timer_turn_of_the_machine
            // 
            this.timer_turn_of_the_machine.Interval = 15000;
            // 
            // timer_counter
            // 
            this.timer_counter.Enabled = true;
            this.timer_counter.Interval = 1000;
            this.timer_counter.Tick += new System.EventHandler(this.timer_counter_Tick);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Thời gian làm bài test";
            // 
            // lbcounter
            // 
            this.lbcounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbcounter.AutoSize = true;
            this.lbcounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcounter.Location = new System.Drawing.Point(275, 10);
            this.lbcounter.Name = "lbcounter";
            this.lbcounter.Size = new System.Drawing.Size(70, 25);
            this.lbcounter.TabIndex = 9;
            this.lbcounter.Text = "15 min";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbcounter);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbnumber_of_question);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lb_time_use_computer);
            this.panel1.Location = new System.Drawing.Point(636, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 109);
            this.panel1.TabIndex = 10;
            // 
            // panel_body
            // 
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(0, 0);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(700, 860);
            this.panel_body.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(984, 1100);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelQuestion);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.labeTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelQuestion.ResumeLayout(false);
            this.panel_footer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label labeTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbnumber_of_question;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_time_use_computer;
        private System.Windows.Forms.Panel panelQuestion;
        private System.Windows.Forms.Timer timer_lock_machine;
        private System.Windows.Forms.Timer timer_turn_of_the_machine;
        private System.Windows.Forms.Timer timer_counter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbcounter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_footer;
        private System.Windows.Forms.Button btnprevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel panel_body;
    }
}

