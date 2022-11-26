using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionExam.models {
    class Professeur {
        private String emailAcademique;
        private String nom;
        private String prenom;

        public Professeur(){

        }

        public Professeur(String emailAcademique, String nom, String prenom) {
            this.emailAcademique = emailAcademique;
            this.nom = nom;
            this.prenom = prenom;
        }

        public void SetEmailAcademique(String emailAcademique) {
            this.emailAcademique = emailAcademique;
        }

        public String GetEmailAcademique() {
            return emailAcademique;
        }

        public void SetNom(String nom) {
            this.nom = nom;
        }

        public String GetNom() {
            return nom;
        }

        public void SetPrenom(String prenom) {
            this.prenom = prenom;
        }

        public String GetPrenom() {
            return prenom;
        }

        public override string ToString() {
            return "email academique : " + emailAcademique + " ,  nom : " + nom + " , prenom : " + prenom;
        }

    }
}
