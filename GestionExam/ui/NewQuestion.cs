using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionExam.ui
{
    public partial class NewQuestion : UserControl
    {
        public NewQuestion()
        {
            InitializeComponent();
        }

        private void NewQuestion_Load(object sender, EventArgs e)
        {

        }

        public RichTextBox getQuestionTxtBox()
        {
            return questionTxtBox;
        }

        public String getQuestionValue()
        {
            return questionTxtBox.Text;
        }
    }
}
