using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionExam.models {
    class Reponse {
        private int id;
        private String reponse;

        public Reponse() {

        }

        public Reponse(int id, String reponse) {
            this.id = id;
            this.reponse = reponse;
        }

        public int GetId() {
            return id;
        }

        public void SetId(int id) {
            this.id = id;
        }

        public String GetReponse() {
            return reponse;
        }

        public void SetReponse(String reponse) {
            this.reponse = reponse;
        }
    }
}
