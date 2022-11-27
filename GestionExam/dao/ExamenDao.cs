using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GestionExam.models;

namespace GestionExam.dao {
    interface ExamenDao {
        void insert(Examen e);
        Examen selectExamenById(int id);
        List<Examen> selectExamenByMatiere(String matiere);
        List<Examen> selectExamenByProfesseur(String email);
        List<Examen> selectAll();
    }
}
