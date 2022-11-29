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
        public static int nbrQ = 0;
        private Question q;
        private List<NewChoice> choices;
        private RichTextBox questionBlock;

        public NewQuestion() {
            InitializeComponent();
        }

        private void setRichTextBox() {
            questionBlock = new RichTextBox();

            questionBlock.Name = "qstBlock_RichTxtbox";
            questionBlock.Location = new Point(25, 10);
            questionBlock.Font = new Font("Microsoft Sans Serif", 15);
            questionBlock.Size = new Size(500, 100);
        }

        private void qstDirecteBtn_Click(object sender, EventArgs e) {
            nbrQ ++;
            q = new QuestionDirecte(nbrQ);

            label.Text = "Question " + q.GetType() + " : ";
            qcmBtn.Hide();
            qstDirecteBtn.Hide();

            setRichTextBox();

            panel.Controls.Add(questionBlock);
            panel.Show();
        }

        private void qcmBtn_Click(object sender, EventArgs e) {
            nbrQ++;
            q = new QuestionChoixMultiple(nbrQ);
            choices = new List<NewChoice>();

            label.Text = "Question " + q.GetType() + " : ";
            qcmBtn.Hide();
            qstDirecteBtn.Hide();

            setRichTextBox();

            NewChoice c = new NewChoice();
            c.Location = new Point(25, 100);

            Button btnAjouter = new Button();

            btnAjouter.Text = "Ajouter";
            btnAjouter.Name = "bntAjouter";
            btnAjouter.Location = new Point(675, 100);
            btnAjouter.Click += btnAjouterChoix_click;
            choices.Add(c);

            panel.Controls.Add(questionBlock);
            panel.Controls.Add(c);
            panel.Controls.Add(btnAjouter);
            panel.Show();
        }

        private void btnAjouterChoix_click(object sender, EventArgs e) {
            NewChoice c = new NewChoice();

            choices.Add(c);
            panel.Controls.Add(c);
        }

        public void setQuestionDirecteValue() {
            q.SetQuestion(questionBlock.Text);
        }

        public void setQuestionCMValue() {

        }

        public void setQuestionValue() {
            if (q.GetType().Equals("directe")) {
                setQuestionDirecteValue();
            }

            if (q.GetType().Equals("qcm")) {
                setQuestionCMValue();
            }

        }

        public Question getQuestion() {
            setQuestionValue();
            return q;
        }


        public String getQuestionText() {
            return questionBlock.Text;
        }

    }
}
