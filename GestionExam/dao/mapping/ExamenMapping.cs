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
            return new Professeur(row[0].ToString(), row[1].ToString());
        }

        static public Object[] GetProfesseurRow(Professeur p) {
            return new Object[] {
                p.GetEmailAcademique(),
                p.GetMdp()
            };
        }


/*--------------------------------------------------------------------------------------------------------*/


        static public Candidat GetCandidat(params Object[] row) {
            return new Candidat(row[0].ToString(), row[1].ToString());
        }

        static public Object[] GetCandidatRow(Candidat c) {
            return new Object[] {
                c.GetEmailAcademique(),
                c.GetMdp()
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

        static public Object[] GetChoixRow(Choix c, int idQst, int idExam) {
            return new Object[] {
                c.GetIdChoix(),
                c.GetChoix(),
                c.GetValeur(),
                idQst,
                idExam
            };
        }

/*--------------------------------------------------------------------------------------------------------*/


        static public ReponseDirecte GetReponseDirecte(params Object[] row) {
            return new ReponseDirecte((int)row[2], (String)row[1]);
        }

        static public Object[] GetReponseDirecteRow(ReponseDirecte r) {
            return new Object[] {
                r.GetIdQuest(),
                r.GetReponse(),
                r.GetIdQuest()
            };
        }


/*--------------------------------------------------------------------------------------------------------*/


        static public ReponseQCM GetReponseQCM(params Object[] row) {
            return new ReponseQCM((int)row[1], (int)row[0]);
        }

        static public Object[] GetReponseQCMRow(ReponseQCM r) {
            return new Object[] {
                r.GetIdChoix(),
                r.GetIdQuest()
            };
        }


/*--------------------------------------------------------------------------------------------------------*/


        static public Examen GetExamen(params Object[] row) {
            return new Examen((int)row[0], DateTime.Parse((String)row[1]), DateTime.Parse((String)row[2]), (int)row[3], new Professeur((String)row[4]), (String)row[5]);
        }

        static public Object[] GetExamenRow(Examen e) {
            return new Object[] {
                e.GetId(),
                e.GetDateOuverture(),
                e.GetDateFermeture(),
                e.GetDuree(),
                e.GetRealisateur().GetEmailAcademique(),
                e.GetMatiere()
            };
        }


    }
}
