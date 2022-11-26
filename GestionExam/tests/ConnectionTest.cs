using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionExam.dao;
using System.Windows.Forms;
using GestionExam.models;

namespace GestionExam.tests {
    class ConnectionTest {
        private MySqlDatabase db;

        public ConnectionTest() {
            exe06();
        }

        public void exe01() {
            db = new MySqlDatabase("gestionexamen");
            ProfesseurDao professeurDao = new ProfesseurDao(db);
            Professeur p = new Professeur("amine.chenfour@usmba.ac.ma", "Chenfour", "amine");

            professeurDao.insert(p);
        }

        public void exe02() {
            db = new MySqlDatabase("gestionexamen");
            ProfesseurDao professeurDao = new ProfesseurDao(db);
            Professeur p = professeurDao.selectById("amine.chenfour@usmba.ac.ma");

            Console.WriteLine(p);
        }

        public void exe03() {
            db = new MySqlDatabase("gestionexamen");
            ProfesseurDao professeurDao = new ProfesseurDao(db);

            List<Professeur> data = professeurDao.selectAll();

            for (int i = 0; i < data.Count(); i++) {
                Console.WriteLine(data.ElementAt(i));
            }
        }


        public void exe04() {
            db = new MySqlDatabase("gestionexamen");
            CandidatDao candidatDao = new CandidatDao(db);
            Candidat c = new Candidat("ali.bennani@usmba.ac.ma", "ali", "bannani");

            candidatDao.insert(c);
        }

        public void exe05() {
            db = new MySqlDatabase("gestionexamen");
            CandidatDao candidatDao = new CandidatDao(db);
            Candidat c = candidatDao.selectById("hajar.bennani@usmba.ac.ma");

            Console.WriteLine(c);
        }

        public void exe06() {
            db = new MySqlDatabase("gestionexamen");
            CandidatDao candidatDao = new CandidatDao(db);

            List<Candidat> data = candidatDao.selectAll();

            for (int i = 0; i < data.Count(); i++) {
                Console.WriteLine(data.ElementAt(i));
            }
        }


        public static void Main(String[] arg) {
            new ConnectionTest();
            Console.ReadKey();
        }
    }
}
