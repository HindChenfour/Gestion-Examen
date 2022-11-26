using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionExam.models;

namespace GestionExam.dao.mapping {
    class ExamenMapping {

        static public Professeur GetProfesseur(params Object[] row) {
            return new Professeur(row[0].ToString(), row[1].ToString(), row[2].ToString());
        }

        static public Object[] GetProfesseurRow(Professeur p) {
            return new Object[] {
                p.GetEmailAcademique(),
                p.GetNom(),
                p.GetPrenom()
            };
        }

        static public Candidat GetCandidat(params Object[] row) {
            return new Candidat(row[0].ToString(), row[1].ToString(), row[2].ToString());
        }

        static public Object[] GetCandidatRow(Candidat c) {
            return new Object[] {
                c.GetEmailAcademique(),
                c.GetNom(),
                c.GetPrenom()
            };
        }


    }
}
