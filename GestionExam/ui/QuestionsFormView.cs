using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GestionExam.business;
using GestionExam.dao;
using GestionExam.models;

namespace GestionExam.ui {
    public partial class QuestionsFormView : Form {
        private GestionExamenServices services;
        private Professeur p;
        private Examen exam;
        private List<NewQuestion> questionsBlock;

        public QuestionsFormView() {
            InitializeComponent();
        }

        public QuestionsFormView(Examen exam, GestionExamenServices services)
        {
            InitializeComponent();

            this.exam = exam;
            this.p = this.exam.GetRealisateur();
            this.services = services;
            questionsBlock = new List<NewQuestion>();
        }


        private void ProfesseurView_Load(object sender, EventArgs e) {
            addQuestion(sender, e);
            emailLabel.Text = p.GetEmailAcademique();
        }

        private void exitBtn_Click(object sender, EventArgs e) {
            Close();
        }

        private void addQuestion(object sender, EventArgs e) {
            NewQuestion q = new NewQuestion(questionsBlock.Count + 1);

            questionsPanel.Controls.Add(q);
            questionsBlock.Add(q);
        }

         private void creationExamenBtn_click(object sender, EventArgs e) {

            for (int i = 0; i < questionsBlock.Count; i++) {
                Question q = questionsBlock.ElementAt(i).getQuestion();
                exam.AddQuestion(q);
            }
            services.addExamQuestions(exam);

            String text = "L'examen a été créé avec succès !!";

            ConfirmationView confirmationView = new ConfirmationView(text, this);
            confirmationView.Show();
         }
    }
}
