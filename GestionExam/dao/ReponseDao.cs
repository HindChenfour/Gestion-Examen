using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GestionExam.models;

namespace GestionExam.dao {
    interface ReponseDao {
        Reponse selectReponseById(int id);
        Choix selectReponseQCM(int id);
        List<Reponse> selectAll();
        void insert(Reponse r, String type);
    }
}
