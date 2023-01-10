using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GestionExam.models;

namespace GestionExam.dao {
    public interface ProfesseurDao {
        Professeur selectById(String id);
        List<Professeur> selectAll();
        void insert(Professeur p);
    }
}
