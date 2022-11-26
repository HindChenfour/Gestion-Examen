using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GestionExam.models;

namespace GestionExam.dao {
    interface QuestionDao {
        Question selectQuestionById(int id);
        Question selectQuestionById(int id, String type);
        List<Choix> selectChoices(int idQst);
        List<Question> selectAllQuestions();
        void insert(Question q, String type, int idExamen);
    }
}
