using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionExam.models {
    class QuestionDirecte : Question {
        private String reponse;

        public QuestionDirecte() : base() {

        }

        public QuestionDirecte(int idQuest, String question, String type) : base(idQuest, question, type) {

        }

        public QuestionDirecte(int idQuest, String question, String type, String reponse) : base(idQuest, question, type) {
            this.reponse = reponse;
        }


        public void SetReponse(String reponse) {
            this.reponse = reponse;
        }

        public String GetReponse() {
            return reponse;
        }

    }
}
