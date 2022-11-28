using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionExam.models {
    class Candidat {
        private String emailAcademique;
        private String mdp;

        public Candidat() {

        }

        public Candidat(String emailAcademique, String mdp) {
            this.emailAcademique = emailAcademique;
            this.mdp = mdp;
        }

        public void SetEmailAcademique(String emailAcademique) {
            this.emailAcademique = emailAcademique;
        }

        public String GetEmailAcademique() {
            return emailAcademique;
        }

        public void SetMdp(String mdp)
        {
            this.mdp = mdp;
        }

        public String GetMdp() {
            return mdp;
        }

        public override string ToString(){
 	        return "email academique : " + emailAcademique;
        }
    }
}
