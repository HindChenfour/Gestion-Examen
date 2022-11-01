using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionExam.models {
    class Candidate {
        private String cne;
        private String nom;
        private String prenom;

        public Candidate() {

        }

        public Candidate(String cne, String nom, String prenom) {
            this.cne = cne;
            this.nom = nom;
            this.prenom = prenom;
        }
    }
}
