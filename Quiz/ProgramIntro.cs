using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class ProgramIntro : Form
    {
        public ProgramIntro()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;timer.Start();
            labelDateTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            labelDateTime.Text = DateTime.Now.AddSeconds(1).ToLongTimeString();
        }

        private void labelX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
  
            if (form.ShowDialog() == DialogResult.Cancel)
            {                
                this.Show();
            }
        }

        private void buttonTakeExam_Click(object sender, EventArgs e)
        {

        }
    }
}
