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
        private void Form1_Load(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<QuestionBlock>));
            if (File.Exists("QuestionsXML.xml"))
            {
                TextReader r = new StreamReader("QuestionsXML.xml");
                var itemlist = (List<QuestionBlock>)serializer.Deserialize(r);                
                QuestionControl questionControl1 = new QuestionControl();
                questionControl1.Location = new Point(10, 10);
                questionControl1.Question.Text = itemlist[0].Text;
                this.Controls.Add(questionControl1);
            }
        }
    }
}
