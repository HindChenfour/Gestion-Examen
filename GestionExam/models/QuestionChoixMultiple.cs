using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionExam.models {
    class QuestionChoixMultiple : Question {
        private List<Choix> choix;

        public QuestionChoixMultiple() : base() {
            SetType("qcm");
        }

        public QuestionChoixMultiple(int idQuest) : base(idQuest) {
            SetType("qcm");
        }

        public QuestionChoixMultiple(int idQuest, String question) : base(idQuest, question, "qcm") {

        }

        public QuestionChoixMultiple(int idQuest, String question, List<Choix> choix) : base(idQuest, question, "qcm") {
            this.choix = choix;
        }


        public void SetChoix(List<Choix> choix) {
            this.choix = choix;
        }

        public List<Choix> GetChoix() {
            return choix;
        }

        public void AddChoix(Choix c) {
            choix.Add(c);
        }
    }
}
