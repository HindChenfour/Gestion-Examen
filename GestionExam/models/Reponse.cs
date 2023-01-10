using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionExam.models {
    public class Reponse {
        private int idQuest;

        public Reponse() {
           
        }

        public Reponse(int idQuest) {
            this.idQuest = idQuest;
        }

        public int GetIdQuest() {
            return idQuest;
        }

        public void SetIdQuest(int idQuest) {
            this.idQuest = idQuest;
        }
    }
}
