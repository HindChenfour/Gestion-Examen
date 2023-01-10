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
        }

        public LoginView(GestionExamenServices services) {
            InitializeComponent();
            this.services = services;
        }

        private void exitBtn_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void LoginView_Load(object sender, EventArgs e) {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) {

        }

        public void btnLogin_Click(object sender, EventArgs e) {
            String email = emailTxtBox.Text;
            String pwd = pwdTxtBox.Text;

            String type = services.getConnexion(email, pwd).GetType().ToString();

            if(type.EndsWith("Professeur")) {
                HomeView home = new HomeView(new Professeur(email, pwd), services);
                home.Show();
            }
            Hide();
        }
    }
}
