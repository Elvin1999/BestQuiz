using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    class ReadQuestionBlock
    {
        public TextBox Question { get; set; }
        public List<TextBox> Answer { get; set; }
        public List<RadioButton> AnswerRadioButtons { get; set; }
    }
}
