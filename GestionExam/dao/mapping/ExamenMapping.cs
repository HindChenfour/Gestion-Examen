using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionExam.models;

namespace GestionExam.dao.mapping {
    class ExamenMapping {

/*--------------------------------------------------------------------------------------------------------*/

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


/*--------------------------------------------------------------------------------------------------------*/


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

 /*--------------------------------------------------------------------------------------------------------*/


        static public QuestionDirecte GetQuestionDirecte(params Object[] row) {
            return new QuestionDirecte((int)row[0], row[1].ToString(), row[2].ToString());
        }


        static public Object[] GetQuestionDirecteRow(QuestionDirecte q, int idExamen) {
            return new Object[] {
                q.GetId(),
                q.GetQuestion(),
                q.GetReponse(),
                idExamen
            };
        }

/*--------------------------------------------------------------------------------------------------------*/



        static public QuestionChoixMultiple GetQuestionCM(List<Choix> choix, params Object[] row) {
            return new QuestionChoixMultiple((int)row[0], row[1].ToString(), choix);
        }

        static public Object[] GetQuestionCMRow(QuestionChoixMultiple q, int idExamen)
        {
            return new Object[] {
                q.GetId(),
                q.GetQuestion(),
                idExamen
            };
        }


/*--------------------------------------------------------------------------------------------------------*/


        static public Choix GetChoix(params Object[] row) {
            return new Choix(int.Parse(row[0].ToString()), row[1].ToString(), Boolean.Parse(row[2].ToString()));
        }

        static public Object[] GetChoixRow(Choix c, int idQst) {
            return new Object[] {
                c.GetIdChoix(),
                c.GetChoix(),
                c.GetValeur(),
                idQst
            };
        }

/*--------------------------------------------------------------------------------------------------------*/


    }
}
