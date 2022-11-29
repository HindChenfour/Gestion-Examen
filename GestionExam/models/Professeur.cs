using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionExam.models {
    public class Professeur {
        private String emailAcademique;
        private String mdp;

        public Professeur(){

        }

        public Professeur(String emailAcademique, String mdp)
        {
            this.emailAcademique = emailAcademique;
            this.mdp = mdp;
        }

        public Professeur(String emailAcademique) {
            this.emailAcademique = emailAcademique;
        }

        public void SetEmailAcademique(String emailAcademique) {
            this.emailAcademique = emailAcademique;
        }

        public String GetEmailAcademique() {
            return emailAcademique;
        }

        public void SetMdp(String mdp) {
            this.mdp = mdp;
        }

        public String GetMdp() {
            return mdp;
        }

        public override string ToString() {
            return "email academique : " + emailAcademique;
        }

    }
}
