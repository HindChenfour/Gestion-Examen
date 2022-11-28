using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionExam.models {
    class Examen {
        private int id;
        private DateTime dateOuverture;
        private DateTime dateFermeture;
        private int duree;
        private List<Question> questions;
        private Professeur realisateur;
        private String matiere;

        public Examen() {
        
        }

        public Examen(int id, DateTime dateOuv, DateTime dateFer, int duree, List<Question> quests, Professeur realis, String matiere) {
            this.id = id;
            this.dateOuverture = dateOuv;
            this.dateFermeture = dateFer;
            this.duree = duree;
            this.questions = quests;
            this.realisateur = realis;
            this.matiere = matiere;
        }

        public Examen(int id, DateTime dateOuv, DateTime dateFer, int duree, Professeur realis, String matiere) {
            this.id = id;
            this.dateOuverture = dateOuv;
            this.dateFermeture = dateFer;
            this.duree = duree;
            this.realisateur = realis;
            this.matiere = matiere;
        }

        public Examen(int id, int duree, String matiere) {
            this.id = id;
            this.duree = duree;
            this.matiere = matiere;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public int GetId() {
            return id;
        }

        public void SetDateOuverture(DateTime date) {
            this.dateOuverture = date;
        }

        public DateTime GetDateOuverture() {
            return dateOuverture;
        }

        public void SetDateFermeture(DateTime date) {
            this.dateFermeture = date;
        }

        public DateTime GetDateFermeture() {
            return dateFermeture;
        }

        public void SetDuree(int duree) {
            this.duree = duree;
        }

        public int GetDuree() {
            return duree;
        }

        public void SetQuestions(List<Question> questions) {
            this.questions = questions;
        }

        public List<Question> Getquestions() {
            return questions;
        }

        public void SetRealisateur(Professeur realisateur) {
            this.realisateur = realisateur;
        }

        public Professeur GetRealisateur() {
            return realisateur;
        }

        public void SetMatiere(String matiere) {
            this.matiere = matiere;
        }

        public String GetMatiere() {
            return matiere;
        }

        public void AddQuestion(Question q) {
            questions.Add(q);
        }

        public Question GetQuestionByIndex(int index) {
            return questions.ElementAt(index);
        }
    }
}
