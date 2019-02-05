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

        QuestionBlock _block;
        public QuestionControl(QuestionBlock block)
        {
            _block = block;
            InitializeComponent();
            RadioButton radio = new RadioButton();
            radio.CheckedChanged += Radio_CheckedChanged;
        }

        private void Radio_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void QuestionControl_Load(object sender, EventArgs e)
        {

        }
    }
}
