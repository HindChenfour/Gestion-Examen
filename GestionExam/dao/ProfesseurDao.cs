using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GestionExam.models;
using GestionExam.dao.mapping;

namespace GestionExam.dao.mapping {
    interface ProfesseurDao {
        public Professeur selectById(String id);
        public List<Professeur> selectAll();
        public void insert(Professeur p);
    }
}
