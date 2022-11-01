using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionExam.models {
    class ReponseQCM : Reponse {
        private int idQst;
        private bool veracite;

        public ReponseQCM() : base() {

        }

        public ReponseQCM(int idQst, String reponse, bool veracite) : base(idQst, reponse) {
            this.idQst = idQst;
            this.veracite = veracite;
        }

        public int GetIdQst() {
            return idQst;
        }

        public void SetIdQst(int idQst) {
            this.idQst = idQst;
        }

        public bool GetVeracite() {
            return veracite;
        }

        public void SetVeracite(bool veracite) {
            this.veracite = veracite;
        }
    }
}
