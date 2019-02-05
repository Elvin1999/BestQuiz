namespace Quiz
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
            this.metroButtonExit = new MetroFramework.Controls.MetroButton();
            this.metroBackbtn = new MetroFramework.Controls.MetroButton();
            this.metroAcceptbtn = new MetroFramework.Controls.MetroButton();
            this.metroNextbtn = new MetroFramework.Controls.MetroButton();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // metroButtonExit
            // 
            this.metroButtonExit.Location = new System.Drawing.Point(767, 1);
            this.metroButtonExit.Name = "metroButtonExit";
            this.metroButtonExit.Size = new System.Drawing.Size(34, 23);
            this.metroButtonExit.TabIndex = 0;
            this.metroButtonExit.Text = "X";
            this.metroButtonExit.UseSelectable = true;
            this.metroButtonExit.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroBackbtn
            // 
            this.metroBackbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroBackbtn.Highlight = true;
            this.metroBackbtn.Location = new System.Drawing.Point(125, 453);
            this.metroBackbtn.Name = "metroBackbtn";
            this.metroBackbtn.Size = new System.Drawing.Size(75, 23);
            this.metroBackbtn.TabIndex = 1;
            this.metroBackbtn.Text = "Back";
            this.metroBackbtn.UseSelectable = true;
            this.metroBackbtn.Click += new System.EventHandler(this.metroBackbtn_Click);
            // 
            // metroAcceptbtn
            // 
            this.metroAcceptbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroAcceptbtn.Highlight = true;
            this.metroAcceptbtn.Location = new System.Drawing.Point(307, 453);
            this.metroAcceptbtn.Name = "metroAcceptbtn";
            this.metroAcceptbtn.Size = new System.Drawing.Size(75, 23);
            this.metroAcceptbtn.TabIndex = 1;
            this.metroAcceptbtn.Text = "Accept";
            this.metroAcceptbtn.UseSelectable = true;
            // 
            // metroNextbtn
            // 
            this.metroNextbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroNextbtn.Highlight = true;
            this.metroNextbtn.Location = new System.Drawing.Point(500, 453);
            this.metroNextbtn.Name = "metroNextbtn";
            this.metroNextbtn.Size = new System.Drawing.Size(75, 23);
            this.metroNextbtn.TabIndex = 1;
            this.metroNextbtn.Text = "Next";
            this.metroNextbtn.UseSelectable = true;
            this.metroNextbtn.Click += new System.EventHandler(this.metroNextbtn_Click);
            // 
            // labelQuestion
            // 
            this.labelQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuestion.ForeColor = System.Drawing.Color.Maroon;
            this.labelQuestion.Location = new System.Drawing.Point(95, 30);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(624, 242);
            this.labelQuestion.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.metroNextbtn);
            this.Controls.Add(this.metroAcceptbtn);
            this.Controls.Add(this.metroBackbtn);
            this.Controls.Add(this.metroButtonExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButtonExit;
        private MetroFramework.Controls.MetroButton metroBackbtn;
        private MetroFramework.Controls.MetroButton metroAcceptbtn;
        private MetroFramework.Controls.MetroButton metroNextbtn;
        private System.Windows.Forms.Label labelQuestion;
    }
}

