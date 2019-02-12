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
            this.BackColor = Color.FromName("SpringGreen");
        }
        public Label LoginTitle { get; set; }
        public Panel LoginPanel { get; set; }
        public Button ExitButton { get; set; }
        public Label LoginNowLabel { get; set; }
        public TextBox Emailtxb { get; set; }

        private void LoadLoginSystem()
        {
            Emailtxb = new TextBox();
            Emailtxb.Size = new Size(230, 30);
            Emailtxb.Location = new Point(250,180);
            Emailtxb.Text = "E-MAIL";
            Emailtxb.Font = new Font("Comic Sans MS", 8, FontStyle.Italic);
            Emailtxb.BackColor = Color.LightGreen;
            Emailtxb.ForeColor = Color.Gray;
            this.Controls.Add(Emailtxb);
            LoginNowLabel = new Label();
            LoginNowLabel.Size = new Size(250, 70);
            LoginNowLabel.Location = new Point(270, 100);
            LoginNowLabel.BackColor = Color.FromArgb(70, 0, 0, 0);
            LoginNowLabel.Text = " Login Now";
            LoginNowLabel.ForeColor = Color.White;
            LoginNowLabel.Font = new Font("Comic Sans MS", 24, FontStyle.Italic);
            this.Controls.Add(LoginNowLabel);

            ExitButton = new Button();
            ExitButton.Size = new Size(44, 33);
            ExitButton.Location = new Point(755, 0);
            ExitButton.BackColor = Color.FromName("SpringGreen");
            ExitButton.Click += ExitButton_Click;
            ExitButton.Text = "X";
            ExitButton.ForeColor = Color.White;
            ExitButton.Font = new Font("Comic Sans MS", 14, FontStyle.Italic);
            this.Controls.Add(ExitButton);

            LoginTitle = new Label();
            LoginTitle.Size = new Size(600, 80);
            LoginTitle.Location = new Point(150, 20);
            LoginTitle.BackColor = Color.FromName("SpringGreen");
            LoginTitle.Text = "Welcome to Easyquiz";
            LoginTitle.ForeColor = Color.White;
            LoginTitle.Font = new Font("Comic Sans MS", 30, FontStyle.Italic);
            this.Controls.Add(LoginTitle);

            LoginPanel = new Panel();
            LoginPanel.Size = new Size(330, 320);
            LoginPanel.BackColor = Color.FromArgb(70, 0, 0, 0);
            LoginPanel.Location = new Point(200, 100);

            this.Controls.Add(LoginPanel);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public Panel panelHeader { get; set; }
        public Button LogOutButton { get; set; }
        public Label labelTitle { get; set; }
        public Button buttonCreate { get; set; }
        public Button buttonTakeExam { get; set; }
        public Panel PanelBottom { get; set; }
        public Button button1 { get; set; }
        public Button button2 { get; set; }
        public Button button3 { get; set; }
        public Button button4 { get; set; }
        private void LoadProgramIntroduction()
        {
            button1 = new Button();
            button1.Size = new Size(44, 33);
            button1.Location = new Point(682, 88);
            this.Controls.Add(button1);

            button2 = new Button();
            button2.Size = new Size(44, 33);
            button2.Location = new Point(727, 88);
            this.Controls.Add(button2);

            button3 = new Button();
            button3.Size = new Size(44, 33);
            button3.Location = new Point(727, 123);
            this.Controls.Add(button3);

            button4 = new Button();
            button4.Size = new Size(44, 33);
            button4.Location = new Point(682, 123);
            this.Controls.Add(button4);

            PanelBottom = new Panel();
            PanelBottom.Size = new Size(800, 66);
            PanelBottom.Location = new Point(0, 384);
            PanelBottom.BackColor = Color.FromName("SpringGreen");
            PanelBottom.Dock = DockStyle.Bottom;

            this.Controls.Add(PanelBottom);

            buttonTakeExam = new Button();
            buttonTakeExam.Size = new Size(205, 66);
            buttonTakeExam.Location = new Point(445, 312);
            buttonTakeExam.BackColor = Color.FromName("SpringGreen");
            buttonTakeExam.Font = new Font("Comic Sans MS", 14, FontStyle.Italic);
            buttonTakeExam.Text = "Take an examination";
            buttonTakeExam.Click += ButtonTakeExam_Click;
            this.Controls.Add(buttonTakeExam);

            buttonCreate = new Button();
            buttonCreate.Text = "Create new test";
            buttonCreate.Font = new Font("Comic Sans MS", 14, FontStyle.Italic);
            buttonCreate.BackColor = Color.FromName("SpringGreen");
            buttonCreate.Size = new Size(185, 66);
            buttonCreate.Location = new Point(166, 312);
            buttonCreate.Click += ButtonCreate_Click;
            this.Controls.Add(buttonCreate);

            labelTitle = new Label();
            labelTitle.Size = new Size(368, 138);
            labelTitle.Location = new Point(74, 68);
            labelTitle.Text = "Easy Quiz";
            labelTitle.Font = new Font("Comic Sans MS", 48, FontStyle.Italic);
            labelTitle.BackColor = Color.FromArgb(192, 255, 192);
            this.Controls.Add(labelTitle);

            panelHeader = new Panel();
            panelHeader.Dock = DockStyle.Top;
            panelHeader.BackColor = Color.FromName("SpringGreen");
            panelHeader.Location = new Point(0, 0);
            panelHeader.Size = new Size(800, 65);

            LogOutButton = new Button();
            LogOutButton.Size = new Size(80, 30);
            LogOutButton.Location = new Point(718, 1);
            LogOutButton.Text = "LogOut";
            LogOutButton.Font = new Font("Century", 10, FontStyle.Italic);
            LogOutButton.BackColor = Color.FromName("SpringGreen");
            LogOutButton.Click += LogOutButton_Click;

            this.Controls.Add(LogOutButton);
            this.Controls.Add(panelHeader);
        }

        private void ButtonTakeExam_Click(object sender, EventArgs e)
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



        private void ButtonCreate_Click(object sender, EventArgs e)
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


        private void LogOutButton_Click(object sender, EventArgs e)
        {
            //LoadLoginSystem();
        }

        private void ProgramIntro_Load(object sender, EventArgs e)
        {
            //first sign in sign up
            LoadLoginSystem();
            //after this
            /////////load ProgramIntroduction
            //LoadProgramIntroduction();
            //////////
            //form = new Form1();
            //Timer timer = new Timer();
            //timer.Interval = 1000;
            //timer.Tick += Timer_Tick; timer.Start();
            //Timer timer2 = new Timer();
            //timer2.Interval = 100;
            //timer2.Tick += Timer2_Tick;
            //timer2.Start();
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

        public Form1 form { get; set; }


    }
}
