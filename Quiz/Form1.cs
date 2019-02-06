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
        RadioButton radioButton = new RadioButton();
        private int y = 0; 
        private void Form1_Load(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(QuestionBlock[]));
            questionControls = new List<QuestionControl>();
            if (File.Exists("QuestionsXML.xml"))
            {

                using (FileStream f = new FileStream("QuestionsXML.xml", FileMode.Open))
                {
                    QuestionBlock = (serializer.Deserialize(f) as QuestionBlock[]).ToList();
                }

                labelQuestion.Text = QuestionBlock[CurrentIndex].Text;
                QuestionControl controls = new QuestionControl(QuestionBlock[CurrentIndex]);
                questionControls.Add(controls);
                this.Controls.AddRange(questionControls.ToArray());
            }
        }
        private void metroBackbtn_Click(object sender, EventArgs e)
        {
            for (int k = 0; k < questionControls[CurrentIndex].ListRadiobutton.Count; k++)
            {
                questionControls[CurrentIndex].ListRadiobutton[k].Visible = false;
            }
            --CurrentIndex;
            labelQuestion.Text = QuestionBlock[CurrentIndex].Text;
            QuestionControl controls = new QuestionControl(QuestionBlock[CurrentIndex]);
            questionControls.Add(controls);
            this.Controls.AddRange(questionControls.ToArray());
        }

        private void metroNextbtn_Click(object sender, EventArgs e)
        {

            for (int k = 0; k < questionControls[CurrentIndex].ListRadiobutton.Count; k++)
            {
                questionControls[CurrentIndex].ListRadiobutton[k].Visible = false;
            }

            ++CurrentIndex;
            labelQuestion.Text = QuestionBlock[CurrentIndex].Text;
            QuestionControl controls = new QuestionControl(QuestionBlock[CurrentIndex]);
            questionControls.Add(controls);
            this.Controls.AddRange(questionControls.ToArray());
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
