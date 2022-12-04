namespace GestionExam.ui
{
    partial class ProfesseurView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Label();
            this.addQuestionBtn = new System.Windows.Forms.Button();
            this.questionsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.creationExamBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeOuverture = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeFermeture = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.matiereTxtBox = new System.Windows.Forms.TextBox();
            this.dureeNumeric = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dureeNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1333, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(4, 854);
            this.panel4.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(4, 854);
            this.panel3.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(4, 854);
            this.panel5.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 858);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1337, 4);
            this.panel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1337, 4);
            this.panel1.TabIndex = 4;
            // 
            // exitBtn
            // 
            this.exitBtn.AutoSize = true;
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.Font = new System.Drawing.Font("Lucida Console", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.exitBtn.Location = new System.Drawing.Point(1290, 7);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(35, 34);
            this.exitBtn.TabIndex = 8;
            this.exitBtn.Text = "X";
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // addQuestionBtn
            // 
            this.addQuestionBtn.BackColor = System.Drawing.Color.PowderBlue;
            this.addQuestionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addQuestionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuestionBtn.Location = new System.Drawing.Point(942, 389);
            this.addQuestionBtn.Name = "addQuestionBtn";
            this.addQuestionBtn.Size = new System.Drawing.Size(335, 43);
            this.addQuestionBtn.TabIndex = 10;
            this.addQuestionBtn.Text = "Ajouter";
            this.addQuestionBtn.UseVisualStyleBackColor = false;
            this.addQuestionBtn.Click += new System.EventHandler(this.addQuestion);
            // 
            // questionsPanel
            // 
            this.questionsPanel.AutoScroll = true;
            this.questionsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.questionsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.questionsPanel.Location = new System.Drawing.Point(45, 389);
            this.questionsPanel.Name = "questionsPanel";
            this.questionsPanel.Size = new System.Drawing.Size(862, 418);
            this.questionsPanel.TabIndex = 11;
            this.questionsPanel.WrapContents = false;
            // 
            // creationExamBtn
            // 
            this.creationExamBtn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.creationExamBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.creationExamBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creationExamBtn.Location = new System.Drawing.Point(958, 807);
            this.creationExamBtn.Name = "creationExamBtn";
            this.creationExamBtn.Size = new System.Drawing.Size(367, 43);
            this.creationExamBtn.TabIndex = 12;
            this.creationExamBtn.Text = "Créer l\'Examen";
            this.creationExamBtn.UseVisualStyleBackColor = false;
            this.creationExamBtn.Click += new System.EventHandler(this.creationExamenBtn_click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(407, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(500, 55);
            this.label3.TabIndex = 13;
            this.label3.Text = "Commencer par créer votre examen";
            // 
            // dateTimeOuverture
            // 
            this.dateTimeOuverture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeOuverture.Location = new System.Drawing.Point(894, 213);
            this.dateTimeOuverture.Name = "dateTimeOuverture";
            this.dateTimeOuverture.Size = new System.Drawing.Size(296, 28);
            this.dateTimeOuverture.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(686, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Date ouverture :";
            // 
            // dateTimeFermeture
            // 
            this.dateTimeFermeture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFermeture.Location = new System.Drawing.Point(894, 269);
            this.dateTimeFermeture.Name = "dateTimeFermeture";
            this.dateTimeFermeture.Size = new System.Drawing.Size(296, 28);
            this.dateTimeFermeture.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(686, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "Date fermeture :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(124, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 29);
            this.label5.TabIndex = 18;
            this.label5.Text = "Matière :";
            // 
            // matiereTxtBox
            // 
            this.matiereTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matiereTxtBox.Location = new System.Drawing.Point(290, 209);
            this.matiereTxtBox.Name = "matiereTxtBox";
            this.matiereTxtBox.Size = new System.Drawing.Size(296, 36);
            this.matiereTxtBox.TabIndex = 19;
            // 
            // dureeNumeric
            // 
            this.dureeNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dureeNumeric.Location = new System.Drawing.Point(290, 269);
            this.dureeNumeric.Name = "dureeNumeric";
            this.dureeNumeric.Size = new System.Drawing.Size(296, 28);
            this.dureeNumeric.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(124, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 29);
            this.label6.TabIndex = 21;
            this.label6.Text = "Durée :";
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel6.Location = new System.Drawing.Point(645, 209);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 94);
            this.panel6.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(47, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 53);
            this.label2.TabIndex = 23;
            this.label2.Text = "Ajouter des questions :";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.emailLabel.Location = new System.Drawing.Point(10, 9);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(109, 43);
            this.emailLabel.TabIndex = 24;
            this.emailLabel.Text = "email ...";
            // 
            // ProfesseurView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1337, 862);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dureeNumeric);
            this.Controls.Add(this.matiereTxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimeFermeture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeOuverture);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.creationExamBtn);
            this.Controls.Add(this.questionsPanel);
            this.Controls.Add(this.addQuestionBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfesseurView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProfesseurView";
            this.Load += new System.EventHandler(this.ProfesseurView_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dureeNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exitBtn;
        private System.Windows.Forms.Button addQuestionBtn;
        private System.Windows.Forms.FlowLayoutPanel questionsPanel;
        private System.Windows.Forms.Button creationExamBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeOuverture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeFermeture;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox matiereTxtBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.NumericUpDown dureeNumeric;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label emailLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}