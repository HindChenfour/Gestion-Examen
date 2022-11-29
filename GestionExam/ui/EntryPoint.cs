using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionExam.ui {
    class EntryPoint {
        public EntryPoint() {
            startApp();
        }

        public void startApp() {
            Application.Run(new LoginView());
        }

        public static void Main(String[] args) {
            new EntryPoint();
        } 
    }
}
