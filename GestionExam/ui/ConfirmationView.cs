using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionExam.ui {
    public partial class ConfirmationView : Form {
        private Form formToHide;
        private Form formToShow;

        public ConfirmationView() {
            InitializeComponent();
        }

        public ConfirmationView(String text, Form formToHide, Form formToShow) {
            InitializeComponent();

            richTextBox1.Text = text;
            this.formToHide = formToHide;
            this.formToShow = formToShow;
        }

        public ConfirmationView(String text, Form formToHide) {
            InitializeComponent();

            richTextBox1.Text = text;
            this.formToHide = formToHide;
            this.formToShow = null;
        }

        private void btnConfirmation_Click(object sender, EventArgs e) {
            this.Close();
            formToHide.Close();
            if (formToShow != null) {
                formToShow.Show();
            }
        }
    }
}
