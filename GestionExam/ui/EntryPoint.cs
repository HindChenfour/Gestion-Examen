using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GestionExam.business;
using GestionExam.dao;

namespace GestionExam.ui {
    class EntryPoint {
        public EntryPoint() {
            startApp();
        }

        public void startApp() {
            GestionExamenServices services = wiring();
            Application.Run(new LoginView(services));
        }

         public GestionExamenServices wiring() {
            MySqlDatabase db = new MySqlDatabase("gestionexamen");

            ProfesseurDao prDao = new ProfesseurDaoMySQL(db);
            ExamenDao exDao = new ExamenDaoMySQL(db);
            QuestionDao queDao = new QuestionDaoMySQL(db);
            ReponseDao repDao = new ReponseDaoMySQL(db);

            GestionExamenServices services = new GestionExamenServicesDefault(prDao, queDao, repDao, exDao);

            return services;
        }



        public static void Main(String[] args) {
            new EntryPoint();
        } 
    }
}
