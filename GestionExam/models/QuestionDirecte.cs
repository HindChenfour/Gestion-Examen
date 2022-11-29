using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionExam.models {
    class QuestionDirecte : Question {
        private String reponse;

        public QuestionDirecte() : base() {
            SetType("directe");
        }

        public QuestionDirecte(int idQuest) : base(idQuest) {
            SetType("directe");
        }

        public QuestionDirecte(int idQuest, String question) : base(idQuest, question, "directe") {

        }

        public QuestionDirecte(int idQuest, String question, String reponse) : base(idQuest, question, "directe") {
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
