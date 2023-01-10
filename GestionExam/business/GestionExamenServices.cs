using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GestionExam.models;

namespace GestionExam.business {
    public interface GestionExamenServices {
        void addExam(Examen e);
        void addQuestion(Examen e, Question q, String type);
        void addQuestionDirecte(Examen e, QuestionDirecte q);
        void addQuestionCM(Examen e, QuestionChoixMultiple q);
        void addExamQuestions(Examen e);
        void addChoicesToQCM(Examen e, Question q, Choix c);
        void addProfesseur(Professeur p);
        void addCandidat(Candidat c);
        Examen getExam(int id);
        Question getQuestion(Examen exam, int idQst);
        Object getConnexion(String email, String pwd);
        Professeur getProfesseur(String email, String pwd);
        Candidat getCandidat(String email, String pwd);
        List<Examen> getExamsByProf(Professeur p);
        int getExamsNumber(Professeur p);
    }
}
