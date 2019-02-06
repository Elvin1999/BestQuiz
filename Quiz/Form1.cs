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
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public List<QuestionBlock> QuestionList { get; set; }
        public int CurrentIndex { get; set; }
        RadioButton radioButton = new RadioButton();
        private void Form1_Load(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(QuestionBlock[]));
            if (File.Exists("QuestionsXML.xml"))
            {
                using (FileStream f = new FileStream("QuestionsXML.xml", FileMode.Open))
                {
                    QuestionList = (serializer.Deserialize(f) as QuestionBlock[]).ToList();
                }
                labelQuestion.Text = QuestionList[CurrentIndex].Text;
                int y = 0;
                labelQueueQuestion.Text = "Question " + (CurrentIndex+1) + " of " + QuestionList.Count;
                for (int k = 0; k < QuestionList[CurrentIndex].Answers.Count; k++)
                {
                    RadioButton radioButton = new RadioButton();
                    radioButton.Size = new Size(350, 60);
                    radioButton.Location = new Point(56, 192+y);
                    radioButton.Text= QuestionList[CurrentIndex].Answers[k].Text;
                    radioButton.Font = new Font("Century", 10, FontStyle.Italic);
                    y += 60;
                    this.Controls.Add(radioButton);
                }
                int i = 0;
            }
        }
        private void metroBackbtn_Click(object sender, EventArgs e)
        {
            --CurrentIndex;int y = 0;
            labelQueueQuestion.Text = "Question " + (CurrentIndex + 1) + " of " + QuestionList.Count;
            foreach (var item in this.Controls)
            {
                if (item is RadioButton rb)
                {
                    rb.Dispose();
                }
            }
            labelQuestion.Text = QuestionList[CurrentIndex].Text;
            for (int k = 0; k < QuestionList[CurrentIndex].Answers.Count; k++)
            {
                RadioButton radioButton = new RadioButton();
                radioButton.Size = new Size(350, 60);
                radioButton.Location = new Point(56, 192 + y);
                radioButton.Text = QuestionList[CurrentIndex].Answers[k].Text;
                radioButton.Font = new Font("Century", 10, FontStyle.Italic);
                y += 60;
                this.Controls.Add(radioButton);
            }
        }
        private void metroNextbtn_Click(object sender, EventArgs e)
        {
            ++CurrentIndex;int y = 0;
            labelQueueQuestion.Text = "Question " + (CurrentIndex + 1) + " of " + QuestionList.Count;
            foreach (var item in this.Controls)
            {
                if(item is RadioButton rb)
                {
                    rb.Dispose();
                }
            }
            labelQuestion.Text = QuestionList[CurrentIndex].Text;
            for (int k = 0; k < QuestionList[CurrentIndex].Answers.Count; k++)
            {
                RadioButton radioButton = new RadioButton();
                radioButton.Size = new Size(350, 60);
                radioButton.Location = new Point(56, 192 + y);
                radioButton.Text = QuestionList[CurrentIndex].Answers[k].Text;
                radioButton.Font = new Font("Century", 10, FontStyle.Italic);
                y += 60;
                this.Controls.Add(radioButton);
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metroAcceptbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
