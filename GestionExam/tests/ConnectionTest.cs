using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionExam.dao;
using System.Windows.Forms;
using GestionExam.models;
using GestionExam.business;

namespace GestionExam.tests {
    class ConnectionTest {
        private MySqlDatabase db;

        private ProfesseurDao professeurDao;
        private CandidatDao candidatDao;
        private QuestionDao questionDao;
        private ReponseDao reponseDao;
        private ExamenDao examenDao;

        private GestionExamenServices services;

        public ConnectionTest() {
            db = new MySqlDatabase("gestionexamen");

            professeurDao = new ProfesseurDaoMySQL(db);
            candidatDao = new CandidatDaoMySQL(db);
            questionDao = new QuestionDaoMySQL(db);
            reponseDao = new ReponseDaoMySQL(db);
            examenDao = new ExamenDaoMySQL(db);

            services = new GestionExamenServicesDefault(professeurDao, candidatDao, questionDao, reponseDao, examenDao);

            exe15();
        }

        public void exe01() {
            Professeur p = new Professeur("amine.chenfour@usmba.ac.ma", "123");

            professeurDao.insert(p);
        }

        public void exe02() {
            Professeur p = professeurDao.selectById("amine.chenfour@usmba.ac.ma");

            Console.WriteLine(p);
        }

        public void exe03() {
            List<Professeur> data = professeurDao.selectAll();

            for (int i = 0; i < data.Count(); i++) {
                Console.WriteLine(data.ElementAt(i));
            }
        }


        public void exe04() {
            Candidat c = new Candidat("ali.bennani@usmba.ac.ma", "123");

            candidatDao.insert(c);
        }

        public void exe05() {
            Candidat c = candidatDao.selectById("hajar.bennani@usmba.ac.ma");

            Console.WriteLine(c);
        }

        public void exe06() {
            List<Candidat> data = candidatDao.selectAll();

            for (int i = 0; i < data.Count(); i++) {
                Console.WriteLine(data.ElementAt(i));
            }
        }

        public void exe07() {
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
            List<Question> data = questionDao.selectAllQuestions(2);

            for (int i = 0; i < data.Count(); i++) {
                Console.WriteLine(data.ElementAt(i));
            }
        }

        public void exe09() {
            QuestionChoixMultiple q = (QuestionChoixMultiple)questionDao.selectQuestionById(2, 2);
            Console.WriteLine(q.GetQuestion());

            for (int i = 0; i < q.GetChoix().Count(); i++) {
                Console.WriteLine(q.GetChoix().ElementAt(i).GetChoix());
            }
        }

        public void exe10() {
            ReponseDirecte rd1 = new ReponseDirecte(1, "C est l avreviation de Unifying Modeling Language");
            ReponseQCM rq1 = new ReponseQCM(2, 11);
            ReponseDirecte rd2 = new ReponseDirecte(3, "C est ...");
            ReponseQCM rq2 = new ReponseQCM(4, 23);

            reponseDao.insert(rd1, "directe");
            //reponseDao.insert(rq1, "qcm");
            reponseDao.insert(rd2, "directe");
            //reponseDao.insert(rq2, "qcm");
        }

        public void exe11() { 
            ReponseQCM r = (ReponseQCM)reponseDao.selectReponseById(11);
            Choix c = reponseDao.selectReponseQCM(11);

            Console.WriteLine(r.GetIdQuest() + " >> " + r.GetIdChoix() + " >> " + c.GetChoix());
        }

        public void exe12() {
            List<Reponse> data = reponseDao.selectAll();

            for (int i = 0; i < data.Count; i++) {
                Reponse r = data.ElementAt(i);
                Console.WriteLine(r.GetIdQuest());
            }
        }

