using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionExam.models {
    class ReponseDirecte : Reponse {
        private double valeur;

        public ReponseDirecte() : base() {

        }

        public ReponseDirecte(int idQst, String reponse, double valeur) : base(idQst, reponse) {
            this.valeur = valeur;
        }

        public double GetValeur() {
            return valeur;
        }

        public void SetValeur(double valeur) {
            this.valeur = valeur;
        }
    }
}
