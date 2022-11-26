using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GestionExam.models;
using GestionExam.dao.mapping;

namespace GestionExam.dao {
    class CandidatDaoMySQL {
        private MySqlDatabase db;
        private const String TABLE_NAME = "candidat";

        public CandidatDaoMySQL(MySqlDatabase db) {
            this.db = db;
        }

        public Candidat selectById(String id) {
            Object[] element = db.select(TABLE_NAME, "email_academique", id).ElementAt(0);
            return ExamenMapping.GetCandidat(element);
        }

        public List<Candidat> selectAll() {
            List<Object[]> data = db.selectAll(TABLE_NAME);
            List<Candidat> elements = new List<Candidat>();

            for (int i = 0; i < data.Count; i++) {
                elements.Add(ExamenMapping.GetCandidat(data.ElementAt(i)));
            }
            return elements;
        }

        public void insert(Candidat c) {
            db.insert(TABLE_NAME, ExamenMapping.GetCandidatRow(c));
        }
    }
}
