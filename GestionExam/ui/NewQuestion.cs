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
//        private Point position;
        FlowLayoutPanel flowPanel;

        public NewQuestion() {
            InitializeComponent();

            flowPanel = new FlowLayoutPanel();
            flowPanel.Location = new Point(5, 200);
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

            //this.Size = new Rectangle(0, 0, 794, 580).Size;
            setRichTextBox();

            NewChoice c = new NewChoice();
            choices.Add(c);

            Button btnAjouter = new Button();
            btnAjouter.Text = "Ajouter un choix";
            btnAjouter.Name = "bntAjouter";
            btnAjouter.Location = new Point(380, 170);
            btnAjouter.Size = new Rectangle(0, 0, 180, 40).Size;
            btnAjouter.Font = new Font("Microsoft Sans Serif", 15);

            btnAjouter.Click += btnAjouterChoix_click;

            flowPanel.Location = new Point(19, 233);
            flowPanel.Size = new Rectangle(0, 0, 500, 280).Size;
           

            flowPanel.Controls.Add(c);
            flowPanel.Show();

            panel.Controls.Add(questionBlock);
            panel.Show();

            this.Controls.Add(btnAjouter);
            this.Controls.Add(flowPanel);
        }

        private void btnAjouterChoix_click(object sender, EventArgs e) {
            NewChoice c = new NewChoice();

//            position.Y += 50;
//            c.Location = position;

            choices.Add(c);
            flowPanel.Controls.Add(c);
        }

        public void setQuestionDirecteValue() {
            q.SetQuestion(questionBlock.Text);
        }

        public void setQuestionCMValue() {
            q.SetQuestion(questionBlock.Text);
            q = (QuestionChoixMultiple)q;
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
