using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
namespace Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AnswerList = new List<string>();
            QuestionListSecond = new List<QuestionBlock>();

        }
        public List<QuestionBlock> QuestionList { get; set; }
        public List<QuestionBlock> QuestionListSecond { get; set; }
        public int CurrentIndex = 0;
        RadioButton radioButton = new RadioButton();
        public Label labelQueue1 { get; set; }
        public Label labelQuestion1 { get; set; }
        public Label labelQueueQuestion { get; set; }
        public MetroFramework.Controls.MetroButton BackButton { get; set; }
        public MetroFramework.Controls.MetroButton metroBackbtn { get; set; }
        public MetroFramework.Controls.MetroButton metroAcceptbtn { get; set; }
        public MetroFramework.Controls.MetroButton metroNextbtn { get; set; }
        public MetroFramework.Controls.MetroButton metroBtnSubmit { get; set; }
        public Label QuizTime { get; set; }
        public Label ExamTimeLabel { get; set; }

        private void LoadSecondPageOfForm()
        {
            metroBtnSubmit = new MetroFramework.Controls.MetroButton();
            metroBtnSubmit.Size = new Size(90, 30);
            metroBtnSubmit.Location = new Point(750, 490);
            metroBtnSubmit.Highlight = true;
            metroBtnSubmit.BackColor = Color.FromName("MenuHighlight");
            metroBtnSubmit.Text = "Submit";
            metroBtnSubmit.UseCustomBackColor = true;
            metroBtnSubmit.UseCustomForeColor = true;
            metroBtnSubmit.Font = new Font("Monotype Corsiva", 10, FontStyle.Italic);
            metroBtnSubmit.Click += MetroBtnSubmit_Click;
            this.Controls.Add(metroBtnSubmit);

            metroNextbtn = new MetroFramework.Controls.MetroButton();
            metroNextbtn.Size = new Size(90, 30);
            metroNextbtn.Location = new Point(519, 490);
            metroNextbtn.Highlight = true;
            metroNextbtn.UseCustomBackColor = true;
            metroNextbtn.UseCustomForeColor = true;
            metroNextbtn.BackColor = Color.FromName("MenuHighlight");
            metroNextbtn.Text = "Next";
            metroNextbtn.Font = new Font("Monotype Corsiva", 10, FontStyle.Italic);
            metroNextbtn.Click += MetroNextbtn_Click;
            this.Controls.Add(metroNextbtn);

            metroBackbtn = new MetroFramework.Controls.MetroButton();
            metroBackbtn.Size = new Size(90, 30);
            metroBackbtn.BackColor = Color.FromName("MenuHighlight");
            metroBackbtn.Location = new Point(144, 490);
            metroBackbtn.Highlight = true;
            metroBackbtn.UseCustomBackColor = true;
            metroBackbtn.UseCustomForeColor = true;
            metroBackbtn.Text = "Back";
            metroBackbtn.Font = new Font("Monotype Corsiva", 10, FontStyle.Italic);
            metroBackbtn.Click += MetroBackbtn_Click;
            this.Controls.Add(metroBackbtn);
            metroAcceptbtn = new MetroFramework.Controls.MetroButton();
            metroAcceptbtn.BackColor = Color.FromName("MenuHighlight");
            metroAcceptbtn.Size = new Size(90, 30);
            metroAcceptbtn.UseCustomBackColor = true;
            metroAcceptbtn.UseCustomForeColor = true;
            metroAcceptbtn.Location = new Point(326, 490);
            metroAcceptbtn.Highlight = true;
            metroAcceptbtn.Font = new Font("Monotype Corsiva", 10, FontStyle.Italic);
            metroAcceptbtn.Text = "Accept";
            metroAcceptbtn.Click += MetroAcceptbtn_Click;
            this.Controls.Add(metroAcceptbtn);
            DrawReturnButton();
            labelQueueQuestion = new Label();
            labelQueueQuestion.Size = new Size(120, 20);
            labelQueueQuestion.Location = new Point(12, 490);
            labelQueueQuestion.Font = new Font("Monotype Corsiva", 12, FontStyle.Italic);
            labelQueue1 = new Label();
            labelQueue1.Text = "1";
            labelQueue1.Font = new Font("Monotype Corsiva", 14, FontStyle.Italic);
            labelQueue1.Size = new Size(30, 25);
            labelQueue1.Location = new Point(15, 40);
            labelQuestion1 = new Label();
            labelQuestion1.Size = new Size(715, 145);
            labelQuestion1.Location = new Point(45, 25);
            labelQuestion1.Font = new Font("Monotype Corsiva", 16, FontStyle.Italic);
            labelQuestion1.ForeColor = Color.FromName("MenuHighlight");
            ExamTimeLabel = new Label();
            ExamTimeLabel.Size = new Size(100, 40);
            ExamTimeLabel.Location = new Point(650, 0);
            ExamTimeLabel.Text = "Exam time";
            ExamTimeLabel.Font = new Font("Monotype Corsiva", 16, FontStyle.Italic);
            ExamTimeLabel.ForeColor = Color.FromName("MenuHighlight");
            QuizTime = new Label();
            QuizTime.Size = new Size(120, 40);
            QuizTime.Location = new Point(750, 0);
            QuizTime.Font = new Font("Monotype Corsiva", 16, FontStyle.Italic);
            QuizTime.Text = currenttime.ToLongTimeString();
            QuizTime.BackColor = Color.FromName("Control");
            this.Controls.Add(QuizTime); this.Controls.Add(ExamTimeLabel);
            this.Controls.Add(labelQueueQuestion);
            this.Controls.Add(labelQueue1); this.Controls.Add(labelQuestion1);
        }
        DateTime currenttime = new DateTime(1, 1, 1, 0, 0, 0);
        public int EmptyCount { get; set; }
        public MetroFramework.Controls.MetroButton GetResultBtn { get; set; }
        private void GetResultButton()
        {
            GetResultBtn = new MetroFramework.Controls.MetroButton();
            GetResultBtn.BackColor = Color.FromName("MenuHighlight");
            GetResultBtn.Size = new Size(100, 30);
            GetResultBtn.UseCustomBackColor = true;
            GetResultBtn.UseCustomForeColor = true;
            GetResultBtn.Location = new Point(740, 50);
            GetResultBtn.Highlight = true;
            GetResultBtn.Font = new Font("Monotype Corsiva", 10, FontStyle.Italic);
            GetResultBtn.Text = "GetResult";
            GetResultBtn.Click += GetResultBtn_Click;
            this.Controls.Add(GetResultBtn);
        }

        private void GetResultBtn_Click(object sender, EventArgs e)
        {
            LoadThirdForm();
        }

        private void MetroBtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                CorrectCount = 0;
                UnCorrectCount = 0;
                EmptyCount = 0;
                metroAcceptbtn.Enabled = true;
                IsClickedToSubmitButton = true;
                metroBtnSubmit.Enabled = false;
                for (int i = 0; i < QuestionListSecond.Count; i++)
                {
                    var correctanswer = QuestionListSecond[i].Answers.SingleOrDefault(x => x.IsCorrect == "Yes");
                    if (AnswerList[i] == correctanswer.Text)
                    {
                        ++CorrectCount;
                    }
                    else
                    {
                        ++UnCorrectCount;
                    }
                }
                EmptyCount = QuestionList.Count - (CorrectCount + UnCorrectCount);
                MessageBox.Show($"Correct {CorrectCount} UnCorrect {UnCorrectCount} Empty {EmptyCount}");
                CurrentIndex = 0;
                if (QuestionListSecond.Count != 0)
                    ShowTest(QuestionListSecond, CurrentIndex);
                GetResultButton();
            }
            catch (Exception)
            {
            }



        }

        private void LoadThirdForm()
        {
            for (int i = 0; i < 5; i++)
            {
                foreach (var item in this.Controls)
                {
                    if (item is RadioButton rb)
                    {
                        rb.Dispose();
                    }
                    else if (item is Button bt)
                    {
                        bt.Dispose();
                    }
                    else if (item is Label lb)
                    {
                        lb.Dispose();
                    }
                    else if (item is PictureBox pb)
                    {
                        pb.Dispose();
                    }
                }
            }
            DrawReturnButton();
            LoadThirdWindowControls();

        }
        public PictureBox PersonImagePb { get; set; }
        public Button CorrectBarButton { get; set; }
        public Button UnCorrectBarButton { get; set; }
        public Button EmptyAnswerButton { get; set; }
        public Label SuccessLabel { get; set; }
        public Button SaveAsPdfButton { get; set; }
        public PictureBox CirclePicture { get; set; }
        public PictureBox PercentPicture { get; set; }
        public Label ResultPercentLabel { get; set; }
        private void LoadThirdWindowControls()
        {
            CirclePicture = new PictureBox();
            CirclePicture.Size = new Size(193, 174);
            CirclePicture.Location = new Point(30, 210);
            CirclePicture.Image = Properties.Resources.percentcircle;
            CirclePicture.SizeMode = PictureBoxSizeMode.StretchImage;

            PercentPicture = new PictureBox();
            PercentPicture.Size = new Size(84, 64);
            PercentPicture.Location = new Point(229, 301);
            PercentPicture.Image = Properties.Resources.PercentImage;
            PercentPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(PercentPicture);
            ResultPercentLabel = new Label();
            ResultPercentLabel.Size = new Size(74, 40);
            ResultPercentLabel.Location = new Point(94, 280);
            ResultPercentLabel.Text = "29";
            ResultPercentLabel.Font = new Font("Copper", 30, FontStyle.Italic);
            this.Controls.Add(ResultPercentLabel); this.Controls.Add(CirclePicture);
            SaveAsPdfButton = new Button();
            SaveAsPdfButton.Size = new Size(150, 40);
            SaveAsPdfButton.Location = new Point(600, 410);
            SaveAsPdfButton.BackColor = Color.FromArgb(0, 96, 168);
            SaveAsPdfButton.Text = "Save as .pdf";
            SaveAsPdfButton.Font = new Font("Century", 12, FontStyle.Italic);
            this.Controls.Add(SaveAsPdfButton);

            PersonImagePb = new PictureBox();
            PersonImagePb.Size = new Size(180, 240);
            PersonImagePb.Location = new Point(550, 30);
            PersonImagePb.Image = Properties.Resources.thinkPerson;
            PersonImagePb.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(PersonImagePb);
            this.BackColor = Color.FromArgb(0, 96, 168);
            BackButton.BackColor = Color.FromArgb(0, 96, 168);
            CorrectBarButton = new Button();
            CorrectBarButton.Size = new Size(50, 230);
            CorrectBarButton.Font = new Font("Century", 10, FontStyle.Italic);
            CorrectBarButton.Location = new Point(350, 220);
            CorrectBarButton.BackColor = Color.Green;
            CorrectBarButton.Text = "\nC\no\nr\nr\ne\nc\nt\n";
            this.Controls.Add(CorrectBarButton);

            UnCorrectBarButton = new Button();
            UnCorrectBarButton.Size = new Size(50, 230);
            UnCorrectBarButton.Font = new Font("Century", 10, FontStyle.Italic);
            UnCorrectBarButton.Location = new Point(402, 220);
            UnCorrectBarButton.BackColor = Color.Red;
            UnCorrectBarButton.Text = "\nW\nr\no\nn\ng";
            this.Controls.Add(UnCorrectBarButton);

            EmptyAnswerButton = new Button();
            EmptyAnswerButton.Size = new Size(50, 230);
            EmptyAnswerButton.Font = new Font("Century", 10, FontStyle.Italic);
            EmptyAnswerButton.Location = new Point(454, 220);
            EmptyAnswerButton.BackColor = Color.Orange;
            EmptyAnswerButton.Text = "\nE\nm\np\nt\ny";
            this.Controls.Add(EmptyAnswerButton);

            SuccessLabel = new Label();
            SuccessLabel.Font = new Font("Monotype Corsiva", 60, FontStyle.Italic);
            SuccessLabel.Size = new Size(300, 400);
            SuccessLabel.Location = new Point(0, 25);
            SuccessLabel.Text = "Your Success .";
            SuccessLabel.BackColor = Color.FromArgb(0, 96, 168);
            this.Controls.Add(SuccessLabel);

            EmptyAnswerButton.Location = new Point(454, 250);
            EmptyAnswerButton.Size = new Size(50, 200);
            CorrectBarButton.Location = new Point(350, 150);
            CorrectBarButton.Size = new Size(50, 300);
            UnCorrectBarButton.Location = new Point(402, 300);
            UnCorrectBarButton.Size = new Size(50, 150);
            timerdc = new Timer();
            timerdc.Interval = 5;
            timerdc.Tick += Timerdc_Tick;
            timerdc.Start();

            CorrectAnswerPercentLabel = new Label();
            CorrectAnswerPercentLabel.Font = new Font("Century", 10, FontStyle.Regular);
            CorrectAnswerPercentLabel.Size = new Size(50, 50);
            CorrectAnswerPercentLabel.Location = new Point(352, 98);
            CorrectAnswerPercentLabel.Text = "45";
            CorrectAnswerPercentLabel.BackColor = Color.FromArgb(0, 96, 168);
            this.Controls.Add(CorrectAnswerPercentLabel);

            UnCorrectAnswerPercentLabel = new Label();
            UnCorrectAnswerPercentLabel.Font = new Font("Century", 10, FontStyle.Regular);
            UnCorrectAnswerPercentLabel.Location = new Point(402, 98);
            UnCorrectAnswerPercentLabel.Size = new Size(50, 50);
            UnCorrectAnswerPercentLabel.Text = "15";
            UnCorrectAnswerPercentLabel.BackColor = Color.FromArgb(0, 96, 168);
            this.Controls.Add(UnCorrectAnswerPercentLabel);

            EmptyAnswerPercentLabel = new Label();
            EmptyAnswerPercentLabel.Font = new Font("Century", 10, FontStyle.Regular);
            EmptyAnswerPercentLabel.Location = new Point(452, 98);
            EmptyAnswerPercentLabel.Size = new Size(50, 50);
            EmptyAnswerPercentLabel.Text = "40";
            EmptyAnswerPercentLabel.BackColor = Color.FromArgb(0, 96, 168);
            this.Controls.Add(EmptyAnswerPercentLabel);
            correct_percent = (100 * CorrectCount) / QuestionList.Count;
            uncorrect_percent = (100 * UnCorrectCount) / QuestionList.Count;
            empty_answer_percent = (100 * EmptyCount) / QuestionList.Count;
            InceasingRate = 1;
        }
        public Label CorrectAnswerPercentLabel { get; set; }
        public Label UnCorrectAnswerPercentLabel { get; set; }
        public Label EmptyAnswerPercentLabel { get; set; }
        public Timer timerdc { get; set; }
        public int InceasingRate { get; set; }
        public int correct_percent { get; set; }
        public int uncorrect_percent { get; set; }
        public int empty_answer_percent { get; set; }

        int counter = 0; int counterall = 0;
        int empty_answer_rate = 0; int correct_answer_rate = 50;
        int uncorrect_answer_rate = 0;
        private void Timerdc_Tick(object sender, EventArgs e)
        {
            ++counter;
            if (counterall == 0 || counterall == 2 || counterall == 4)
            {
                EmptyAnswerButton.Location = new Point(454, EmptyAnswerButton.Location.Y - InceasingRate);
                EmptyAnswerPercentLabel.Location = new Point(458, EmptyAnswerButton.Location.Y - InceasingRate - 50);
                empty_answer_rate += InceasingRate;
                EmptyAnswerPercentLabel.Text = empty_answer_rate.ToString() + " %";
                EmptyAnswerButton.Size = new Size(50, EmptyAnswerButton.Size.Height + InceasingRate);
                CorrectBarButton.Location = new Point(350, CorrectBarButton.Location.Y + InceasingRate);
                CorrectAnswerPercentLabel.Location = new Point(354, CorrectBarButton.Location.Y + InceasingRate - 50);
                correct_answer_rate -= InceasingRate;
                CorrectAnswerPercentLabel.Text = correct_answer_rate.ToString() + " %";
                ResultPercentLabel.Text = correct_answer_rate.ToString() + " %";
                CorrectBarButton.Size = new Size(50, CorrectBarButton.Size.Height - InceasingRate);
                UnCorrectBarButton.Location = new Point(402, UnCorrectBarButton.Location.Y - InceasingRate);
                UnCorrectAnswerPercentLabel.Location = new Point(406, UnCorrectBarButton.Location.Y - InceasingRate - 50);
                UnCorrectBarButton.Size = new Size(50, UnCorrectBarButton.Size.Height + InceasingRate);
                uncorrect_answer_rate += InceasingRate;
                UnCorrectAnswerPercentLabel.Text = uncorrect_answer_rate.ToString() + " %";

            }
            else
            {
                EmptyAnswerButton.Location = new Point(454, EmptyAnswerButton.Location.Y + InceasingRate);
                EmptyAnswerPercentLabel.Location = new Point(458, EmptyAnswerButton.Location.Y + InceasingRate - 50);
                empty_answer_rate -= InceasingRate;
                EmptyAnswerPercentLabel.Text = empty_answer_rate.ToString() + " %";
                EmptyAnswerButton.Size = new Size(50, EmptyAnswerButton.Size.Height - InceasingRate);
                CorrectBarButton.Location = new Point(350, CorrectBarButton.Location.Y - InceasingRate);
                CorrectAnswerPercentLabel.Location = new Point(354, CorrectBarButton.Location.Y - InceasingRate - 50);
                CorrectBarButton.Size = new Size(50, CorrectBarButton.Size.Height + InceasingRate);
                correct_answer_rate += InceasingRate;
                CorrectAnswerPercentLabel.Text = correct_answer_rate.ToString() + " %";
                ResultPercentLabel.Text = correct_answer_rate.ToString() + " %";
                UnCorrectBarButton.Location = new Point(402, UnCorrectBarButton.Location.Y + InceasingRate);
                UnCorrectAnswerPercentLabel.Location = new Point(406, UnCorrectBarButton.Location.Y + InceasingRate - 50);
                UnCorrectBarButton.Size = new Size(50, UnCorrectBarButton.Size.Height - InceasingRate);
                uncorrect_answer_rate -= InceasingRate;
                UnCorrectAnswerPercentLabel.Text = uncorrect_answer_rate.ToString() + " %";
            }
            if (counter == 50)
            {
                counter = 0;
                ++counterall;
                if (counterall == 5)
                {
                    timerdc.Stop();

                    CorrectBarButton.Location = new Point(350, 240 - 2 * correct_percent);
                    CorrectBarButton.Size = new Size(50, 210 + 2 * correct_percent);
                    EmptyAnswerButton.Size = new Size(50, 210 + 2 * empty_answer_percent);
                    EmptyAnswerButton.Location = new Point(454, 240 - 2 * empty_answer_percent);
                    UnCorrectBarButton.Size = new Size(50, 210 + 2 * uncorrect_percent);
                    UnCorrectBarButton.Location = new Point(402, 240 - 2 * uncorrect_percent);
                    CorrectAnswerPercentLabel.Text = correct_percent.ToString() + " %";
                    ResultPercentLabel.Text = correct_percent.ToString() + " %";
                    CorrectAnswerPercentLabel.Location = new Point(354, 203 - 2 * correct_percent);
                    UnCorrectAnswerPercentLabel.Text = uncorrect_percent.ToString() + " %";
                    UnCorrectAnswerPercentLabel.Location = new Point(406, 203 - 2 * uncorrect_percent);
                    EmptyAnswerPercentLabel.Text = empty_answer_percent.ToString() + " %";
                    EmptyAnswerPercentLabel.Location = new Point(458, 203 - 2 * empty_answer_percent);
                }
            }
        }

        private void MetroAcceptbtn_Click(object sender, EventArgs e)
        {
            metroBtnSubmit.Enabled = true;
            var item = QuestionList2[int.Parse(labelQueue1.Text) - 1];
            AnswerList.Add(Answer);
            QuestionList2.RemoveAt(CurrentIndex);
            QuestionListSecond.Add(item);
        }
        private void MetroNextbtn_Click(object sender, EventArgs e)
        {
            metroBackbtn.Enabled = true;
            metroAcceptbtn.Enabled = false;
            if (IsClickedToSubmitButton)
            {
                if (CurrentIndex < QuestionListSecond.Count - 1)
                {

                    ++CurrentIndex;
                }
                ShowTest(QuestionListSecond, CurrentIndex);
            }
            else
            {
                if (CurrentIndex < QuestionList2.Count - 1)
                {

                    ++CurrentIndex;
                    ShowTest(QuestionList2, CurrentIndex);
                }
            }
        }
        private void MetroBackbtn_Click(object sender, EventArgs e)
        {
            metroAcceptbtn.Enabled = false;
            if (IsClickedToSubmitButton)
            {
                if (CurrentIndex > 0)
                {

                    --CurrentIndex;
                    ShowTest(QuestionListSecond, CurrentIndex);
                }
            }
            else
            {
                if (CurrentIndex > 0)
                {

                    --CurrentIndex;
                    ShowTest(QuestionList2, CurrentIndex);
                }
            }
        }
        public List<QuestionBlock> QuestionList2 { get; set; }
        public string FileName { get; set; }
        public string DirectoryName { get; set; }
        public string[] Files { get; set; }
        List<string> XmlFiles { get; set; }
        // public Button TestBookButton { get; set; }
        private void FillAllXmlFileToListView()
        {
            XmlFiles = new List<string>();
            DirectoryName = Directory.GetCurrentDirectory();
            Files = Directory.GetFiles(DirectoryName);
            foreach (var item in Files)
            {

                if (item.Contains(".xml"))
                {

                    XmlFiles.Add(item);
                }
            }
            int x = 0;
  
            foreach (var item in XmlFiles)
            {
                FileInfo file = new FileInfo(item);
                FileName = file.Name;
                Button testbtn = new Button();
                testbtn.Size = new Size(40, 150);
                testbtn.Location = new Point(20 + x, 60);

                testbtn.BackColor = Color.Pink;
                
             
                testbtn.Click += Testbtn_Click;
                testbtn.Text = FileName;
                x += 45;
                this.Controls.Add(testbtn);
            }
        }

        private void Testbtn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            FileName = btn.Text;

        }

        private void LoadFirstPageOfForm()
        {
            FillAllXmlFileToListView();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //first page 
            LoadFirstPageOfForm();


        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            DateTime date = DateTime.Now;


            QuizTime.Text = date.ToLongTimeString();


        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void RadioButton_Click(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton.Checked)
            {

                Answer = radioButton.Text;
                metroAcceptbtn.Enabled = true;
            }
            else
            {
                metroAcceptbtn.Enabled = false;
            }
        }
        public string Answer { get; set; }
        public List<string> AnswerList { get; set; }
        public bool IsClickedToSubmitButton { get; set; }
        public int CorrectCount { get; set; }
        public int UnCorrectCount { get; set; }
        public DialogResult ShowDialoq()
        {
            return base.ShowDialog();
        }
        private void DrawReturnButton()
        {
            BackButton = new MetroFramework.Controls.MetroButton();
            BackButton.Text = "Return";
            BackButton.UseCustomBackColor = true;
            BackButton.UseCustomForeColor = true;
            BackButton.BackColor = Color.FromName("MenuHighlight");
            BackButton.Font = new Font("Century", 12, FontStyle.Italic);
            BackButton.Size = new Size(50, 23);
            BackButton.Location = new Point(0, 0);
            BackButton.Highlight = true;
            BackButton.Click += BackButton_Click;
            this.Controls.Add(BackButton);
        }
        public PictureBox CorrectAnswerBox { get; set; }
        public PictureBox OwnAnswerBox { get; set; }
        private void ShowTest(List<QuestionBlock> questionlist, int curindex)
        {

            try
            {
                int y = 0;
                labelQueue1.Text = (curindex + 1).ToString();
                labelQueueQuestion.Text = "Question " + (curindex + 1) + " of " + questionlist.Count;
                if (curindex < questionlist.Count - 1)
                    labelQuestion1.Text = questionlist[curindex].Text;
                if (IsClickedToSubmitButton)
                    metroAcceptbtn.Enabled = false;
                for (int i = 0; i < 2 * questionlist[curindex].Answers.Count; i++)
                {
                    foreach (var item in this.Controls)
                    {
                        if (item is RadioButton rb)
                        {

                            rb.Dispose();
                        }
                        if (item is PictureBox pb)
                        {
                            pb.Dispose();
                        }
                    }
                }
                if (IsClickedToSubmitButton)
                {
                    for (int k = 0; k < questionlist[curindex].Answers.Count; k++)
                    {
                        questionlist[curindex].Answers.SingleOrDefault(x => x.IsCorrect == "Yes");
                        RadioButton radioButton = new RadioButton();
                        radioButton.Size = new Size(350, 60);
                        radioButton.Location = new Point(110, 192 + y);
                        radioButton.Text = questionlist[curindex].Answers[k].Text;
                        radioButton.Font = new Font("Century", 10, FontStyle.Italic);
                        y += 60;
                        var correctanswer = QuestionListSecond[curindex].Answers.SingleOrDefault(x => x.IsCorrect == "Yes");
                        if (radioButton.Text == correctanswer.Text)
                        {
                            CorrectAnswerBox = new PictureBox();
                            CorrectAnswerBox.Size = new Size(40, 35);
                            CorrectAnswerBox.Location = new Point(radioButton.Location.X - 50, radioButton.Location.Y + 10);
                            CorrectAnswerBox.Image = Properties.Resources.correctanswer;
                            CorrectAnswerBox.SizeMode = PictureBoxSizeMode.StretchImage;
                            this.Controls.Add(CorrectAnswerBox);
                        }
                        if (AnswerList[curindex] == radioButton.Text)
                        {
                            OwnAnswerBox = new PictureBox();
                            OwnAnswerBox.Size = new Size(40, 35);
                            OwnAnswerBox.Location = new Point(radioButton.Location.X - 90, radioButton.Location.Y + 10);
                            OwnAnswerBox.Image = Properties.Resources.bluecorrect;
                            radioButton.Checked = true;
                            OwnAnswerBox.SizeMode = PictureBoxSizeMode.StretchImage;
                            this.Controls.Add(OwnAnswerBox);//dispose picture box
                        }
                        radioButton.Click += RadioButton_Click;
                        this.Controls.Add(radioButton);
                    }
                }
                else
                {
                    for (int k = 0; k < questionlist[curindex].Answers.Count; k++)
                    {
                        questionlist[curindex].Answers.SingleOrDefault(x => x.IsCorrect == "Yes");
                        RadioButton radioButton = new RadioButton();
                        radioButton.Size = new Size(350, 60);
                        radioButton.Location = new Point(56, 192 + y);
                        radioButton.Text = questionlist[curindex].Answers[k].Text;
                        radioButton.Font = new Font("Century", 10, FontStyle.Italic);
                        y += 60;
                        radioButton.Click += RadioButton_Click;
                        this.Controls.Add(radioButton);
                    }
                }

            }
            catch (Exception)
            {
            }
            /////////
        }
        private void IncludeToTestByName(string filename)
        {
            QuestionList2 = new List<QuestionBlock>();
            XmlSerializer serializer = new XmlSerializer(typeof(QuestionBlock[]));
            if (File.Exists(filename))
            {
                using (FileStream f = new FileStream(filename, FileMode.OpenOrCreate))
                {
                    QuestionList = (serializer.Deserialize(f) as QuestionBlock[]).ToList();
                }
                using (FileStream f = new FileStream(filename, FileMode.OpenOrCreate))
                {
                    QuestionList2 = (serializer.Deserialize(f) as QuestionBlock[]).ToList();
                }
                ShowTest(QuestionList, CurrentIndex);
            }
        }
        private void buttonContinue_Click(object sender, EventArgs e)
        {
            ///////////////////////2
            for (int i = 0; i < this.Controls.Count * 5; i++)
            {
                foreach (var item in this.Controls)
                {
                    if (item is Label lb)
                    {
                        lb.Dispose();
                    }
                    else if (item is Button button)
                    {
                        button.Dispose();
                    }
                }
            }
            LoadSecondPageOfForm();
            Timer timer = new Timer();
            timer.Interval = 1000; timer.Start();
            timer.Tick += Timer_Tick;

            metroBtnSubmit.Enabled = true;
            metroBackbtn.Enabled = false;
            metroAcceptbtn.Enabled = false;

            IncludeToTestByName(FileName);
            //////////////
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            FillAllXmlFileToListView();
        }
    }
}
