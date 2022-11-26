using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GestionExam.models;
using GestionExam.dao.mapping;

namespace GestionExam.dao {
    interface CandidatDao {
        public Candidat selectById(String id);
        public List<Candidat> selectAll();
        public void insert(Candidat c);
    }
}
