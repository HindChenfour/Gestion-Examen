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
    public partial class ProfesseurView : Form {
        private GestionExamenServices services;
        private Professeur p;
        private List<Examen> exams;
        private List<NewQuestion> questionsBlock;
        public static int nbExam = 0;

        public ProfesseurView() {
            InitializeComponent();

            exams = new List<Examen>();
            questionsBlock = new List<NewQuestion>();
        }

        public ProfesseurView(Professeur p) {
            InitializeComponent();

            this.p = p;
            exams = new List<Examen>();
            questionsBlock = new List<NewQuestion>();

            wiring();
        }

        private void wiring() {
            //Wiring :
            MySqlDatabase db = new MySqlDatabase("gestionexamen");

            ProfesseurDao profeseurDao = new ProfesseurDaoMySQL(db);
            ExamenDao examenDao = new ExamenDaoMySQL(db);
            QuestionDao questionDao = new QuestionDaoMySQL(db);
            ReponseDao reponseDao = new ReponseDaoMySQL(db);

            services = new GestionExamenServicesDefault(profeseurDao, questionDao, reponseDao, examenDao);
        }

        private void ProfesseurView_Load(object sender, EventArgs e) {
            addQuestion(sender, e);
            emailLabel.Text = p.GetEmailAcademique();
        }

        private void exitBtn_Click(object sender, EventArgs e) {
            Close();
        }

        private void addQuestion(object sender, EventArgs e) {
            NewQuestion q = new NewQuestion();

            questionsPanel.Controls.Add(q);
            questionsBlock.Add(q);
        }

         private void creationExamenBtn_click(object sender, EventArgs e) {
            nbExam ++;
            Examen ex = new Examen(
                nbExam,
                dateTimeOuverture.Value,
                dateTimeFermeture.Value,
                int.Parse(dureeNumeric.Value.ToString()),
                p,
                matiereTxtBox.Text
            );

            for (int i = 0; i < questionsBlock.Count; i++) {
                Question q = questionsBlock.ElementAt(i).getQuestion();
                ex.AddQuestion(q);
            }

            exams.Add(ex);
            services.addExam(ex);
        }

    }
}
