namespace GestionExam.ui
{
    partial class ExamForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeOuverture = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimeFermeture = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.matiereTxtBox = new System.Windows.Forms.TextBox();
            this.dureeNumeric = new System.Windows.Forms.NumericUpDown();
            this.Login = new System.Windows.Forms.GroupBox();
            this.creationExamBtn = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dureeNumeric)).BeginInit();
            this.Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1129, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(4, 724);
            this.panel4.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 4);
            this.panel1.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(4, 728);
            this.panel5.TabIndex = 12;
            // 
            // exitBtn
            // 
            this.exitBtn.AutoSize = true;
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.Font = new System.Drawing.Font("Lucida Console", 20F);
            this.exitBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.exitBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exitBtn.Location = new System.Drawing.Point(1088, 4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(35, 34);
            this.exitBtn.TabIndex = 13;
            this.exitBtn.Text = "X";
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 728);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1133, 4);
            this.panel2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 18F);
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(289, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(562, 55);
            this.label3.TabIndex = 14;
            this.label3.Text = "Commencer la création de votre examen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(82, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Date ouverture :";
            // 
            // dateTimeOuverture
            // 
            this.dateTimeOuverture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.dateTimeOuverture.Location = new System.Drawing.Point(400, 260);
            this.dateTimeOuverture.Name = "dateTimeOuverture";
            this.dateTimeOuverture.Size = new System.Drawing.Size(296, 28);
            this.dateTimeOuverture.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(82, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "Date fermeture :";
            // 
            // dateTimeFermeture
            // 
            this.dateTimeFermeture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.dateTimeFermeture.Location = new System.Drawing.Point(400, 347);
            this.dateTimeFermeture.Name = "dateTimeFermeture";
            this.dateTimeFermeture.Size = new System.Drawing.Size(296, 28);
            this.dateTimeFermeture.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(82, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 29);
            this.label5.TabIndex = 20;
            this.label5.Text = "Matière :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(82, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 29);
            this.label6.TabIndex = 22;
            this.label6.Text = "Durée :";
            // 
            // matiereTxtBox
            // 
            this.matiereTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.matiereTxtBox.Location = new System.Drawing.Point(400, 82);
            this.matiereTxtBox.Name = "matiereTxtBox";
            this.matiereTxtBox.Size = new System.Drawing.Size(296, 36);
            this.matiereTxtBox.TabIndex = 23;
            // 
            // dureeNumeric
            // 
            this.dureeNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.dureeNumeric.Location = new System.Drawing.Point(400, 179);
            this.dureeNumeric.Name = "dureeNumeric";
            this.dureeNumeric.Size = new System.Drawing.Size(296, 28);
            this.dureeNumeric.TabIndex = 24;
            // 
            // Login
            // 
            this.Login.Controls.Add(this.matiereTxtBox);
            this.Login.Controls.Add(this.dateTimeFermeture);
            this.Login.Controls.Add(this.dureeNumeric);
            this.Login.Controls.Add(this.label4);
            this.Login.Controls.Add(this.label6);
            this.Login.Controls.Add(this.dateTimeOuverture);
            this.Login.Controls.Add(this.label1);
            this.Login.Controls.Add(this.label5);
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(155, 151);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(802, 454);
            this.Login.TabIndex = 25;
            this.Login.TabStop = false;
            this.Login.Text = "Examen";
            // 
            // creationExamBtn
            // 
            this.creationExamBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.creationExamBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.creationExamBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.creationExamBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.creationExamBtn.Location = new System.Drawing.Point(711, 640);
            this.creationExamBtn.Name = "creationExamBtn";
            this.creationExamBtn.Size = new System.Drawing.Size(393, 43);
            this.creationExamBtn.TabIndex = 26;
            this.creationExamBtn.Text = "Valider les informations";
            this.creationExamBtn.UseVisualStyleBackColor = false;
            this.creationExamBtn.Click += new System.EventHandler(this.creationExamBtn_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.DarkCyan;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenu.Font = new System.Drawing.Font("Poor Richard", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMenu.Location = new System.Drawing.Point(12, 686);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(123, 36);
            this.btnMenu.TabIndex = 27;
            this.btnMenu.Text = "<<   Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Myanmar Text", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.emailLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.emailLabel.Location = new System.Drawing.Point(10, 7);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(109, 43);
            this.emailLabel.TabIndex = 28;
            this.emailLabel.Text = "email ...";
            // 
            // ExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1133, 732);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.creationExamBtn);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExamForm";
            this.Load += new System.EventHandler(this.ExamForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dureeNumeric)).EndInit();
            this.Login.ResumeLayout(false);
            this.Login.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label exitBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeOuverture;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimeFermeture;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox matiereTxtBox;
        private System.Windows.Forms.NumericUpDown dureeNumeric;
        private System.Windows.Forms.GroupBox Login;
        private System.Windows.Forms.Button creationExamBtn;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label emailLabel;
    }
}