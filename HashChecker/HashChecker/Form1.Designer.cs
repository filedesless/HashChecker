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
            this.components = new System.ComponentModel.Container();
            this.btnSHA1 = new System.Windows.Forms.Button();
            this.txtOutputSHA1 = new System.Windows.Forms.TextBox();
            this.txtInputSHA1 = new System.Windows.Forms.TextBox();
            this.txtInputSHA256 = new System.Windows.Forms.TextBox();
            this.txtOutputSHA256 = new System.Windows.Forms.TextBox();
            this.btnSHA256 = new System.Windows.Forms.Button();
            this.txtInputMD5 = new System.Windows.Forms.TextBox();
            this.txtOutputMD5 = new System.Windows.Forms.TextBox();
            this.btnMD5 = new System.Windows.Forms.Button();
            this.txtInputSHA512 = new System.Windows.Forms.TextBox();
            this.txtOutputSHA512 = new System.Windows.Forms.TextBox();
            this.btnSHA512 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSHA1
            // 
            this.btnSHA1.Location = new System.Drawing.Point(12, 127);
            this.btnSHA1.Name = "btnSHA1";
            this.btnSHA1.Size = new System.Drawing.Size(117, 45);
            this.btnSHA1.TabIndex = 0;
            this.btnSHA1.Text = "SHA1 Calculator";
            this.btnSHA1.UseVisualStyleBackColor = true;
            this.btnSHA1.Click += new System.EventHandler(this.btnSHA1_Click);
            // 
            // txtOutputSHA1
            // 
            this.txtOutputSHA1.Location = new System.Drawing.Point(135, 127);
            this.txtOutputSHA1.Name = "txtOutputSHA1";
            this.txtOutputSHA1.ReadOnly = true;
            this.txtOutputSHA1.Size = new System.Drawing.Size(523, 20);
            this.txtOutputSHA1.TabIndex = 1;
            // 
            // txtInputSHA1
            // 
            this.txtInputSHA1.Location = new System.Drawing.Point(135, 152);
            this.txtInputSHA1.Name = "txtInputSHA1";
            this.txtInputSHA1.Size = new System.Drawing.Size(523, 20);
            this.txtInputSHA1.TabIndex = 2;
            this.txtInputSHA1.TextChanged += new System.EventHandler(this.txtInputSHA1_TextChanged);
            // 
            // txtInputSHA256
            // 
            this.txtInputSHA256.Location = new System.Drawing.Point(135, 203);
            this.txtInputSHA256.Name = "txtInputSHA256";
            this.txtInputSHA256.Size = new System.Drawing.Size(523, 20);
            this.txtInputSHA256.TabIndex = 7;
            this.txtInputSHA256.TextChanged += new System.EventHandler(this.txtInputSHA256_TextChanged);
            // 
            // txtOutputSHA256
            // 
            this.txtOutputSHA256.Location = new System.Drawing.Point(135, 178);
            this.txtOutputSHA256.Name = "txtOutputSHA256";
            this.txtOutputSHA256.ReadOnly = true;
            this.txtOutputSHA256.Size = new System.Drawing.Size(523, 20);
            this.txtOutputSHA256.TabIndex = 6;
            // 
            // btnSHA256
            // 
            this.btnSHA256.Location = new System.Drawing.Point(12, 178);
            this.btnSHA256.Name = "btnSHA256";
            this.btnSHA256.Size = new System.Drawing.Size(117, 45);
            this.btnSHA256.TabIndex = 5;
            this.btnSHA256.Text = "SHA256 Calculator";
            this.btnSHA256.UseVisualStyleBackColor = true;
            this.btnSHA256.Click += new System.EventHandler(this.btnSHA256_Click);
            // 
            // txtInputMD5
            // 
            this.txtInputMD5.Location = new System.Drawing.Point(135, 101);
            this.txtInputMD5.Name = "txtInputMD5";
            this.txtInputMD5.Size = new System.Drawing.Size(523, 20);
            this.txtInputMD5.TabIndex = 12;
            this.txtInputMD5.TextChanged += new System.EventHandler(this.txtInputMD5_TextChanged);
            // 
            // txtOutputMD5
            // 
            this.txtOutputMD5.Location = new System.Drawing.Point(135, 76);
            this.txtOutputMD5.Name = "txtOutputMD5";
            this.txtOutputMD5.ReadOnly = true;
            this.txtOutputMD5.Size = new System.Drawing.Size(523, 20);
            this.txtOutputMD5.TabIndex = 11;
            // 
            // btnMD5
            // 
            this.btnMD5.Location = new System.Drawing.Point(12, 76);
            this.btnMD5.Name = "btnMD5";
            this.btnMD5.Size = new System.Drawing.Size(117, 45);
            this.btnMD5.TabIndex = 10;
            this.btnMD5.Text = "MD5 Calculator";
            this.btnMD5.UseVisualStyleBackColor = true;
            this.btnMD5.Click += new System.EventHandler(this.btnMD5_Click);
            // 
            // txtInputSHA512
            // 
            this.txtInputSHA512.Location = new System.Drawing.Point(135, 254);
            this.txtInputSHA512.Name = "txtInputSHA512";
            this.txtInputSHA512.Size = new System.Drawing.Size(523, 20);
            this.txtInputSHA512.TabIndex = 17;
            this.txtInputSHA512.TextChanged += new System.EventHandler(this.txtInputSHA512_TextChanged);
            // 
            // txtOutputSHA512
            // 
            this.txtOutputSHA512.Location = new System.Drawing.Point(135, 229);
            this.txtOutputSHA512.Name = "txtOutputSHA512";
            this.txtOutputSHA512.ReadOnly = true;
            this.txtOutputSHA512.Size = new System.Drawing.Size(523, 20);
            this.txtOutputSHA512.TabIndex = 16;
            // 
            // btnSHA512
            // 
            this.btnSHA512.Location = new System.Drawing.Point(12, 229);
            this.btnSHA512.Name = "btnSHA512";
            this.btnSHA512.Size = new System.Drawing.Size(117, 45);
            this.btnSHA512.TabIndex = 15;
            this.btnSHA512.Text = "SHA512 Calculator";
            this.btnSHA512.UseVisualStyleBackColor = true;
            this.btnSHA512.Click += new System.EventHandler(this.btnSHA512_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 285);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInputSHA512);
            this.Controls.Add(this.txtOutputSHA512);
            this.Controls.Add(this.btnSHA512);
            this.Controls.Add(this.txtInputMD5);
            this.Controls.Add(this.txtOutputMD5);
            this.Controls.Add(this.btnMD5);
            this.Controls.Add(this.txtInputSHA256);
            this.Controls.Add(this.txtOutputSHA256);
            this.Controls.Add(this.btnSHA256);
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
        private System.Windows.Forms.TextBox txtInputSHA256;
        private System.Windows.Forms.TextBox txtOutputSHA256;
        private System.Windows.Forms.Button btnSHA256;
        private System.Windows.Forms.TextBox txtInputMD5;
        private System.Windows.Forms.TextBox txtOutputMD5;
        private System.Windows.Forms.Button btnMD5;
        private System.Windows.Forms.TextBox txtInputSHA512;
        private System.Windows.Forms.TextBox txtOutputSHA512;
        private System.Windows.Forms.Button btnSHA512;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
    }
}

