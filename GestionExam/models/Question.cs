using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionExam.models {
    class Question {
        private int id;
        private String question;
        private String type;

        public Question() {

        }

        public Question(int id, String question, String type) {
            this.id = id;
            this.question = question;
            this.type = type;
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

        public void SetType(String type) {
            this.type = type;
        }

        public String GetType() {
            return type;
        }

        override public String ToString() {
            return "I'm question number : " + id;
        }

    }
}
