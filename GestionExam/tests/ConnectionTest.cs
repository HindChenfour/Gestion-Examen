using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionExam.dao;
using System.Windows.Forms;
using GestionExam.interfaces;
using GestionExam.models;

namespace GestionExam.tests {
    class ConnectionTest {
        private MySqlDatabase db;

        public ConnectionTest() {
            exe02();
        }

        public void exe01() {
            db = new MySqlDatabase("gestionexam");
        }

        public void exe02() {
            db = new MySqlDatabase("gestionexam");
            ProfesseurDao professeurDao = new ProfesseurDao(db);

            List<Professeur> data = professeurDao.selectAll();
            Console.WriteLine(data.ToString());
        }

        public void exe03() {
            db = new MySqlDatabase("gestionexam");
            Application.Run(new ProfesseurForm());
        }

        public static void Main(String[] arg) {
            new ConnectionTest();
            Console.ReadKey();
        }
    }
}
