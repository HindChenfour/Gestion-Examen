using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using GestionExam.models;
using GestionExam.dao.mapping;

namespace GestionExam.dao {
    class ExamenDaoMySQL : ExamenDao {
        private MySqlDatabase db;
        private const String TABLE_NAME = "examen";

        public ExamenDaoMySQL(MySqlDatabase db) {
            this.db = db;
        }

        public void insert(Examen e) {
            db.insert(TABLE_NAME, ExamenMapping.GetExamenRow(e));
        }

        public Examen selectExamenById(int id) {
            return ExamenMapping.GetExamen(db.selectByKey(TABLE_NAME, "id_exam", id));
        }

        public List<Examen> selectExamenByMatiere(String matiere) {
            List<Object[]> data = db.select(TABLE_NAME, "matiere", matiere);
            List<Examen> elements = new List<Examen>();

            for (int i = 0; i < data.Count; i++) {
                Object[] element = data.ElementAt(i);
                elements.Add(ExamenMapping.GetExamen(element));
            }
            return elements;
        }

        public List<Examen> selectExamenByProfesseur(String email) {
            List<Object[]> data = db.select(TABLE_NAME, "email_realisateur", email);
            List<Examen> elements = new List<Examen>();

            for (int i = 0; i < data.Count; i++) {
                elements.Add(ExamenMapping.GetExamen(data.ElementAt(i)));
            }
            return elements;
        }

        public List<Examen> selectAll() {
            List<Object[]> data = db.selectAll(TABLE_NAME);
            List<Examen> elements = new List<Examen>();

            for (int i = 0; i < data.Count; i++) {
                elements.Add(ExamenMapping.GetExamen(data.ElementAt(i)));
            }
            return elements;
        }

    }
}
