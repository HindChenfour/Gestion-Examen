using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GestionExam.models;

namespace GestionExam.ui {
    public partial class NewChoicesList : UserControl {
        public List<Choix> choices;
        public QuestionChoixMultiple quest;

        public NewChoicesList() {
            InitializeComponent();

            choices = new List<Choix>();
            choices.Add(new Choix());
            choices.Add(new Choix());
            choices.Add(new Choix());
        }

        public NewChoicesList(QuestionChoixMultiple q) {
            InitializeComponent();
            choices = new List<Choix>();
            choices.Add(new Choix());
            choices.Add(new Choix());
            choices.Add(new Choix());
            
            this.quest = q;
        }

        private void trueCheckBox1_CheckedChanged(object sender, EventArgs e) {
            Choix c = new Choix(int.Parse(quest.GetId() + "" + 1), choixTxtBox1.Text, true);

            choices.ElementAt(0).SetIdChoix(c.GetIdChoix());
            choices.ElementAt(0).SetChoix(c.GetChoix());
            choices.ElementAt(0).SetValeur(c.GetValeur());
        }

        private void falseCheckBox1_CheckedChanged(object sender, EventArgs e) {
            Choix c = new Choix(int.Parse(quest.GetId() + "" + 1), choixTxtBox1.Text, false);

            choices.ElementAt(0).SetIdChoix(c.GetIdChoix());
            choices.ElementAt(0).SetChoix(c.GetChoix());
            choices.ElementAt(0).SetValeur(c.GetValeur());
        }

        private void trueCheckBox2_CheckedChanged(object sender, EventArgs e) {
            Choix c = new Choix(int.Parse(quest.GetId() + "" + 2), choixTxtBox2.Text, true);

            choices.ElementAt(1).SetIdChoix(c.GetIdChoix());
            choices.ElementAt(1).SetChoix(c.GetChoix());
            choices.ElementAt(1).SetValeur(c.GetValeur());
        }

        private void falseCheckBox2_CheckedChanged(object sender, EventArgs e) {
            Choix c = new Choix(int.Parse(quest.GetId() + "" + 2), choixTxtBox2.Text, false);

            choices.ElementAt(1).SetIdChoix(c.GetIdChoix());
            choices.ElementAt(1).SetChoix(c.GetChoix());
            choices.ElementAt(1).SetValeur(c.GetValeur());
        }

        private void trueCheckBox3_CheckedChanged(object sender, EventArgs e) {
            Choix c = new Choix(int.Parse(quest.GetId() + "" + 3), choixTxtBox3.Text, true);

            choices.ElementAt(2).SetIdChoix(c.GetIdChoix());
            choices.ElementAt(2).SetChoix(c.GetChoix());
            choices.ElementAt(2).SetValeur(c.GetValeur());
        }

        private void falseCheckBox3_CheckedChanged(object sender, EventArgs e) {
            Choix c = new Choix(int.Parse(quest.GetId() + "" + 3), choixTxtBox3.Text, false);

            choices.ElementAt(2).SetIdChoix(c.GetIdChoix());
            choices.ElementAt(2).SetChoix(c.GetChoix());
            choices.ElementAt(2).SetValeur(c.GetValeur());
        }

        public void setChoices() {
            choices.ElementAt(0).SetChoix(choixTxtBox1.Text);
            choices.ElementAt(1).SetChoix(choixTxtBox2.Text);
            choices.ElementAt(2).SetChoix(choixTxtBox3.Text);
        }

        public void setChoicesIds() {
            choices.ElementAt(0).SetIdChoix(int.Parse(quest.GetId() + "" + 1));
            choices.ElementAt(1).SetIdChoix(int.Parse(quest.GetId() + "" + 2));
            choices.ElementAt(2).SetIdChoix(int.Parse(quest.GetId() + "" + 3));
        }

        public Choix getChoix(int index) {
            setChoicesIds();
            setChoices();
            return choices.ElementAt(index);
        }

        public List<Choix> getAllChoices() {
            setChoicesIds();
            setChoices();
            return choices;
        }
    }
}
