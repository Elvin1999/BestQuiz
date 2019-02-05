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
        private void Form1_Load(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(QuestionBlock[]));
            if (File.Exists("QuestionsXML.xml"))
            {
                using (FileStream f = new FileStream("QuestionsXML.xml", FileMode.Open))
                {
                    QuestionBlock = (serializer.Deserialize(f) as QuestionBlock[]).ToList();
                }
                //using (StreamReader streamReader = new StreamReader("QuestionsXML.xml"))
                //{
                //    var obj = (List<QuestionBlock>)serializer.Deserialize(streamReader);
                //    QuestionBlock = obj;
                //}
                QuestionControl questionControl1 = new QuestionControl();
                questionControl1.Location = new Point(10, 10);
                questionControl1.Question.Text = QuestionBlock[0].Text;
                int y = 60;
                for (int i = 0; i < QuestionBlock[0].Answers.Count; i++)
                {
                    RadioButton radioButton = new RadioButton();
                    radioButton.Location = new Point(100,100*(i+1));
                    radioButton.Font = new Font("Century", 10, FontStyle.Italic);
                    radioButton.Text = QuestionBlock[0].Answers[i].Text;
                    radioButton.Size = new Size(300,90);
                    this.Controls.Add(radioButton);
                }
                this.Controls.Add(questionControl1);
            }
        }
    }
}
