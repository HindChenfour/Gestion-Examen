using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionExam.models {
    class Professeur {
        private String cni;
        private String nom;
        private String prenom;
        private String tel;

        public Professeur(){

        }

        public Professeur(String cni, String nom, String prenom, String tel) {
            this.cni = cni;
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
        }

        public void SetCni(String cni) {
            this.cni = cni;
        }

        public String GetCni() {
            return cni;
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

        public void SetTel(String tel) {
            this.tel = tel;
        }

        public String GetTel() {
            return tel;
        }

    }
}
