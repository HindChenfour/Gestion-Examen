using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionExam.dao;
using GestionExam.models;

namespace GestionExam.interfaces {
    public partial class ProfesseurForm : Form {
        private ProfesseurDao professeurDao;

        public ProfesseurForm() {
            InitializeComponent();
            professeurDao = new ProfesseurDao();
        }

        private void submit_Click(object sender, EventArgs e) {
            Professeur p = new Professeur(input3.Text, input1.Text, input2.Text, input4.Text);
            professeurDao.insert(p);

            
        }

    }
}
