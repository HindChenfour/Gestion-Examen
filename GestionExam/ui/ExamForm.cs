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
    public partial class ExamForm : Form {
        private Professeur p;
        private GestionExamenServices services;
        private Examen ex;
        private int id;

        public ExamForm() {
            InitializeComponent();
        }

        public ExamForm(Professeur p, GestionExamenServices services) {
            InitializeComponent();

            this.p = p;
            this.services = services;
            this.id = services.getExamsNumber(p) + 1;
            this.ex = new Examen(p, id);
        }

        private void exitBtn_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnMenu_Click(object sender, EventArgs e) {
            Close();
        }

        private void creationExamBtn_Click(object sender, EventArgs e) {
            ex.SetMatiere(matiereTxtBox.Text);
            ex.SetDuree(int.Parse(dureeNumeric.Value.ToString()));
            ex.SetDateOuverture(dateTimeOuverture.Value);
            ex.SetDateFermeture(dateTimeFermeture.Value);

            services.addExam(ex);

            String text = "Vous venez de compléter la première partie de la création de votre examen, cliquer sur continuer pour saisir les questions";
            QuestionsFormView questionsForm = new QuestionsFormView(ex, services);

            ConfirmationView confirmationView = new ConfirmationView(text, this, questionsForm);
            confirmationView.Show();
        }

        private void ExamForm_Load(object sender, EventArgs e) {
            emailLabel.Text = p.GetEmailAcademique();
        }
    }
}
