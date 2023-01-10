using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionExam.models {
    public class Choix {
        private int idChoix;
        private String choix;
        private bool valeur;

        public Choix() {

        }

        public Choix(int idChoix, String choix, bool valeur) {
            this.idChoix = idChoix;
            this.choix = choix;
            this.valeur = valeur;
        }

        public void SetIdChoix(int idChoix) {
            this.idChoix = idChoix;
        }

        public int GetIdChoix() {
            return idChoix;
        }

        public void SetChoix(String choix)
        {
            this.choix = choix;
        }

        public String GetChoix()
        {
            return choix;
        }

        public void SetValeur(bool valeur)
        {
            this.valeur = valeur;
        }

        public bool GetValeur()
        {
            return valeur;
        }


    }
}
