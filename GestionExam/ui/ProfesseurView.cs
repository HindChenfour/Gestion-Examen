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
        public static int nbExam = 0;

        public ProfesseurView() {
            InitializeComponent();
        }

        public ProfesseurView(Professeur p) {
            InitializeComponent();
            this.p = p;

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
            questionsPanel.Controls.Add(new NewQuestion());
        }

        private void exitBtn_Click(object sender, EventArgs e) {
            Close();
        }

        private void addQuestion(object sender, EventArgs e) {
            questionsPanel.Controls.Add(new NewQuestion());
        }

        private void getAllQuestionsBtn_Click(object sender, EventArgs e) {
            var collection = questionsPanel.Controls;
            for (int i = 0; i < collection.Count; i++)
            {
                NewQuestion q = (NewQuestion)collection[i];
                Console.WriteLine(" - " + q.getQuestionValue());
            }
        }

    }
}
