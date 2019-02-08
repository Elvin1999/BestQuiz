namespace Quiz
{
    partial class ProgramIntro
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.panelMiddle = new System.Windows.Forms.Panel();
            this.buttonTakeExam = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelMiddle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelHeader.Controls.Add(this.labelDateTime);
            this.panelHeader.Controls.Add(this.labelX);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 65);
            this.panelHeader.TabIndex = 0;
            // 
            // labelDateTime
            // 
            this.labelDateTime.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateTime.ForeColor = System.Drawing.Color.White;
            this.labelDateTime.Location = new System.Drawing.Point(3, 3);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(189, 24);
            this.labelDateTime.TabIndex = 0;
            this.labelDateTime.Text = "X";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX.ForeColor = System.Drawing.Color.White;
            this.labelX.Location = new System.Drawing.Point(770, 1);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(27, 24);
            this.labelX.TabIndex = 0;
            this.labelX.Text = "X";
            this.labelX.Click += new System.EventHandler(this.labelX_Click);
            // 
            // panelMiddle
            // 
            this.panelMiddle.BackColor = System.Drawing.Color.DarkGray;
            this.panelMiddle.Controls.Add(this.buttonTakeExam);
            this.panelMiddle.Controls.Add(this.buttonCreate);
            this.panelMiddle.Controls.Add(this.labelTitle);
            this.panelMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMiddle.Location = new System.Drawing.Point(0, 65);
            this.panelMiddle.Name = "panelMiddle";
            this.panelMiddle.Size = new System.Drawing.Size(800, 385);
            this.panelMiddle.TabIndex = 1;
            // 
            // buttonTakeExam
            // 
            this.buttonTakeExam.BackColor = System.Drawing.Color.DarkGray;
            this.buttonTakeExam.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTakeExam.Location = new System.Drawing.Point(410, 257);
            this.buttonTakeExam.Name = "buttonTakeExam";
            this.buttonTakeExam.Size = new System.Drawing.Size(194, 66);
            this.buttonTakeExam.TabIndex = 1;
            this.buttonTakeExam.Text = "Take an examination";
            this.buttonTakeExam.UseVisualStyleBackColor = false;
            this.buttonTakeExam.Click += new System.EventHandler(this.buttonTakeExam_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.BackColor = System.Drawing.Color.DarkGray;
            this.buttonCreate.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreate.Location = new System.Drawing.Point(140, 257);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(173, 66);
            this.buttonCreate.TabIndex = 1;
            this.buttonCreate.Text = "Create New Test";
            this.buttonCreate.UseVisualStyleBackColor = false;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(3, 23);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(325, 94);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "EasyQuiz";
            // 
            // ProgramIntro
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMiddle);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProgramIntro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProgramIntro";
            this.TransparencyKey = System.Drawing.Color.DarkGray;
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMiddle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelMiddle;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonTakeExam;
        private System.Windows.Forms.Button buttonCreate;
    }
}