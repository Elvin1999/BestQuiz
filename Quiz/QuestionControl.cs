using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class QuestionControl : UserControl
    {

        public QuestionBlock Block { get; set; }
        public List<RadioButton> ListRadiobutton { get; set; }
        public List<RadioButton> ListRadiobuttonCopy { get; set; }
        public QuestionControl(QuestionBlock block)
        {

            Block = new QuestionBlock();
            Block = block;
            InitializeComponent();
            ListRadiobutton = new List<RadioButton>();
            ListRadiobuttonCopy = new List<RadioButton>();
            int y = 0;
            for (int i = 0; i < Block.Answers.Count; i++)
            {
                RadioButton radioButton = new RadioButton
                {
                    Location = new Point(60, 155 + y),
                    Font = new Font("Century", 10, FontStyle.Italic),
                    Text = Block.Answers[i].Text,
                    Size = new Size(350, 60)
                };
                y += 60;
                ListRadiobutton.Add(radioButton);

            }
            ListRadiobuttonCopy = ListRadiobutton;
            this.Controls.AddRange(ListRadiobutton.ToArray());
        }

        private void Radio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void QuestionControl_Load(object sender, EventArgs e)
        {

        }
    }
}
