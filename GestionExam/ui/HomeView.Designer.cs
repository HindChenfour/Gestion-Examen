namespace GestionExam.ui
{
    partial class HomeView
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
            this.exitBtn = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.emailLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreateExam = new System.Windows.Forms.Button();
            this.btnListExam = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.AutoSize = true;
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.Font = new System.Drawing.Font("Lucida Console", 20F);
            this.exitBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.exitBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exitBtn.Location = new System.Drawing.Point(878, 9);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(35, 34);
            this.exitBtn.TabIndex = 9;
            this.exitBtn.Text = "X";
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(921, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(4, 613);
            this.panel4.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 4);
            this.panel1.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(4, 617);
            this.panel5.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 617);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(925, 4);
            this.panel2.TabIndex = 11;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Myanmar Text", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.emailLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.emailLabel.Location = new System.Drawing.Point(242, 157);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(112, 44);
            this.emailLabel.TabIndex = 25;
            this.emailLabel.Text = "email ...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 18F);
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(387, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 53);
            this.label2.TabIndex = 26;
            this.label2.Text = "Bienvenu";
            // 
            // btnCreateExam
            // 
            this.btnCreateExam.BackColor = System.Drawing.Color.PowderBlue;
            this.btnCreateExam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateExam.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCreateExam.Location = new System.Drawing.Point(159, 236);
            this.btnCreateExam.Name = "btnCreateExam";
            this.btnCreateExam.Size = new System.Drawing.Size(606, 46);
            this.btnCreateExam.TabIndex = 27;
            this.btnCreateExam.Text = "Créer un examen";
            this.btnCreateExam.UseVisualStyleBackColor = false;
            this.btnCreateExam.Click += new System.EventHandler(this.btnCreateExam_Click);
            // 
            // btnListExam
            // 
            this.btnListExam.BackColor = System.Drawing.Color.PowderBlue;
            this.btnListExam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListExam.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnListExam.Location = new System.Drawing.Point(159, 339);
            this.btnListExam.Name = "btnListExam";
            this.btnListExam.Size = new System.Drawing.Size(606, 46);
            this.btnListExam.TabIndex = 28;
            this.btnListExam.Text = "Consulter ma liste d\'examens";
            this.btnListExam.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(159, 456);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(606, 46);
            this.button2.TabIndex = 29;
            this.button2.Text = "Se deconneter";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(925, 621);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnListExam);
            this.Controls.Add(this.btnCreateExam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.exitBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeView";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.HomeView_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label exitBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreateExam;
        private System.Windows.Forms.Button btnListExam;
        private System.Windows.Forms.Button button2;
    }
}