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
    public partial class LoginView : Form {
        private GestionExamenServices services;

        public LoginView() {
            InitializeComponent();
            wiring();
        }

        private void wiring() {
            //Wiring :
            MySqlDatabase db = new MySqlDatabase("gestionexamen");

            ProfesseurDao profeseurDao = new ProfesseurDaoMySQL(db);
            CandidatDao candidatDao = new CandidatDaoMySQL(db);

            services = new GestionExamenServicesDefault(profeseurDao, candidatDao);
        }

        private void exitBtn_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void LoginView_Load(object sender, EventArgs e) {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) {

        }

        private void btnLogin_Click(object sender, EventArgs e) {
            String email = emailTxtBox.Text;
            String pwd = pwdTxtBox.Text;

            String type = services.getConnexion(email, pwd).GetType().ToString();

            if(type.EndsWith("Professeur")) {
                ProfesseurView professeurView = new ProfesseurView();
                professeurView.Show();
            }

            
            //Hide();
        }
    }
}
