namespace GestionExam.interfaces
{
    partial class ProfesseurForm
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
            this.input1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // input1
            // 
            this.input1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.input1.Location = new System.Drawing.Point(409, 52);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(339, 42);
            this.input1.TabIndex = 7;
            this.input1.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.richTextBox1.Location = new System.Drawing.Point(409, 209);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(339, 42);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.richTextBox2.Location = new System.Drawing.Point(409, 289);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(339, 42);
            this.richTextBox2.TabIndex = 9;
            this.richTextBox2.Text = "";
            // 
            // richTextBox5
            // 
            this.richTextBox5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.richTextBox5.Location = new System.Drawing.Point(409, 132);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(339, 42);
            this.richTextBox5.TabIndex = 10;
            this.richTextBox5.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(789, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(470, 279);
            this.dataGridView1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Prenom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 32);
            this.label3.TabIndex = 15;
            this.label3.Text = "CNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(123, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 32);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tel";
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(585, 372);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(163, 42);
            this.submit.TabIndex = 17;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            // 
            // ProfesseurForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1291, 426);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.richTextBox5);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.input1);
            this.Name = "ProfesseurForm";
            this.Text = "ProfesseurForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox input1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button submit;
    }
}