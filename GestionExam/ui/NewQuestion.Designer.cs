namespace GestionExam.ui
{
    partial class NewQuestion
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            this.qcmBtn = new System.Windows.Forms.Button();
            this.qstDirecteBtn = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(3, 23);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(431, 29);
            this.label.TabIndex = 4;
            this.label.Text = "Choisir le type de question à ajouter :";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Location = new System.Drawing.Point(38, 222);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(594, 4);
            this.panel2.TabIndex = 15;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.qcmBtn);
            this.panel.Controls.Add(this.qstDirecteBtn);
            this.panel.Location = new System.Drawing.Point(22, 71);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(737, 145);
            this.panel.TabIndex = 16;
            // 
            // qcmBtn
            // 
            this.qcmBtn.BackColor = System.Drawing.Color.PowderBlue;
            this.qcmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.qcmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qcmBtn.Location = new System.Drawing.Point(92, 82);
            this.qcmBtn.Name = "qcmBtn";
            this.qcmBtn.Size = new System.Drawing.Size(452, 43);
            this.qcmBtn.TabIndex = 16;
            this.qcmBtn.Text = "Question Choix Multiple";
            this.qcmBtn.UseVisualStyleBackColor = false;
            this.qcmBtn.Click += new System.EventHandler(this.qcmBtn_Click_1);
            // 
            // qstDirecteBtn
            // 
            this.qstDirecteBtn.BackColor = System.Drawing.Color.PowderBlue;
            this.qstDirecteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.qstDirecteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qstDirecteBtn.Location = new System.Drawing.Point(92, 14);
            this.qstDirecteBtn.Name = "qstDirecteBtn";
            this.qstDirecteBtn.Size = new System.Drawing.Size(452, 43);
            this.qstDirecteBtn.TabIndex = 15;
            this.qstDirecteBtn.Text = "Question Directe";
            this.qstDirecteBtn.UseVisualStyleBackColor = false;
            this.qstDirecteBtn.Click += new System.EventHandler(this.qstDirecteBtn_Click);
            // 
            // NewQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label);
            this.Name = "NewQuestion";
            this.Size = new System.Drawing.Size(794, 226);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button qcmBtn;
        private System.Windows.Forms.Button qstDirecteBtn;
    }
}
