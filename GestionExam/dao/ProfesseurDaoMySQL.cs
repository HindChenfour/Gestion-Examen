using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GestionExam.dao;
using GestionExam.models;
using GestionExam.dao.mapping;

namespace GestionExam.dao {
    public class ProfesseurDaoMySQL : ProfesseurDao {
        private MySqlDatabase db;
        private const String TABLE_NAME = "professeur";

        public ProfesseurDaoMySQL(MySqlDatabase db) {
            this.db = db;
        }

        public Professeur selectById(String id) {
            Object[] element = db.selectByKey(TABLE_NAME, "email_academique", id);
            return ExamenMapping.GetProfesseur(element);
        }

        public List<Professeur> selectAll() {
            List<Object[]> data = db.selectAll(TABLE_NAME);
            List<Professeur> elements = new List<Professeur>();

            for (int i = 0; i < data.Count; i++) {
                elements.Add(ExamenMapping.GetProfesseur(data.ElementAt(i)));
            }
            return elements;
        }


        public void insert(Professeur p) {
            db.insert(TABLE_NAME, ExamenMapping.GetProfesseurRow(p));
        }
    }
}
