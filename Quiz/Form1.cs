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
        private void LoadFirstPageOfForm()
        {

        }
        private void LoadSecondPageOfForm()
        {
            metroBtnSubmit = new MetroFramework.Controls.MetroButton();
            metroBtnSubmit.Size = new Size(90, 30);
            metroBtnSubmit.Location = new Point(794, 587);
            metroBtnSubmit.Highlight = true;
            metroBtnSubmit.Text = "Submit";
            metroBtnSubmit.Font = new Font("Century", 10, FontStyle.Italic);
            metroBtnSubmit.Click += MetroBtnSubmit_Click;
            this.Controls.Add(metroBtnSubmit);

            metroNextbtn = new MetroFramework.Controls.MetroButton();
            metroNextbtn.Size = new Size(90, 30);
            metroNextbtn.Location = new Point(519, 587);
            metroNextbtn.Highlight = true;
            metroNextbtn.Text = "Next";
            metroNextbtn.Font = new Font("Century", 10, FontStyle.Italic);
            metroNextbtn.Click += MetroNextbtn_Click;
            this.Controls.Add(metroNextbtn);

            metroBackbtn = new MetroFramework.Controls.MetroButton();
            metroBackbtn.Size = new Size(90, 30);
            metroBackbtn.Location = new Point(144, 587);
            metroBackbtn.Highlight = true;
            metroBackbtn.Text = "Back";
            metroBackbtn.Font = new Font("Century", 10, FontStyle.Italic);
            metroBackbtn.Click += MetroBackbtn_Click;
            this.Controls.Add(metroBackbtn);
            metroAcceptbtn = new MetroFramework.Controls.MetroButton();
            metroAcceptbtn.Size = new Size(90, 30);
            metroAcceptbtn.Location = new Point(326, 587);
            metroAcceptbtn.Highlight = true;
            metroAcceptbtn.Font = new Font("Century", 10, FontStyle.Italic);
            metroAcceptbtn.Text = "Accept";
            metroAcceptbtn.Click += MetroAcceptbtn_Click;
            this.Controls.Add(metroAcceptbtn);

            BackButton = new MetroFramework.Controls.MetroButton();
            BackButton.Text = "Back";
            BackButton.Font = new Font("Century", 8, FontStyle.Italic);
            BackButton.Size = new Size(34, 23);
            BackButton.Location = new Point(893, 0);
            BackButton.Highlight = true;
            BackButton.Click += BackButton_Click;
            labelQueueQuestion = new Label();
            labelQueueQuestion.Size = new Size(120, 20);
            labelQueueQuestion.Location = new Point(12, 580);
            labelQueueQuestion.Font = new Font("Century", 8, FontStyle.Italic);
            labelQueue1 = new Label();
            labelQueue1.Text = "1";
            labelQueue1.Font = new Font("Century", 12, FontStyle.Italic);
            labelQueue1.Size = new Size(30, 25);
            labelQueue1.Location = new Point(15, 40);
            labelQuestion1 = new Label();
            labelQuestion1.Size = new Size(730, 145);
            labelQuestion1.Location = new Point(52, 10);
            labelQuestion1.Font = new Font("Monotype Corsiva", 16, FontStyle.Italic);
            labelQuestion1.ForeColor = Color.Maroon;
            this.Controls.Add(labelQueueQuestion); this.Controls.Add(BackButton);
            this.Controls.Add(labelQueue1); this.Controls.Add(labelQuestion1);
        }
        private void MetroBtnSubmit_Click(object sender, EventArgs e)
        {
            CorrectCount = 0;
            UnCorrectCount = 0;
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
            MessageBox.Show($"Correct {CorrectCount} UnCorrect {UnCorrectCount}");
            CurrentIndex = 0;
            ShowTest(QuestionListSecond, CurrentIndex);
        }
        int d = 0;
        private void MetroAcceptbtn_Click(object sender, EventArgs e)
        {
            metroBtnSubmit.Enabled = true;
            var item = QuestionList2[int.Parse(labelQueue1.Text) - 1];
            AnswerList.Add(Answer);
            QuestionList2.RemoveAt(CurrentIndex);
            QuestionListSecond.Add(item);

            //    var correctindex = QuestionListSecond[CurrentIndex].Answers.FindIndex(x => x.IsCorrect == "Yes");
            //    var myownindex = QuestionListSecond[CurrentIndex].Answers.FindIndex(x => x.Text == AnswerList[d]);
            //    MessageBox.Show($"Correct {correctindex} Own {myownindex}");
            //++d;

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
                if (CurrentIndex < QuestionList.Count - 1)
                {

                    ++CurrentIndex;
                }
                ShowTest(QuestionList2, CurrentIndex);
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
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSecondPageOfForm();
            metroBtnSubmit.Enabled = false;
            metroBackbtn.Enabled = false;
            metroAcceptbtn.Enabled = false;
            QuestionList2 = new List<QuestionBlock>();
            XmlSerializer serializer = new XmlSerializer(typeof(QuestionBlock[]));
            if (File.Exists("QuestionsXML.xml"))
            {
                using (FileStream f = new FileStream("QuestionsXML.xml", FileMode.OpenOrCreate))
                {
                    QuestionList = (serializer.Deserialize(f) as QuestionBlock[]).ToList();
                }
                using (FileStream f = new FileStream("QuestionsXML.xml", FileMode.OpenOrCreate))
                {
                    QuestionList2 = (serializer.Deserialize(f) as QuestionBlock[]).ToList();
                }
                ShowTest(QuestionList, CurrentIndex);
            }
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
        private void ShowTest(List<QuestionBlock> questionlist, int curindex)
        {
            int y = 0;
            labelQueue1.Text = (curindex + 1).ToString();
            labelQueueQuestion.Text = "Question " + (curindex + 1) + " of " + questionlist.Count;
            labelQuestion1.Text = questionlist[curindex].Text;
            if (IsClickedToSubmitButton)
                metroAcceptbtn.Enabled = false;
            int c = 0;
            for (int i = 0; i < 2 * questionlist[curindex].Answers.Count; i++)
            {
                foreach (var item in this.Controls)
                {
                    if (item is RadioButton rb)
                    {
                        ++c;
                        rb.Dispose();
                    }
                }
            }
            int putCorrectnotation = 0;
            int putWrongnotation = 0;
            if (IsClickedToSubmitButton)
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
                    var correctanswer = QuestionListSecond[curindex].Answers.SingleOrDefault(x => x.IsCorrect == "Yes");
                    if (radioButton.Text == correctanswer.Text)
                    {
                        radioButton.BackColor = Color.Green;
                    }
                    if (AnswerList[curindex] == radioButton.Text)
                    {
                      
                        radioButton.BackColor = Color.Blue;
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

    }
}
