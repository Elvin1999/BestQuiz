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
        private void metroButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public List<QuestionBlock> QuestionList { get; set; }
        public List<QuestionBlock> QuestionListSecond { get; set; }
        public int CurrentIndex = 0;
        RadioButton radioButton = new RadioButton();
        private void Form1_Load(object sender, EventArgs e)
        {
            metroAcceptbtn.Enabled = false;
            XmlSerializer serializer = new XmlSerializer(typeof(QuestionBlock[]));
            if (File.Exists("QuestionsXML.xml"))
            {
                using (FileStream f = new FileStream("QuestionsXML.xml", FileMode.Open))
                {
                    QuestionList = (serializer.Deserialize(f) as QuestionBlock[]).ToList();
                }
                ShowTest(QuestionList, CurrentIndex);

            }
        }
        private void RadioButton_Click(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton.Checked)
            {

                Answer = radioButton.Text;
                MessageBox.Show(Answer);
                metroAcceptbtn.Enabled = true;
            }
            else
            {
                metroAcceptbtn.Enabled = false;
            }
        }

        private void metroBackbtn_Click(object sender, EventArgs e)
        {
            metroAcceptbtn.Enabled = false;
            if (CurrentIndex > 0)
            {
                --CurrentIndex;
                foreach (var item in this.Controls)
                {
                    if (item is RadioButton rb)
                    {
                        rb.Dispose();
                    }
                }
                ShowTest(QuestionList, CurrentIndex);
            }
        }
        private void metroNextbtn_Click(object sender, EventArgs e)
        {
            metroAcceptbtn.Enabled = false;
            if (CurrentIndex < QuestionList.Count - 1)
            {
                ++CurrentIndex;
                foreach (var item in this.Controls)
                {
                    if (item is RadioButton rb)
                    {
                        rb.Dispose();
                    }
                }
                ShowTest(QuestionList, CurrentIndex);
            }
        }
        public string Answer { get; set; }
        public List<string> AnswerList { get; set; }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //RadioButton radioButton = sender as RadioButton;
            //Answer = radioButton.Text;
            //MessageBox.Show(Answer);
        }
        private void metroAcceptbtn_Click(object sender, EventArgs e)
        {
            var item = QuestionList[CurrentIndex];
            AnswerList.Add(Answer);//I'll check this answer with SecondQuestionList's answers
            QuestionListSecond.Add(item);
        }
        public bool IsClickedToSubmitButton { get; set; }
        public int CorrectCount { get; set; }
        public int UnCorrectCount { get; set; }
        private void metroBtnSubmit_Click(object sender, EventArgs e)
        {

            CorrectCount = 0;
            UnCorrectCount = 0;

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
            QuestionList = QuestionListSecond;
            ShowTest(QuestionList, CurrentIndex);
        }
        private void ShowTest(List<QuestionBlock> questionlist, int curindex)
        {
            if (IsClickedToSubmitButton)
            {
                metroAcceptbtn.Enabled = false;
                metroBtnSubmit.Enabled = false;
            }
            int y = 0;
            labelQueue.Text = (curindex + 1).ToString();
            labelQueueQuestion.Text = "Question " + (curindex + 1) + " of " + questionlist.Count;
            labelQuestion.Text = questionlist[curindex].Text;
            for (int k = 0; k < questionlist[curindex].Answers.Count; k++)
            {
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
        private void labelQuestion_Click(object sender, EventArgs e)
        {

        }
    }
}
