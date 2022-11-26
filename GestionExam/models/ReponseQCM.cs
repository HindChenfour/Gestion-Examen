using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionExam.models {
    class ReponseQCM : Reponse {
        private int idChoix;

        public ReponseQCM() : base() {

        }

        public ReponseQCM(int idQst, int idChoix) : base(idQst) {
            this.idChoix = idChoix;
        }

        public int GetIdChoix() {
            return idChoix;
        }

        public void SetIdChoix(int idChoix) {
            this.idChoix = idChoix;
        }
    }
}
