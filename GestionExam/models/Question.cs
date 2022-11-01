using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionExam.models {
    class Question {
        private int id;
        private String question;
        private double bareme;

        public Question() {

        }

        public Question(int id, String question, double bareme) {
            this.id = id;
            this.question = question;
            this.bareme = bareme;
        }

        public void SetId(int id) {
            this.id = id;
        }

        public int GetId() {
            return id;
        }

        public void SetQuestion(String question) {
            this.question = question;
        }

        public String GetQuestion() {
            return question;
        }

        public void SetBareme(double bareme) {
            this.bareme = bareme;
        }

        public double GetBareme() {
            return bareme;
        }

        public int Repondre(Reponse rp) {
            return rp.GetId();
        }
    }
}
