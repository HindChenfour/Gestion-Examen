using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GestionExam.dao;
using GestionExam.models;

namespace GestionExam.dao {
    class ProfesseurDao {
        private MySqlDatabase db;
        private const String TABLE_NAME = "professeur";

        public ProfesseurDao(MySqlDatabase db) {
            this.db = db;
        }

        public Professeur selectById(String id) {
            Object[] element = db.select(TABLE_NAME, "cni", id).ElementAt(0);

            return new Professeur(element[0].ToString(), element[1].ToString(), element[2].ToString(), element[3].ToString());
        }

        public List<Professeur> selectAll() {
            List<Object[]> data = db.selectAll(TABLE_NAME);
            List<Professeur> elements = new List<Professeur>();

            for (int i = 0; i < data.Count; i++) {
                Object[] element = data.ElementAt(i);
                elements.Add(new Professeur(element[0].ToString(), element[1].ToString(), element[2].ToString(), element[3].ToString()));
            }
            return elements;
        }


        public void insert(Professeur p) {
            db.insert(TABLE_NAME, p.GetCni(), p.GetNom(), p.GetPrenom(), p.GetTel());
        }
    }
}
