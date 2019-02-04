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
        public Label Question { get { return labelQuestion; } set { labelQuestion = value; } }
        public QuestionControl()
        {
            InitializeComponent();
        }
        private void QuestionControl_Load(object sender, EventArgs e)
        {

        }
    }
}
