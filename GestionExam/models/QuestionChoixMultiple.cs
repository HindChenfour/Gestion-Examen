using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionExam.models {
    class QuestionChoixMultiple : Question {
        private List<Choix> choix;

        public QuestionChoixMultiple() : base() {

        }

        public QuestionChoixMultiple(int idQuest, String question, String type) : base(idQuest, question, type) {

        }

        public QuestionChoixMultiple(int idQuest, String question, String type, List<Choix> choix) : base(idQuest, question, type) {
            this.choix = choix;
        }


        public void SetChoix(List<Choix> choix) {
            this.choix = choix;
        }

        public List<Choix> GetReponse() {
            return choix;
        }

        public void AddChoix(Choix c) {
            choix.Add(c);
        }
    }
}
