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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Label();
            this.addQuestionBtn = new System.Windows.Forms.Button();
            this.questionsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.getAllQuestionsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1356, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(4, 615);
            this.panel4.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(4, 615);
            this.panel3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 619);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1360, 4);
            this.panel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1360, 4);
            this.panel1.TabIndex = 4;
            // 
            // exitBtn
            // 
            this.exitBtn.AutoSize = true;
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.Font = new System.Drawing.Font("Lucida Console", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.exitBtn.Location = new System.Drawing.Point(1262, 9);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(35, 34);
            this.exitBtn.TabIndex = 8;
            this.exitBtn.Text = "X";
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // addQuestionBtn
            // 
            this.addQuestionBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addQuestionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuestionBtn.Location = new System.Drawing.Point(767, 52);
            this.addQuestionBtn.Name = "addQuestionBtn";
            this.addQuestionBtn.Size = new System.Drawing.Size(129, 43);
            this.addQuestionBtn.TabIndex = 10;
            this.addQuestionBtn.Text = "Ajouter";
            this.addQuestionBtn.UseVisualStyleBackColor = true;
            this.addQuestionBtn.Click += new System.EventHandler(this.addQuestion);
            // 
            // questionsPanel
            // 
            this.questionsPanel.AutoScroll = true;
            this.questionsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.questionsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.questionsPanel.Location = new System.Drawing.Point(52, 52);
            this.questionsPanel.Name = "questionsPanel";
            this.questionsPanel.Size = new System.Drawing.Size(671, 486);
            this.questionsPanel.TabIndex = 11;
            this.questionsPanel.WrapContents = false;
            // 
            // getAllQuestionsBtn
            // 
            this.getAllQuestionsBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.getAllQuestionsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getAllQuestionsBtn.Location = new System.Drawing.Point(755, 455);
            this.getAllQuestionsBtn.Name = "getAllQuestionsBtn";
            this.getAllQuestionsBtn.Size = new System.Drawing.Size(129, 43);
            this.getAllQuestionsBtn.TabIndex = 12;
            this.getAllQuestionsBtn.Text = "Créer";
            this.getAllQuestionsBtn.UseVisualStyleBackColor = true;
            this.getAllQuestionsBtn.Click += new System.EventHandler(this.getAllQuestionsBtn_Click);
            // 
            // ProfesseurView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1360, 623);
            this.Controls.Add(this.getAllQuestionsBtn);
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
        private System.Windows.Forms.Button getAllQuestionsBtn;
    }
}