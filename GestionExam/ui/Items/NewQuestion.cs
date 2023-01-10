using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GestionExam.models;

namespace GestionExam.ui {
    public partial class NewQuestion : UserControl {
        private int id;
        private Question q;
        public NewChoicesList choices;
        private RichTextBox questionBlock;

        public NewQuestion() {
            InitializeComponent();
        }

        public NewQuestion(int id) {
            InitializeComponent();

            this.id = id;
        }

        private void setRichTextBox() {
            questionBlock = new RichTextBox();

            questionBlock.Name = "qstBlock_RichTxtbox";
            questionBlock.Location = new Point(25, 10);
            questionBlock.Font = new Font("Microsoft Sans Serif", 15);
            questionBlock.Size = new Size(500, 100);
        }

        private void qstDirecteBtn_Click(object sender, EventArgs e) {
            q = new QuestionDirecte(id);

            label.Text = "Question " + q.GetQuestionType() + " : ";
            qcmBtn.Hide();
            qstDirecteBtn.Hide();

            setRichTextBox();

            panel.Controls.Add(questionBlock);
            panel.Show();
        }

        private void qcmBtn_Click(object sender, EventArgs e) {
            q = new QuestionChoixMultiple(id);
            choices = new NewChoicesList((QuestionChoixMultiple) q);

            label.Text = "Question " + q.GetQuestionType() + " : ";
            qcmBtn.Hide();
            qstDirecteBtn.Hide();

            setRichTextBox();

            panel.Controls.Add(questionBlock);
            panel.Show();

            choices.Location = new Point(24, 220);
            this.Controls.Add(choices);
        }

        public void setQuestionValue() {
            q.SetQuestion(questionBlock.Text);
        }

        public void setQCMValue() {
            q.SetQuestion(questionBlock.Text);
            QuestionChoixMultiple qst = (QuestionChoixMultiple)q;
            qst.SetChoix(choices.getAllChoices());
            q = qst;
        }

        public Question getQuestion() {
            if (q.GetQuestionType().Equals("qcm")) {
                setQCMValue();
                return q;
            }

            setQuestionValue();
            return q;
        }


        public String getQuestionText() {
            return questionBlock.Text;
        }

        public List<Choix> getChoixList() {
            List<Choix> choicesList = choices.getAllChoices();
            return choicesList;
        }
    }
}
