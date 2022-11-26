using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionExam.models {
    class ReponseDirecte : Reponse {
        private String reponse;

        public ReponseDirecte() : base() {

        }

        public ReponseDirecte(int idQuest, String reponse) : base(idQuest) {
            this.reponse = reponse;
        }

        public void SetReponse(String reponse)
        {
            this.reponse = reponse;
        }

        public String GetReponse() {
            return reponse;
        }
    }
}
