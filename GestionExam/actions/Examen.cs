using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionExam.models;

namespace GestionExam.actions {
    class Examen {
        private DateTime dateOuverture;
        private DateTime dateFermeture;
        private int duree;
        private List<Question> questions;

        public Examen() {

        }

        public Examen(DateTime dateOuv, DateTime dateFerm, int duree, List<Question> questions) {
            this.dateFermeture = dateFerm;
            this.dateOuverture = dateOuv;
            this.duree = duree;
            this.questions = questions;
        }

        public DateTime GetDateOuverture() {
            return dateOuverture;
        }

        public void SetDateOuverture(DateTime date) {
            dateOuverture = date;
        }

        public DateTime GetDateFermeture() {
            return dateFermeture;
        }

        public void SetDateFermeture(DateTime date) {
            dateFermeture = date;
        }

        public int GetDuree() {
            return duree;
        }

        public void SetDuree(int duree) {
            this.duree = duree;
        }

        public List<Question> GetQuestionsList() {
            return questions;
        }

        public void SetQuestionsList(List<Question> questions) {
            this.questions = questions;
        }
    }
}
