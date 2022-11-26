using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GestionExam.models;
using GestionExam.dao.mapping;

namespace GestionExam.dao {
    class QuestionDaoMySQL : QuestionDao {
        private MySqlDatabase db;
        private const String QST_DIRECT_TABLE = "question_directe";
        private const String QCM_TABLE = "question_choix_multiple";
        private const String CHOICES_TABLE = "choix";

        public QuestionDaoMySQL(MySqlDatabase db) {
            this.db = db;
        }

        public Question selectQuestionById(int id, String type) {
            if (type.Equals("directe")) {
                Object[] element = db.selectByKey(QST_DIRECT_TABLE, "id_qst", id);
                return ExamenMapping.GetQuestionDirecte(element);
            }

            else if (type.Equals("qcm")) {
                Object[] element = db.selectByKey(QCM_TABLE, "id_qst", id);
                return ExamenMapping.GetQuestionCM(selectChoices(id), element);
            }
            return null;
        }

        public Question selectQuestionById(int id) {
            if (db.select(QST_DIRECT_TABLE, "id_qst", id).Count() == 1) {
                return selectQuestionById(id, "directe");
            }

            else if (db.select(QCM_TABLE, "id_qst", id).Count() == 1) {
                return selectQuestionById(id, "qcm");
            }
            return null;
        }

        public List<Question> selectAllQuestions() {
            List<Object[]> data = db.selectAll(QCM_TABLE);
            data.AddRange(db.selectAll(QST_DIRECT_TABLE));

            List<Question> elements = new List<Question>();

            for (int i = 0; i < data.Count; i++ ) {
                Object[] element = data.ElementAt(i);
                int id = (int)element[0];

                elements.Add(selectQuestionById(id));
            }
            return elements;
        }

        public List<Choix> selectChoices(int idQst) {
            List<Object[]> data = db.select(CHOICES_TABLE, "id_qst", idQst);
            List<Choix> choices = new List<Choix>();

            for (int i = 0; i < data.Count(); i++) {
                choices.Add(ExamenMapping.GetChoix(data.ElementAt(i)));
            }
            return choices;
        }

        public void insert(Question q, String type, int idExamen) {
            if (type.Equals("directe")) {
                db.insert(QST_DIRECT_TABLE, ExamenMapping.GetQuestionDirecteRow((QuestionDirecte)q, idExamen));
            }

            else if (type.Equals("qcm")) {
                QuestionChoixMultiple qcm = (QuestionChoixMultiple)q;
                List<Choix> choices = qcm.GetChoix();

                db.insert(QCM_TABLE, ExamenMapping.GetQuestionCMRow((QuestionChoixMultiple)q, idExamen));

                for (int i = 0; i < choices.Count(); i++) {
                    db.insert(CHOICES_TABLE, ExamenMapping.GetChoixRow(choices.ElementAt(i), q.GetId()));
                }
            }
        }
    }
}
