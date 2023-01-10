using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GestionExam.models;
using GestionExam.dao.mapping;

namespace GestionExam.dao {
    public class ReponseDaoMySQL : ReponseDao {
        private MySqlDatabase db;
        private const String RPS_DIRECT_TABLE = "reponse_directe";
        private const String RPS_QCM_TABLE = "reponse_qcm";

        public ReponseDaoMySQL(MySqlDatabase db) {
            this.db = db;
        }

        public Reponse selectReponseById(int id) {
            List<Object[]> element = db.select(RPS_DIRECT_TABLE, "id_rep", id);
            Reponse r;

            if (element.Count == 1) {
                return (ExamenMapping.GetReponseDirecte(element.ElementAt(0)));        
            }

            element = db.select(RPS_QCM_TABLE, "id_rep_choix", id);

            if(element.Count == 1) {
                return (ExamenMapping.GetReponseQCM(element.ElementAt(0)));
            }

            return null;
        } 

        public Choix selectReponseQCM(int id) {
            QuestionDao questionDao = new QuestionDaoMySQL(db);

            Reponse r = selectReponseById(id);
            List<Choix> choices = questionDao.selectChoices(r.GetIdQuest());

            for (int i = 0; i < choices.Count; i++) {
                Choix c = choices.ElementAt(i);
                if (c.GetIdChoix() == id) {
                    return c;
                }
            }
            return null;
        }

        public List<Reponse> selectAll() {
            List<Object[]> data = db.selectAll(RPS_DIRECT_TABLE);
            data.AddRange(db.selectAll(RPS_QCM_TABLE));

            List<Reponse> elements = new List<Reponse>();

            for (int i = 0; i < data.Count; i++) {
                Object[] element = data.ElementAt(i);
                int id = (int)element[0];

                elements.Add(selectReponseById(id));
            }
            return elements;
        }

        public void insert(Reponse r, String type) { 
            if (type.Equals("directe")) {
                db.insert(RPS_DIRECT_TABLE, ExamenMapping.GetReponseDirecteRow((ReponseDirecte)r));
                Console.WriteLine("reponse directe");
            }

            else if (type.Equals("qcm")) {
                db.insert(RPS_QCM_TABLE, ExamenMapping.GetReponseQCMRow((ReponseQCM)r));
            }
        }

    }
}