        public void exe13() {
            Examen e1 = new Examen(3, new DateTime(2022, 12, 4, 14, 30, 0), new DateTime(2022, 12, 4, 16, 30, 0), 45, new Professeur("mehdi.chenfour@usmba.ac.ma"), "Java");
            examenDao.insert(e1);

            Examen e2 = new Examen(4, new DateTime(2022, 12, 4, 16, 30, 0), new DateTime(2022, 12, 4, 18, 30, 0), 45, new Professeur("mehdi.chenfour@usmba.ac.ma"), "Reseau");
            examenDao.insert(e2);

        }

        public void exe14() {
            Examen e = examenDao.selectExamenById(2);
            List<Examen> exams = examenDao.selectExamenByMatiere("Reseau");
            List<Examen> exams1 = examenDao.selectExamenByProfesseur("amine.chenfour@usmba.ac.ma");
            List<Examen> exams2 = examenDao.selectAll();

            Console.WriteLine(exams2);
        }

        public void exe15() {
            /*services.addProfesseur(new Professeur("mehdi.Chenfour@usmba.ac.ma", "123"));
            services.addProfesseur(new Professeur("mehdi.bennani@usmba.ac.ma", "123"));
            services.addProfesseur(new Professeur("alae.Alaoui@usmba.ac.ma", "123"));
            services.addProfesseur(new Professeur("amine.Bounani@usmba.ac.ma", "123"));
            services.addProfesseur(new Professeur("hind.lahnine@usmba.ac.ma", "123"));
            services.addProfesseur(new Professeur("imane.elghazi@usmba.ac.ma", "123"));*/

            Examen e1 = new Examen(1, new DateTime(2022, 12, 8, 13, 30, 0), new DateTime(2022, 12, 8, 14, 30, 0), 45, new Professeur("mehdi.bennani@usmba.ac.ma", "123"), "Java");
            Examen e2 = new Examen(2, new DateTime(2022, 12, 10, 13, 30, 0), new DateTime(2022, 12, 12, 14, 30, 0), 45, new Professeur("imane.elghazi@usmba.ac.ma", "123"), "Reseau");
            Examen e3 = new Examen(3, new DateTime(2022, 11, 30, 13, 30, 0), new DateTime(2022, 11, 30, 14, 30, 0), 45, new Professeur("amine.Bounani@usmba.ac.ma", "123"), "Oracle");

            /*services.addExam(e1);
            services.addExam(e2);
            services.addExam(e3);

            services.addQuestion(e1, new QuestionDirecte(1, "Expliquer le role de JDBC"), "directe");
            services.addQuestionDirecte(e1, new QuestionDirecte(2, "Expliquer le role de JDBC"));
            services.addQuestion(e1, new QuestionDirecte(3, "Expliquer le role de Java Database Conn"), "directe");

            services.addQuestion(e2, new QuestionDirecte(1, "Definisser OSI"), "directe");
            services.addQuestionDirecte(e2, new QuestionDirecte(2, "Definisser les étapes TCP/IP"));
            services.addQuestion(e2, new QuestionDirecte(3, "Expliquer la difference entre OSI et TCP/IP "), "directe");*/

            QuestionChoixMultiple q1 = new QuestionChoixMultiple(4, "Choisissez une reponse 1 :");
            QuestionChoixMultiple q2 = new QuestionChoixMultiple(5, "Choisissez une reponse 2 :");

            services.addQuestion(e3, q1, "qcm");
            services.addQuestionCM(e3, q2);

            services.addChoicesToQCM(e3, q1, new Choix(41, "choix 1", true));
            services.addChoicesToQCM(e3, q1, new Choix(42, "choix 2", false));

            services.addChoicesToQCM(e3, q2, new Choix(51, "choix 1", false));
            services.addChoicesToQCM(e3, q2, new Choix(52, "choix 2", true));
            services.addChoicesToQCM(e3, q2, new Choix(53, "choix 3", false));
        }


        public static void Main(String[] arg) {
            new ConnectionTest();
            Console.ReadKey();
        }
    }
}
