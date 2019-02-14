﻿using Quiz.Data;
using Quiz.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Quiz
{
    public partial class ProgramIntro : Form
    {

        UserContext userContext = new UserContext();
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
        public TextBox Passwordtxb { get; set; }
        public PictureBox MessageBoxpb { get; set; }
        public PictureBox KeyBoxpb { get; set; }
        public Label DontHaveAccountLb { get; set; }
        public Button LoginButton { get; set; }
        public Label RegisterNowLb { get; set; }
        private void LoadLoginSystem()
        {
            RegisterNowLb = new Label();
            RegisterNowLb.Size = new Size(120, 25);
            RegisterNowLb.Location = new Point(390, 350);
            RegisterNowLb.Text = "Register Now";
            RegisterNowLb.Font = new Font("Comic Sans MS", 10, FontStyle.Underline);
            RegisterNowLb.BackColor = Color.FromName("SpringGreen");
            RegisterNowLb.ForeColor = Color.White;
            RegisterNowLb.Click += RegisterNowLb_Click;
            RegisterNowLb.MouseEnter += RegisterNowLb_MouseEnter;
            RegisterNowLb.MouseLeave += RegisterNowLb_MouseLeave;
            this.Controls.Add(RegisterNowLb);

            DontHaveAccountLb = new Label();
            DontHaveAccountLb.Size = new Size(200, 25);
            DontHaveAccountLb.Location = new Point(230, 350);
            DontHaveAccountLb.Text = "Don't Have an Account ?";
            DontHaveAccountLb.Font = new Font("Comic Sans MS", 10, FontStyle.Regular);
            DontHaveAccountLb.ForeColor = Color.White;
            this.Controls.Add(DontHaveAccountLb);

            LoginButton = new Button();
            LoginButton.Size = new Size(130, 40);
            LoginButton.Location = new Point(300, 300);
            LoginButton.Text = "Login";
            LoginButton.Font = new Font("Comic Sans MS", 14, FontStyle.Bold);
            LoginButton.BackColor = Color.FromName("SpringGreen");
            LoginButton.ForeColor = Color.White;
            LoginButton.Click += LoginButton_Click;
            this.Controls.Add(LoginButton);


            Passwordtxb = new TextBox();
            Passwordtxb.Multiline = true;
            Passwordtxb.PasswordChar = '*';
            Passwordtxb.MaxLength = 20;
            Passwordtxb.Text = "admin";
            Passwordtxb.Font = new Font("Comic Sans MS", 10, FontStyle.Italic);
            Passwordtxb.BackColor = Color.FromName("SpringGreen");
            Passwordtxb.ForeColor = Color.Gray;
            Passwordtxb.Size = new Size(230, 30);
            Passwordtxb.Location = new Point(250, 230);
            Passwordtxb.Enter += Passwordtxb_Enter;
            Passwordtxb.Leave += Passwordtxb_Leave;
            this.Controls.Add(Passwordtxb);

            MessageBoxpb = new PictureBox();
            MessageBoxpb.Size = new Size(33, 30);
            MessageBoxpb.Location = new Point(215, 178);
            MessageBoxpb.Image = Properties.Resources.msnewwhite;
            MessageBoxpb.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(MessageBoxpb);

            KeyBoxpb = new PictureBox();
            KeyBoxpb.Size = new Size(30, 25);
            KeyBoxpb.Location = new Point(218, 230);
            KeyBoxpb.Image = Properties.Resources.keywhite;
            KeyBoxpb.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(KeyBoxpb);

            Emailtxb = new TextBox();
            Emailtxb.Size = new Size(230, 30);
            Emailtxb.Location = new Point(250, 180);
            Emailtxb.Multiline = true;
            Emailtxb.Text = "E-MAIL";
            Emailtxb.Font = new Font("Comic Sans MS", 10, FontStyle.Italic);
            Emailtxb.BackColor = Color.FromName("SpringGreen");
            Emailtxb.ForeColor = Color.Gray;
            Emailtxb.Enter += Emailtxb_Enter;
            Emailtxb.KeyPress += Emailtxb_KeyPress;
            Emailtxb.Leave += Emailtxb_Leave;
            this.Controls.Add(Emailtxb);
            LoginNowLabel = new Label();
            LoginNowLabel.Size = new Size(300, 60);
            LoginNowLabel.Location = new Point(220, 100);
            LoginNowLabel.BackColor = Color.FromName("SpringGreen");
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
            LoginTitle.Location = new Point(150, 30);
            LoginTitle.BackColor = Color.FromName("SpringGreen");
            LoginTitle.Text = "Welcome to Easyquiz";
            LoginTitle.ForeColor = Color.White;
            LoginTitle.Font = new Font("Comic Sans MS", 30, FontStyle.Italic);
            this.Controls.Add(LoginTitle);
        }
        public Label RegistriationLabel { get; set; }
        public PictureBox RgsEmailbx { get; set; }
        public PictureBox RgsPasswordbx { get; set; }
        public TextBox RgsEmailtb { get; set; }
        public TextBox RgsPasswordtb { get; set; }
        public TextBox RgsReplayPasswordtb { get; set; }
        public Label RgsReplayPasswordLb { get; set; }
        public Button RgsLoginbt { get; set; }
        private void LoadRegistriationSection()
        {
            for (int i = 0; i < 4; i++)
                foreach (var item in this.Controls)
                {
                    if (item is TextBox tb)
                    {
                        tb.Dispose();
                    }
                    else if (item is Label lb)
                    {
                        lb.Dispose();
                    }
                    else if (item is Button bt)
                    {
                        bt.Dispose();
                    }
                    else if (item is Panel pn)
                    {
                        pn.Dispose();
                    }
                    else if (item is PictureBox pb)
                    {
                        pb.Dispose();
                    }
                }/////////////
            RgsLoginbt = new Button();
            RgsLoginbt.Size = new Size(100, 33);
            RgsLoginbt.Location = new Point(700, 0);
            RgsLoginbt.BackColor = Color.FromName("SpringGreen");
            RgsLoginbt.Click += RgsLoginbt_Click;
            RgsLoginbt.Text = "Login";
            RgsLoginbt.ForeColor = Color.White;
            RgsLoginbt.Font = new Font("Comic Sans MS", 14, FontStyle.Italic);
            this.Controls.Add(RgsLoginbt);

            RgsPasswordtb = new TextBox();
            RgsPasswordtb.Multiline = true;
            RgsPasswordtb.PasswordChar = '*';
            RgsPasswordtb.MaxLength = 20;
            RgsPasswordtb.Text = "admin";
            RgsPasswordtb.Font = new Font("Comic Sans MS", 10, FontStyle.Italic);
            RgsPasswordtb.BackColor = Color.FromName("SpringGreen");
            RgsPasswordtb.ForeColor = Color.Gray;
            RgsPasswordtb.Size = new Size(230, 30);
            RgsPasswordtb.Location = new Point(250, 230);
            RgsPasswordtb.Enter += Passwordtxb_Enter;
            RgsPasswordtb.Leave += Passwordtxb_Leave;
            RgsPasswordtb.Enabled = false;
            this.Controls.Add(RgsPasswordtb);
            RgsReplayPasswordtb = new TextBox();
            RgsReplayPasswordtb.Multiline = true;
            RgsReplayPasswordtb.PasswordChar = '*';
            RgsReplayPasswordtb.MaxLength = 20;
            RgsReplayPasswordtb.Text = "";
            RgsReplayPasswordtb.Font = new Font("Comic Sans MS", 10, FontStyle.Italic);
            RgsReplayPasswordtb.BackColor = Color.FromName("SpringGreen");
            RgsReplayPasswordtb.ForeColor = Color.Gray;
            RgsReplayPasswordtb.Size = new Size(230, 30);
            RgsReplayPasswordtb.Location = new Point(250, 270);
            RgsReplayPasswordtb.Enabled = false;
            //RgsReplayPasswordtb.Enter += Passwordtxb_Enter;
            //RgsReplayPasswordtb.Leave += Passwordtxb_Leave;
            this.Controls.Add(RgsReplayPasswordtb);
            RgsReplayPasswordLb = new Label();
            RgsReplayPasswordLb.Size = new Size(180, 30);
            RgsReplayPasswordLb.Location = new Point(484, 273);
            RgsReplayPasswordLb.ForeColor = Color.Gray;
            RgsReplayPasswordLb.Text = "Replay Password";
            RgsReplayPasswordLb.Font= new Font("Comic Sans MS", 10, FontStyle.Italic);
            this.Controls.Add(RgsReplayPasswordLb);
            RgsEmailtb = new TextBox();
            RgsEmailtb.Size = new Size(230, 30);
            RgsEmailtb.Location = new Point(250, 180);
            RgsEmailtb.Multiline = true;
            RgsEmailtb.Text = "E-MAIL";
            RgsEmailtb.Font = new Font("Comic Sans MS", 10, FontStyle.Italic);
            RgsEmailtb.BackColor = Color.FromName("SpringGreen");
            RgsEmailtb.ForeColor = Color.Gray;
            RgsEmailtb.Enter += Emailtxb_Enter;
            RgsEmailtb.KeyPress += Emailtxb_KeyPress;
            RgsEmailtb.Leave += Emailtxb_Leave;
            this.Controls.Add(RgsEmailtb);
            RegistriationLabel = new Label();
            RegistriationLabel.Size = new Size(600, 80);
            RegistriationLabel.Location = new Point(150, 30);
            RegistriationLabel.BackColor = Color.FromName("SpringGreen");
            RegistriationLabel.Text = "Registriation";
            RegistriationLabel.ForeColor = Color.White;
            RegistriationLabel.Font = new Font("Comic Sans MS", 30, FontStyle.Italic);
            this.Controls.Add(RegistriationLabel);
            RgsEmailbx = new PictureBox();
            RgsEmailbx.Size = new Size(33, 30);
            RgsEmailbx.Location = new Point(215, 178);
            RgsEmailbx.Image = Properties.Resources.msnewwhite;
            RgsEmailbx.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(RgsEmailbx);

            RgsPasswordbx = new PictureBox();
            RgsPasswordbx.Size = new Size(30, 25);
            RgsPasswordbx.Location = new Point(218, 230);
            RgsPasswordbx.Image = Properties.Resources.keywhite;
            RgsPasswordbx.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(RgsPasswordbx);
            RgsPasswordbx = new PictureBox();
            RgsPasswordbx.Size = new Size(30, 25);
            RgsPasswordbx.Location = new Point(218, 270);
            RgsPasswordbx.Image = Properties.Resources.keywhite;
            RgsPasswordbx.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(RgsPasswordbx);

        }

        private void RgsLoginbt_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
                foreach (var item in this.Controls)
                {
                    if (item is TextBox tb)
                    {
                        tb.Dispose();
                    }
                    else if (item is Label lb)
                    {
                        lb.Dispose();
                    }
                    else if (item is Button bt)
                    {
                        bt.Dispose();
                    }
                    else if (item is Panel pn)
                    {
                        pn.Dispose();
                    }
                    else if (item is PictureBox pb)
                    {
                        pb.Dispose();
                    }
                }/////////////
            LoadLoginSystem();
        }

        //private bool IsCorrectRegistriation()
        //{
        //    return true;
        //}
        private void Emailtxb_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (regex.IsMatch(Emailtxb.Text))
            {
                Emailtxb.ForeColor = Color.Green;
            }
            else
            {
                Emailtxb.ForeColor = Color.Red;
            }
        }

        private void Emailtxb_Leave(object sender, EventArgs e)
        {
            if (Emailtxb.Text == String.Empty)
            {
                Emailtxb.Text = "E-MAIL";
            }
        }

        private void Emailtxb_Enter(object sender, EventArgs e)
        {
            if (Emailtxb.Text == "E-MAIL")
            {
                Emailtxb.Text = String.Empty;
            }
        }

        private void Passwordtxb_Leave(object sender, EventArgs e)
        {
            if (Passwordtxb.Text == String.Empty)
            {
                Passwordtxb.Text = "admin";
            }
        }

        private void Passwordtxb_Enter(object sender, EventArgs e)
        {
            if (Passwordtxb.Text == "admin")
            {
                Passwordtxb.Text = String.Empty;
            }
        }

        private void RegisterNowLb_MouseLeave(object sender, EventArgs e)
        {
            RegisterNowLb.ForeColor = Color.White;
        }

        private void RegisterNowLb_MouseEnter(object sender, EventArgs e)
        {
            RegisterNowLb.ForeColor = Color.Black;
        }
        
        private void RegisterNowLb_Click(object sender, EventArgs e)
        {
            LoadRegistriationSection();
        }
        public Label ErrorEmailLabel { get; set; }
        public Label ErrorPasswordLabel { get; set; }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            //Check in datebase and cross to EasyQuiz system . . .
            /////////load ProgramIntroduction

            try
            {
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                if (regex.IsMatch(Emailtxb.Text))
                {
                    var item1 = userContext.Users.SingleOrDefault(x => x.Email == Emailtxb.Text);
                    Emailtxb.ForeColor = Color.Green;
                    if (item1 != null)
                    {
                        if (item1.Password == Passwordtxb.Text)
                        {
                            Passwordtxb.ForeColor = Color.Green;
                            for (int i = 0; i < 4; i++)
                                foreach (var item in this.Controls)
                                {
                                    if (item is Label lb)
                                    {
                                        lb.Dispose();
                                    }
                                    else if (item is Button bt)
                                    {
                                        bt.Dispose();
                                    }
                                    else if (item is PictureBox pb)
                                    {
                                        pb.Dispose();
                                    }
                                    else if (item is TextBox tb)
                                    {
                                        tb.Dispose();
                                    }
                                    else if (item is Panel pn)
                                    {
                                        pn.Dispose();
                                    }
                                }
                            LoadProgramIntroduction();
                            form = new Form1();
                            Timer timer = new Timer();
                            timer.Interval = 1000;
                            timer.Tick += Timer_Tick; timer.Start();
                            Timer timer2 = new Timer();
                            timer2.Interval = 100;
                            timer2.Tick += Timer2_Tick;
                            timer2.Start();
                        }
                        else
                        {
                            Passwordtxb.ForeColor = Color.Red;//password is not correct
                            ErrorEmailLabel.Dispose();                                  //MessageBox.Show("password is not correct");
                            ErrorPasswordLabel = new Label();
                            ErrorPasswordLabel.Size = new Size(230, 30);
                            ErrorPasswordLabel.Location = new Point(250, 262);
                            ErrorPasswordLabel.Text = "Password is not correct";
                            ErrorPasswordLabel.ForeColor = Color.Red;
                            ErrorPasswordLabel.Font = new Font("Comic Sans Ms", 10, FontStyle.Regular);
                            this.Controls.Add(ErrorPasswordLabel);
                        }
                    }
                    else
                    {

                        Emailtxb.ForeColor = Color.Red;//i did not find item but regex is correct . . .
                        //MessageBox.Show("I did not find item but regex is correct");
                        ErrorEmailLabel = new Label();
                        ErrorEmailLabel.Size = new Size(400, 30);
                        ErrorEmailLabel.Location = new Point(250, 212);
                        ErrorEmailLabel.Text = $"{Emailtxb.Text} didn't find write correct email or register.";
                        ErrorEmailLabel.ForeColor = Color.Red;
                        ErrorEmailLabel.Font = new Font("Comic Sans MS", 8, FontStyle.Regular);
                        this.Controls.Add(ErrorEmailLabel);
                    }

                }
                else
                {
                    Emailtxb.ForeColor = Color.Red;//regex is not correct
                    ErrorEmailLabel = new Label();
                    ErrorEmailLabel.Size = new Size(260, 30);
                    ErrorEmailLabel.Location = new Point(250, 212);
                    ErrorEmailLabel.Text = $"Email is not correct";
                    ErrorEmailLabel.ForeColor = Color.Red;
                    ErrorEmailLabel.Font = new Font("Comic Sans MS", 9, FontStyle.Regular);
                    this.Controls.Add(ErrorEmailLabel);
                    //MessageBox.Show("Regex is not correct");
                }
            }
            catch (Exception)
            {
            }


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
            this.BackColor = Color.FromArgb(192, 255, 192);
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
            this.BackColor = Color.FromName("SpringGreen");
            for (int i = 0; i < 4; i++)
                foreach (var item in this.Controls)
                {
                    if (item is Label lb)
                    {
                        lb.Dispose();
                    }
                    else if (item is Button bt)
                    {
                        bt.Dispose();
                    }
                    else if (item is Panel pn)
                    {
                        pn.Dispose();
                    }
                }
            LoadLoginSystem();
        }

        private void ProgramIntro_Load(object sender, EventArgs e)
        {
            //first sign in sign up
            LoadLoginSystem();

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
