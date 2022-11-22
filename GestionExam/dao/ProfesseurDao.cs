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

        public ProfesseurDao() {
            db = new MySqlDatabase("gestionexam");
        }

        public void insert(Professeur p) {
            db.insert(TABLE_NAME, p.GetCni(), p.GetNom(), p.GetPrenom(), p.GetTel());
        }
    }
}
