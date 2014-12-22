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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnChoose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHash = new System.Windows.Forms.Button();
            this.txtInputSHA512 = new System.Windows.Forms.TextBox();
            this.txtOutputSHA512 = new System.Windows.Forms.TextBox();
            this.txtInputSHA256 = new System.Windows.Forms.TextBox();
            this.txtInputMD5 = new System.Windows.Forms.TextBox();
            this.txtOutputSHA256 = new System.Windows.Forms.TextBox();
            this.txtOutputMD5 = new System.Windows.Forms.TextBox();
            this.txtInputSHA1 = new System.Windows.Forms.TextBox();
            this.txtOutputSHA1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Location = new System.Drawing.Point(12, 12);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1000, 348);
            this.tabControl2.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.btnChoose);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtLocation);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnHash);
            this.tabPage1.Controls.Add(this.txtInputSHA512);
            this.tabPage1.Controls.Add(this.txtOutputSHA512);
            this.tabPage1.Controls.Add(this.txtInputSHA256);
            this.tabPage1.Controls.Add(this.txtInputMD5);
            this.tabPage1.Controls.Add(this.txtOutputSHA256);
            this.tabPage1.Controls.Add(this.txtOutputMD5);
            this.tabPage1.Controls.Add(this.txtInputSHA1);
            this.tabPage1.Controls.Add(this.txtOutputSHA1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(992, 322);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hash a file 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnChoose
            // 
            this.btnChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoose.Location = new System.Drawing.Point(608, 0);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(186, 55);
            this.btnChoose.TabIndex = 0;
            this.btnChoose.Text = "Choose a file";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "SHA512 computed hash";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "SHA256 computed hash";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "SHA1 computed hash";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "MD5 computed hash";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Location";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(145, 65);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.ReadOnly = true;
            this.txtLocation.Size = new System.Drawing.Size(563, 20);
            this.txtLocation.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 18;
            // 
            // btnHash
            // 
            this.btnHash.Enabled = false;
            this.btnHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHash.Location = new System.Drawing.Point(800, 0);
            this.btnHash.Name = "btnHash";
            this.btnHash.Size = new System.Drawing.Size(186, 55);
            this.btnHash.TabIndex = 1;
            this.btnHash.Text = "Hash button";
            this.btnHash.UseVisualStyleBackColor = true;
            this.btnHash.Click += new System.EventHandler(this.btnCompleteHash_Click);
            // 
            // txtInputSHA512
            // 
            this.txtInputSHA512.Location = new System.Drawing.Point(145, 295);
            this.txtInputSHA512.Name = "txtInputSHA512";
            this.txtInputSHA512.Size = new System.Drawing.Size(841, 20);
            this.txtInputSHA512.TabIndex = 10;
            this.txtInputSHA512.TextChanged += new System.EventHandler(this.txtInputSHA512_TextChanged);
            // 
            // txtOutputSHA512
            // 
            this.txtOutputSHA512.Location = new System.Drawing.Point(142, 269);
            this.txtOutputSHA512.Name = "txtOutputSHA512";
            this.txtOutputSHA512.ReadOnly = true;
            this.txtOutputSHA512.Size = new System.Drawing.Size(844, 20);
            this.txtOutputSHA512.TabIndex = 9;
            // 
            // txtInputSHA256
            // 
            this.txtInputSHA256.Location = new System.Drawing.Point(142, 243);
            this.txtInputSHA256.Name = "txtInputSHA256";
            this.txtInputSHA256.Size = new System.Drawing.Size(844, 20);
            this.txtInputSHA256.TabIndex = 8;
            this.txtInputSHA256.TextChanged += new System.EventHandler(this.txtInputSHA256_TextChanged);
            // 
            // txtInputMD5
            // 
            this.txtInputMD5.Location = new System.Drawing.Point(142, 141);
            this.txtInputMD5.Name = "txtInputMD5";
            this.txtInputMD5.Size = new System.Drawing.Size(844, 20);
            this.txtInputMD5.TabIndex = 4;
            this.txtInputMD5.TextChanged += new System.EventHandler(this.txtInputMD5_TextChanged);
            // 
            // txtOutputSHA256
            // 
            this.txtOutputSHA256.Location = new System.Drawing.Point(142, 218);
            this.txtOutputSHA256.Name = "txtOutputSHA256";
            this.txtOutputSHA256.ReadOnly = true;
            this.txtOutputSHA256.Size = new System.Drawing.Size(844, 20);
            this.txtOutputSHA256.TabIndex = 7;
            // 
            // txtOutputMD5
            // 
            this.txtOutputMD5.Location = new System.Drawing.Point(142, 116);
            this.txtOutputMD5.Name = "txtOutputMD5";
            this.txtOutputMD5.ReadOnly = true;
            this.txtOutputMD5.Size = new System.Drawing.Size(844, 20);
            this.txtOutputMD5.TabIndex = 3;
            // 
            // txtInputSHA1
            // 
            this.txtInputSHA1.Location = new System.Drawing.Point(142, 192);
            this.txtInputSHA1.Name = "txtInputSHA1";
            this.txtInputSHA1.Size = new System.Drawing.Size(844, 20);
            this.txtInputSHA1.TabIndex = 6;
            this.txtInputSHA1.TextChanged += new System.EventHandler(this.txtInputSHA1_TextChanged);
            // 
            // txtOutputSHA1
            // 
            this.txtOutputSHA1.Location = new System.Drawing.Point(142, 167);
            this.txtOutputSHA1.Name = "txtOutputSHA1";
            this.txtOutputSHA1.ReadOnly = true;
            this.txtOutputSHA1.Size = new System.Drawing.Size(844, 20);
            this.txtOutputSHA1.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(779, 322);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hash a file 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(7, 78);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(738, 173);
            this.listBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 372);
            this.Controls.Add(this.tabControl2);
            this.Name = "Form1";
            this.Text = "HashChecker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtOutputSHA1;
        private System.Windows.Forms.TextBox txtInputSHA1;
        private System.Windows.Forms.TextBox txtInputSHA256;
        private System.Windows.Forms.TextBox txtOutputSHA256;
        private System.Windows.Forms.TextBox txtInputMD5;
        private System.Windows.Forms.TextBox txtOutputMD5;
        private System.Windows.Forms.TextBox txtInputSHA512;
        private System.Windows.Forms.TextBox txtOutputSHA512;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnHash;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button btnChoose;
    }
}

