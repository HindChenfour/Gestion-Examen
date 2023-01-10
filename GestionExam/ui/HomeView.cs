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


namespace GestionExam.ui
{
    public partial class HomeView : Form {
        private GestionExamenServices services;
        private Professeur p;
        private List<Examen> exams;


        public HomeView() {
            InitializeComponent();

            p = new Professeur();
            exams = new List<Examen>();
        }

        public HomeView(Professeur p, GestionExamenServices services) {
            InitializeComponent();

            this.p = p;
            this.services = services;           
            this.exams = services.getExamsByProf(p);

            emailLabel.Text = p.GetEmailAcademique();
        }

        private void exitBtn_Click(object sender, EventArgs e) {
            Close();
            Application.Exit();
        }

        public void btnCreateExam_Click(object sender, EventArgs e) {
            ExamForm form = new ExamForm(p, services);
            form.Show();
        }

        private void HomeView_Load(object sender, EventArgs e) {
            this.exams = services.getExamsByProf(p);
            btnListExam.Text += "   (" + exams.Count + ")";
        }

        private void HomeView_Paint(object sender, PaintEventArgs e) {
            this.exams = services.getExamsByProf(p);
            btnListExam.Text = "Consulter ma liste d'examens   (" + exams.Count + ")";
        }
    }
}
