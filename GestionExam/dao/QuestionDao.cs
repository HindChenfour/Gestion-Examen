using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GestionExam.models;

namespace GestionExam.dao {
    interface QuestionDao {
        Question selectQuestionById(int idQst, int idExam);
        Question selectQuestionById(int idQst, int idExam, String type);
        List<Choix> selectChoices(int idQst);
        List<Question> selectAllQuestions(int idExam);
        void insert(Question q, String type, int idExamen);
        void insertChoice(int idExam, int idQst, Choix c);
    }
}
