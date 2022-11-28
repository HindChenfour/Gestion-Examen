using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionExam.ui
{
    public partial class ProfesseurView : Form
    {
        public ProfesseurView()
        {
            InitializeComponent();
        }

        private void ProfesseurView_Load(object sender, EventArgs e)
        {
            questionsPanel.Controls.Add(new NewQuestion());
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addQuestion(object sender, EventArgs e)
        {
            questionsPanel.Controls.Add(new NewQuestion());
        }

        private void getAllQuestionsBtn_Click(object sender, EventArgs e)
        {
            var collection = questionsPanel.Controls;
            for (int i = 0; i < collection.Count; i++)
            {
                NewQuestion q = (NewQuestion)collection[i];
                Console.WriteLine(" - " + q.getQuestionValue());
            }
        }

    }
}
