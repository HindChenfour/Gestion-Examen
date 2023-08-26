using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GestionExam.models;
using GestionExam.dao;
using GestionExam.dao.mapping;

namespace GestionExam.business {
    public class GestionExamenServicesDefault : GestionExamenServices {
        private ProfesseurDao professeurDao;
        private CandidatDao candidatDao;
        private QuestionDao questionDao;
        private ReponseDao reponseDao;
        private ExamenDao examenDao;

        public GestionExamenServicesDefault() { 

        }

        public GestionExamenServicesDefault(ProfesseurDao professeurDao, CandidatDao candidatDao) { 
            this.professeurDao = professeurDao;
            this.candidatDao = candidatDao;
        }

        public GestionExamenServicesDefault(ProfesseurDao professeurDao, QuestionDao questionDao, ReponseDao reponseDao, ExamenDao examenDao) {
            this.professeurDao = professeurDao;
            this.questionDao = questionDao;
            this.reponseDao = reponseDao;
            this.examenDao = examenDao;
        }

        public GestionExamenServicesDefault(ProfesseurDao professeurDao, CandidatDao candidatDao, QuestionDao questionDao, ReponseDao reponseDao, ExamenDao examenDao) { 
            this.professeurDao = professeurDao;
            this.candidatDao = candidatDao;
            this.questionDao = questionDao;
            this.reponseDao = reponseDao;
            this.examenDao = examenDao;
        }

        public void addProfesseur(Professeur p) {
            professeurDao.insert(p);
        }

        public void addCandidat(Candidat c) {
            candidatDao.insert(c);
        }

        public Object getConnexion(String email, String pwd) {
            MySqlDatabase db = new MySqlDatabase("gestionexamen");

            if (db.select("professeur", "email_academique", email).Count == 1) {
               
                return getProfesseur(email, pwd);
            }

            return getCandidat(email, pwd);
        }

        public Professeur getProfesseur(String email, String pwd) {
            Professeur prof = professeurDao.selectById(email);

            if(prof.GetMdp().Equals(pwd)) {
                return prof;
            }
            Console.WriteLine("returning null : " + prof.GetMdp() + "!=" + pwd);
            return null;
        }

        public Candidat getCandidat(String email, String pwd) {
            Candidat can = candidatDao.selectById(email);

            if (can.GetMdp().Equals(pwd)) {
                return can;
            }

            return null;
        }

        public void addExam(Examen e) {
            examenDao.insert(e);

            List<QuestionDirecte> qd = e.GetQuestionsDirecte();
            List<QuestionChoixMultiple> qcm = e.GetQuestionsCM();

            for (int i = 0; i < qd.Count; i++) {
                questionDao.insert(qd.ElementAt(i), "directe", e.GetId());
            }

            for (int i = 0; i < qcm.Count; i++) {
                questionDao.insert(qcm.ElementAt(i), "qcm", e.GetId());
            }
        }

        public void addQuestion(Examen e, Question q, String type) {
            questionDao.insert(q, type, e.GetId());
        }

        public void addQuestionDirecte(Examen e, QuestionDirecte q) {
            addQuestion(e, q, "directe");            
        }

        public void addQuestionCM(Examen e, QuestionChoixMultiple q) {
            addQuestion(e, q, "qcm");
        }

        public void addExamQuestions(Examen e) {
            List<Question> questions = e.Getquestions();

            for (int i = 0; i < questions.Count; i++) {
                Question q = questions.ElementAt(i);
                addQuestion(e, q, q.GetQuestionType());
            }
        }

        public void addChoicesToQCM(Examen e, Question q, Choix c) {
            questionDao.insertChoice(e.GetId(), q.GetId(), c);
        }

        public Examen getExam(int id) {
            Examen e = examenDao.selectExamenById(id);

            e.SetRealisateur(professeurDao.selectById(e.GetRealisateur().GetEmailAcademique()));
            e.SetQuestions(questionDao.selectAllQuestions(id));

            return e;
        }

        public Question getQuestion(Examen exam, int idQst) {
            return questionDao.selectQuestionById(idQst, exam.GetId());
        }

        public List<Examen> getExamsByProf(Professeur p) {
            return examenDao.selectExamenByProfesseur(p.GetEmailAcademique());
        }

        public int getExamsNumber(Professeur p) {
            return examenDao.selectExamsNumber(p.GetEmailAcademique());
        }
    }
}
