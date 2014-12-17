namespace HashChecker
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSHA1 = new System.Windows.Forms.Button();
            this.txtOutputSHA1 = new System.Windows.Forms.TextBox();
            this.txtInputSHA1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSHA1
            // 
            this.btnSHA1.Location = new System.Drawing.Point(12, 73);
            this.btnSHA1.Name = "btnSHA1";
            this.btnSHA1.Size = new System.Drawing.Size(117, 45);
            this.btnSHA1.TabIndex = 0;
            this.btnSHA1.Text = "SHA1 Calculator";
            this.btnSHA1.UseVisualStyleBackColor = true;
            this.btnSHA1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtOutputSHA1
            // 
            this.txtOutputSHA1.Location = new System.Drawing.Point(135, 73);
            this.txtOutputSHA1.Name = "txtOutputSHA1";
            this.txtOutputSHA1.ReadOnly = true;
            this.txtOutputSHA1.Size = new System.Drawing.Size(314, 20);
            this.txtOutputSHA1.TabIndex = 1;
            // 
            // txtInputSHA1
            // 
            this.txtInputSHA1.Location = new System.Drawing.Point(135, 98);
            this.txtInputSHA1.Name = "txtInputSHA1";
            this.txtInputSHA1.Size = new System.Drawing.Size(314, 20);
            this.txtInputSHA1.TabIndex = 2;
            this.txtInputSHA1.TextChanged += new System.EventHandler(this.txtInputSHA1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Output box for the computed sum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(455, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Input box for hash verification";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 306);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInputSHA1);
            this.Controls.Add(this.txtOutputSHA1);
            this.Controls.Add(this.btnSHA1);
            this.Name = "Form1";
            this.Text = "HashChecker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSHA1;
        private System.Windows.Forms.TextBox txtOutputSHA1;
        private System.Windows.Forms.TextBox txtInputSHA1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

