namespace GestionExam.ui
{
    partial class QuestionsFormView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionsFormView));
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
            this.emailLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateGray;
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel3.Controls.Add(this.panel5);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkSlateGray;
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // exitBtn
            // 
            resources.ApplyResources(this.exitBtn, "exitBtn");
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // addQuestionBtn
            // 
            this.addQuestionBtn.BackColor = System.Drawing.Color.PowderBlue;
            resources.ApplyResources(this.addQuestionBtn, "addQuestionBtn");
            this.addQuestionBtn.Name = "addQuestionBtn";
            this.addQuestionBtn.UseVisualStyleBackColor = false;
            this.addQuestionBtn.Click += new System.EventHandler(this.addQuestion);
            // 
            // questionsPanel
            // 
            resources.ApplyResources(this.questionsPanel, "questionsPanel");
            this.questionsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.questionsPanel.Name = "questionsPanel";
            // 
            // creationExamBtn
            // 
            this.creationExamBtn.BackColor = System.Drawing.Color.MediumTurquoise;
            resources.ApplyResources(this.creationExamBtn, "creationExamBtn");
            this.creationExamBtn.Name = "creationExamBtn";
            this.creationExamBtn.UseVisualStyleBackColor = false;
            this.creationExamBtn.Click += new System.EventHandler(this.creationExamenBtn_click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Name = "label3";
            // 
            // emailLabel
            // 
            resources.ApplyResources(this.emailLabel, "emailLabel");
            this.emailLabel.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.emailLabel.Name = "emailLabel";
            // 
            // QuestionsFormView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.emailLabel);
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
            this.Name = "QuestionsFormView";
            this.Load += new System.EventHandler(this.ProfesseurView_Load);
            this.panel3.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label emailLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}