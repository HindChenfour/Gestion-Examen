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
            db = new MySqlDatabase("gestionexamen");
            exe09();
        }

        public void exe01() {
            ProfesseurDao professeurDao = new ProfesseurDaoMySQL(db);
            Professeur p = new Professeur("amine.chenfour@usmba.ac.ma", "Chenfour", "amine");

            professeurDao.insert(p);
        }

        public void exe02() {
            ProfesseurDao professeurDao = new ProfesseurDaoMySQL(db);
            Professeur p = professeurDao.selectById("amine.chenfour@usmba.ac.ma");

            Console.WriteLine(p);
        }

        public void exe03() {
            ProfesseurDao professeurDao = new ProfesseurDaoMySQL(db);

            List<Professeur> data = professeurDao.selectAll();

            for (int i = 0; i < data.Count(); i++) {
                Console.WriteLine(data.ElementAt(i));
            }
        }


        public void exe04() {
            CandidatDao candidatDao = new CandidatDaoMySQL(db);
            Candidat c = new Candidat("ali.bennani@usmba.ac.ma", "ali", "bannani");

            candidatDao.insert(c);
        }

        public void exe05() {
            CandidatDao candidatDao = new CandidatDaoMySQL(db);
            Candidat c = candidatDao.selectById("hajar.bennani@usmba.ac.ma");

            Console.WriteLine(c);
        }

        public void exe06() {
            CandidatDao candidatDao = new CandidatDaoMySQL(db);

            List<Candidat> data = candidatDao.selectAll();

            for (int i = 0; i < data.Count(); i++) {
                Console.WriteLine(data.ElementAt(i));
            }
        }

        public void exe07() {
            QuestionDao questionDao = new QuestionDaoMySQL(db);

            QuestionDirecte qd1 = new QuestionDirecte(1, "Définir Le langage UML : ");

            QuestionChoixMultiple qcm1 = new QuestionChoixMultiple(2, "Que sifgnifie UML : ");
            List<Choix> choices1 = new List<Choix>();
            choices1.Add(new Choix(11, "Uniffying Modeling Language", true));
            choices1.Add(new Choix(12, "Uniffying Mother Language", false));
            choices1.Add(new Choix(13, "United Marckup Language", false));
            qcm1.SetChoix(choices1);

            QuestionDirecte qd2 = new QuestionDirecte(3, "Quel est le role du diagramme de transition : ");

            QuestionChoixMultiple qcm2 = new QuestionChoixMultiple(4, "Que sifgnifie HTML : ");
            List<Choix> choices2 = new List<Choix>();
            choices2.Add(new Choix(21, "Hard Text  Modeling Language", false));
            choices2.Add(new Choix(22, "HyperText Marckup Language", true));
            choices2.Add(new Choix(23, "Uniffying Modeling Language", false));
            qcm2.SetChoix(choices2);

            questionDao.insert(qd1, qd1.GetType(), 0);
            questionDao.insert(qcm1, qcm1.GetType(), 0);
            questionDao.insert(qd2, qd2.GetType(), 0);
            questionDao.insert(qcm2, qcm2.GetType(), 0);
        }

        public void exe08() {
            QuestionDao questionDao = new QuestionDaoMySQL(db);
            List<Question> data = questionDao.selectAllQuestions();

            for (int i = 0; i < data.Count(); i++) {
                Console.WriteLine(data.ElementAt(i));
            }
        }

        public void exe09() {
            QuestionDao questionDao = new QuestionDaoMySQL(db);

            QuestionChoixMultiple q = (QuestionChoixMultiple)questionDao.selectQuestionById(2);
            Console.WriteLine(q.GetQuestion());

            for (int i = 0; i < q.GetChoix().Count(); i++) {
                Console.WriteLine(q.GetChoix().ElementAt(i).GetChoix());
            }
        }


        public static void Main(String[] arg) {
            new ConnectionTest();
            Console.ReadKey();
        }
    }
}
