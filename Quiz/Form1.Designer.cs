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
            this.metroBtnSubmit = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroButtonExit
            // 
            this.metroButtonExit.Location = new System.Drawing.Point(893, 0);
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
            this.metroBackbtn.Location = new System.Drawing.Point(144, 587);
            this.metroBackbtn.Name = "metroBackbtn";
            this.metroBackbtn.Size = new System.Drawing.Size(88, 30);
            this.metroBackbtn.TabIndex = 1;
            this.metroBackbtn.Text = "Back";
            this.metroBackbtn.UseSelectable = true;
            this.metroBackbtn.Click += new System.EventHandler(this.metroBackbtn_Click);
            // 
            // metroAcceptbtn
            // 
            this.metroAcceptbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroAcceptbtn.Highlight = true;
            this.metroAcceptbtn.Location = new System.Drawing.Point(326, 587);
            this.metroAcceptbtn.Name = "metroAcceptbtn";
            this.metroAcceptbtn.Size = new System.Drawing.Size(88, 30);
            this.metroAcceptbtn.TabIndex = 1;
            this.metroAcceptbtn.Text = "Accept";
            this.metroAcceptbtn.UseSelectable = true;
            this.metroAcceptbtn.Click += new System.EventHandler(this.metroAcceptbtn_Click);
            // 
            // metroNextbtn
            // 
            this.metroNextbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroNextbtn.Highlight = true;
            this.metroNextbtn.Location = new System.Drawing.Point(519, 587);
            this.metroNextbtn.Name = "metroNextbtn";
            this.metroNextbtn.Size = new System.Drawing.Size(88, 30);
            this.metroNextbtn.TabIndex = 1;
            this.metroNextbtn.Text = "Next";
            this.metroNextbtn.UseSelectable = true;
            this.metroNextbtn.Click += new System.EventHandler(this.metroNextbtn_Click);
            // 
            // metroBtnSubmit
            // 
            this.metroBtnSubmit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroBtnSubmit.Highlight = true;
            this.metroBtnSubmit.Location = new System.Drawing.Point(794, 587);
            this.metroBtnSubmit.Name = "metroBtnSubmit";
            this.metroBtnSubmit.Size = new System.Drawing.Size(88, 30);
            this.metroBtnSubmit.TabIndex = 1;
            this.metroBtnSubmit.Text = "Submit";
            this.metroBtnSubmit.UseSelectable = true;
            this.metroBtnSubmit.Click += new System.EventHandler(this.metroBtnSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 668);
            this.Controls.Add(this.metroBtnSubmit);
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
        private MetroFramework.Controls.MetroButton metroBtnSubmit;
    }
}

