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
        public List<QuestionBlock> QuestionBlock { get; set; }
        public List<QuestionControl> questionControls { get; set; }
        public int CurrentIndex { get; set; }
        //QuestionControl questionControl1 = new QuestionControl();
        RadioButton radioButton = new RadioButton();
        private int y = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(QuestionBlock[]));
            if (File.Exists("QuestionsXML.xml"))
            {
                using (FileStream f = new FileStream("QuestionsXML.xml", FileMode.Open))
                {
                    QuestionBlock = (serializer.Deserialize(f) as QuestionBlock[]).ToList();
                }
                labelQuestion.Text = QuestionBlock[CurrentIndex].Text;
                for (int i = 0; i < QuestionBlock[CurrentIndex].Answers.Count; i++)
                {
                    radioButton = new RadioButton();
                    radioButton.Location = new Point(60, 150+y);
                    radioButton.Font = new Font("Century", 10, FontStyle.Italic);
                    radioButton.Text = QuestionBlock[CurrentIndex].Answers[i].Text;
                    radioButton.Size = new Size(250, 90);
                    y += 90;
                    this.Controls.Add(radioButton);
                }

            }
        }

        private void metroBackbtn_Click(object sender, EventArgs e)
        {

            --CurrentIndex;
            labelQuestion.Text = QuestionBlock[CurrentIndex].Text;
            

        }

        private void metroNextbtn_Click(object sender, EventArgs e)
        {

            ++CurrentIndex;
            labelQuestion.Text = QuestionBlock[CurrentIndex].Text;


        }
    }
}
