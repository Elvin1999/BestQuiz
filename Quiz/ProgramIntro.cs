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

        }
        public Panel panelHeader { get; set; }
        public Button LogOutButton { get; set; }
        private void LoadProgramIntroduction()
        {
            panelHeader = new Panel();
            panelHeader.Dock = DockStyle.Top;
            panelHeader.BackColor = Color.FromName("SpringGreen");
            panelHeader.Location = new Point(0, 0);
            panelHeader.Size = new Size(800, 65);

            LogOutButton = new Button();
            LogOutButton.Size = new Size(80, 30);
            LogOutButton.Location = new Point(718, 1);
            LogOutButton.Text = "LogOut";
            LogOutButton.Font= new Font("Century", 10, FontStyle.Italic);
            LogOutButton.BackColor = Color.FromName("SpringGreen");
            LogOutButton.Click += LogOutButton_Click;

            this.Controls.Add(LogOutButton);
            this.Controls.Add(panelHeader);
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            //LoadLoginSystem();
        }

        private void ProgramIntro_Load(object sender, EventArgs e)
        {
            /////////load ProgramIntroduction
            LoadProgramIntroduction();
            ////////
            form = new Form1();
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick; timer.Start();
            Timer timer2 = new Timer();
            timer2.Interval = 100;
            timer2.Tick += Timer2_Tick;
            timer2.Start();
            //labelDateTime.Text = DateTime.Now.ToLongTimeString();
        }
        int counter = 0;
        private void Timer2_Tick(object sender, EventArgs e)
        {
            ++counter;
            if (counter == 1)
            {

                button1.BackColor = Color.FromName("SpringGreen");
                button2.BackColor = Color.FromName("Control");
                button3.BackColor = Color.FromName("Control");
                button4.BackColor = Color.FromName("Control");
            }
            else if (counter == 2)
            {
                button1.BackColor = Color.FromName("Control");
                button2.BackColor = Color.FromName("SpringGreen");
                button3.BackColor = Color.FromName("Control");
                button4.BackColor = Color.FromName("Control");
            }
            else if (counter == 3)
            {
                button1.BackColor = Color.FromName("Control");
                button2.BackColor = Color.FromName("Control");
                button3.BackColor = Color.FromName("SpringGreen");
                button4.BackColor = Color.FromName("Control");
            }
            else if (counter == 4)
            {
                counter = 0;
                button1.BackColor = Color.FromName("Control");
                button2.BackColor = Color.FromName("Control");
                button3.BackColor = Color.FromName("Control");
                button4.BackColor = Color.FromName("SpringGreen");
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //labelDateTime.Text = DateTime.Now.AddSeconds(1).ToLongTimeString();
        }

        private void labelX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public bool CreateClick { get; set; }
        public bool ExamClick { get; set; }
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            form.AutoScroll = true;
            form._IsClickedToCreate = true;
            form._IsClickedToExam = false;
            this.Hide();
            if (form.ShowDialog() == DialogResult.Cancel)
            {
                this.Show();
            }
        }

        public Form1 form { get; set; }
        private void buttonTakeExam_Click(object sender, EventArgs e)
        {
            form.AutoScroll = false;
            form._IsClickedToCreate = false;
            form._IsClickedToExam = true;

            this.Hide();

            if (form.ShowDialog() == DialogResult.Cancel)
            {
                this.Show();
            }
        }

    }
}
