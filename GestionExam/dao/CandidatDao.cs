using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GestionExam.models;
using GestionExam.dao.mapping;

namespace GestionExam.dao {
    interface CandidatDao {
        Candidat selectById(String id);
        List<Candidat> selectAll();
        void insert(Candidat c);
    }
}
