﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionExam.models;


namespace GestionExam.actions {
    class PasserExam {
        private Candidate candidat;
        private Examen examen;
        private DateTime date;
        private double note;

        public PasserExam() {

        }

        public PasserExam(Candidate candidat, Examen examen, DateTime date, double note) {
            this.candidat = candidat;
            this.examen = examen;
            this.date = date;
            this.note = note;
        }

        public void SetCandidat(Candidate candidat) {
            this.candidat = candidat;
        }

        public Candidate GetCandidate() {
            return candidat;
        }

        public void SetExamen(Examen examen) {
            this.examen = examen;
        }

        public Examen GetExamen() {
            return examen;
        }

        public void SetDate(DateTime date) {
            this.date = date;
        }

        public DateTime GetDate() {
            return date;
        }

        public void SetNote(double note) {
            this.note = note;
        }

        public double GetNote() {
            return note;
        }

    }
}
