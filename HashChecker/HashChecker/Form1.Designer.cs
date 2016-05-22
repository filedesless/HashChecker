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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hTLLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publishersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChoose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtInputMD5 = new System.Windows.Forms.TextBox();
            this.txtOutputMD5 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtInputSHA1 = new System.Windows.Forms.TextBox();
            this.txtOutputSHA1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtInputSHA256 = new System.Windows.Forms.TextBox();
            this.txtOutputSHA256 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtInputSHA512 = new System.Windows.Forms.TextBox();
            this.txtOutputSHA512 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblCurrentHash = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnHash = new System.Windows.Forms.Button();
            this.btnMD5 = new System.Windows.Forms.Button();
            this.btnSHA1 = new System.Windows.Forms.Button();
            this.btnSHA256 = new System.Windows.Forms.Button();
            this.btnSHA512 = new System.Windows.Forms.Button();
            this.publishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.publishToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(931, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripMenuItem,
            this.hTLLToolStripMenuItem,
            this.licenseToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.versionToolStripMenuItem.Text = "Version";
            this.versionToolStripMenuItem.Click += new System.EventHandler(this.versionToolStripMenuItem_Click);
            // 
            // hTLLToolStripMenuItem
            // 
            this.hTLLToolStripMenuItem.Name = "hTLLToolStripMenuItem";
            this.hTLLToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.hTLLToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.hTLLToolStripMenuItem.Text = "HTLL";
            this.hTLLToolStripMenuItem.Click += new System.EventHandler(this.hTLLToolStripMenuItem_Click);
            // 
            // licenseToolStripMenuItem
            // 
            this.licenseToolStripMenuItem.Name = "licenseToolStripMenuItem";
            this.licenseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.licenseToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.licenseToolStripMenuItem.Text = "License";
            this.licenseToolStripMenuItem.Click += new System.EventHandler(this.licenseToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.publishersToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // publishersToolStripMenuItem
            // 
            this.publishersToolStripMenuItem.Name = "publishersToolStripMenuItem";
            this.publishersToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.publishersToolStripMenuItem.Text = "Publishers";
            this.publishersToolStripMenuItem.Click += new System.EventHandler(this.publishersToolStripMenuItem_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "All files (*.*)|*.*";
            this.openFileDialog1.InitialDirectory = "%userprofile%";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 18;
            // 
            // txtLocation
            // 
            this.txtLocation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLocation.ForeColor = System.Drawing.Color.Black;
            this.txtLocation.Location = new System.Drawing.Point(152, 50);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.ReadOnly = true;
            this.txtLocation.Size = new System.Drawing.Size(479, 20);
            this.txtLocation.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Location";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnChoose
            // 
            this.btnChoose.BackColor = System.Drawing.Color.Gold;
            this.btnChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoose.Location = new System.Drawing.Point(10, 36);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(136, 64);
            this.btnChoose.TabIndex = 0;
            this.btnChoose.Text = "Choose a file";
            this.btnChoose.UseVisualStyleBackColor = false;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtInputMD5);
            this.groupBox1.Controls.Add(this.txtOutputMD5);
            this.groupBox1.Location = new System.Drawing.Point(10, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(830, 70);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MD5";
            // 
            // txtInputMD5
            // 
            this.txtInputMD5.Font = new System.Drawing.Font("Liberation Mono", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputMD5.Location = new System.Drawing.Point(7, 44);
            this.txtInputMD5.Name = "txtInputMD5";
            this.txtInputMD5.Size = new System.Drawing.Size(814, 19);
            this.txtInputMD5.TabIndex = 6;
            this.txtInputMD5.TextChanged += new System.EventHandler(this.txtInputMD5_TextChanged);
            // 
            // txtOutputMD5
            // 
            this.txtOutputMD5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtOutputMD5.Font = new System.Drawing.Font("Liberation Mono", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutputMD5.Location = new System.Drawing.Point(7, 19);
            this.txtOutputMD5.Name = "txtOutputMD5";
            this.txtOutputMD5.ReadOnly = true;
            this.txtOutputMD5.Size = new System.Drawing.Size(814, 19);
            this.txtOutputMD5.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtInputSHA1);
            this.groupBox2.Controls.Add(this.txtOutputSHA1);
            this.groupBox2.Location = new System.Drawing.Point(10, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(830, 70);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SHA1";
            // 
            // txtInputSHA1
            // 
            this.txtInputSHA1.Font = new System.Drawing.Font("Liberation Mono", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputSHA1.Location = new System.Drawing.Point(7, 38);
            this.txtInputSHA1.Name = "txtInputSHA1";
            this.txtInputSHA1.Size = new System.Drawing.Size(814, 19);
            this.txtInputSHA1.TabIndex = 8;
            this.txtInputSHA1.TextChanged += new System.EventHandler(this.txtInputSHA1_TextChanged);
            // 
            // txtOutputSHA1
            // 
            this.txtOutputSHA1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtOutputSHA1.Font = new System.Drawing.Font("Liberation Mono", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutputSHA1.Location = new System.Drawing.Point(7, 13);
            this.txtOutputSHA1.Name = "txtOutputSHA1";
            this.txtOutputSHA1.ReadOnly = true;
            this.txtOutputSHA1.Size = new System.Drawing.Size(814, 19);
            this.txtOutputSHA1.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtInputSHA256);
            this.groupBox3.Controls.Add(this.txtOutputSHA256);
            this.groupBox3.Location = new System.Drawing.Point(10, 258);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(830, 70);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SHA256";
            // 
            // txtInputSHA256
            // 
            this.txtInputSHA256.Font = new System.Drawing.Font("Liberation Mono", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputSHA256.Location = new System.Drawing.Point(7, 38);
            this.txtInputSHA256.Name = "txtInputSHA256";
            this.txtInputSHA256.Size = new System.Drawing.Size(814, 19);
            this.txtInputSHA256.TabIndex = 10;
            this.txtInputSHA256.TextChanged += new System.EventHandler(this.txtInputSHA256_TextChanged);
            // 
            // txtOutputSHA256
            // 
            this.txtOutputSHA256.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtOutputSHA256.Font = new System.Drawing.Font("Liberation Mono", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutputSHA256.Location = new System.Drawing.Point(7, 13);
            this.txtOutputSHA256.Name = "txtOutputSHA256";
            this.txtOutputSHA256.ReadOnly = true;
            this.txtOutputSHA256.Size = new System.Drawing.Size(814, 19);
            this.txtOutputSHA256.TabIndex = 9;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtInputSHA512);
            this.groupBox4.Controls.Add(this.txtOutputSHA512);
            this.groupBox4.Location = new System.Drawing.Point(10, 334);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(830, 70);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SHA512";
            // 
            // txtInputSHA512
            // 
            this.txtInputSHA512.Font = new System.Drawing.Font("Liberation Mono", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputSHA512.Location = new System.Drawing.Point(7, 38);
            this.txtInputSHA512.Name = "txtInputSHA512";
            this.txtInputSHA512.Size = new System.Drawing.Size(814, 19);
            this.txtInputSHA512.TabIndex = 12;
            this.txtInputSHA512.TextChanged += new System.EventHandler(this.txtInputSHA512_TextChanged);
            // 
            // txtOutputSHA512
            // 
            this.txtOutputSHA512.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtOutputSHA512.Font = new System.Drawing.Font("Liberation Mono", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutputSHA512.Location = new System.Drawing.Point(7, 12);
            this.txtOutputSHA512.Name = "txtOutputSHA512";
            this.txtOutputSHA512.ReadOnly = true;
            this.txtOutputSHA512.Size = new System.Drawing.Size(814, 19);
            this.txtOutputSHA512.TabIndex = 11;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.White;
            this.progressBar1.Location = new System.Drawing.Point(152, 76);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(479, 22);
            this.progressBar1.TabIndex = 22;
            // 
            // lblCurrentHash
            // 
            this.lblCurrentHash.AutoSize = true;
            this.lblCurrentHash.Location = new System.Drawing.Point(637, 85);
            this.lblCurrentHash.Name = "lblCurrentHash";
            this.lblCurrentHash.Size = new System.Drawing.Size(33, 13);
            this.lblCurrentHash.TabIndex = 25;
            this.lblCurrentHash.Text = "Idle...";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(693, 40);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 58);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Orange;
            this.btnClear.Location = new System.Drawing.Point(637, 50);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(48, 20);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnHash
            // 
            this.btnHash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnHash.Enabled = false;
            this.btnHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHash.Location = new System.Drawing.Point(785, 36);
            this.btnHash.Name = "btnHash";
            this.btnHash.Size = new System.Drawing.Size(131, 64);
            this.btnHash.TabIndex = 1;
            this.btnHash.Text = "Hash button";
            this.btnHash.UseVisualStyleBackColor = false;
            this.btnHash.Click += new System.EventHandler(this.btnCompleteHash_Click);
            // 
            // btnMD5
            // 
            this.btnMD5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMD5.Enabled = false;
            this.btnMD5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMD5.Location = new System.Drawing.Point(846, 125);
            this.btnMD5.Name = "btnMD5";
            this.btnMD5.Size = new System.Drawing.Size(70, 45);
            this.btnMD5.TabIndex = 29;
            this.btnMD5.Text = "MD5";
            this.btnMD5.UseVisualStyleBackColor = false;
            this.btnMD5.Click += new System.EventHandler(this.btnMD5_Click);
            // 
            // btnSHA1
            // 
            this.btnSHA1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSHA1.Enabled = false;
            this.btnSHA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSHA1.Location = new System.Drawing.Point(846, 195);
            this.btnSHA1.Name = "btnSHA1";
            this.btnSHA1.Size = new System.Drawing.Size(70, 45);
            this.btnSHA1.TabIndex = 30;
            this.btnSHA1.Text = "SHA1";
            this.btnSHA1.UseVisualStyleBackColor = false;
            this.btnSHA1.Click += new System.EventHandler(this.btnSHA1_Click);
            // 
            // btnSHA256
            // 
            this.btnSHA256.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSHA256.Enabled = false;
            this.btnSHA256.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSHA256.Location = new System.Drawing.Point(846, 271);
            this.btnSHA256.Name = "btnSHA256";
            this.btnSHA256.Size = new System.Drawing.Size(70, 45);
            this.btnSHA256.TabIndex = 31;
            this.btnSHA256.Text = "SHA256";
            this.btnSHA256.UseVisualStyleBackColor = false;
            this.btnSHA256.Click += new System.EventHandler(this.btnSHA256_Click);
            // 
            // btnSHA512
            // 
            this.btnSHA512.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSHA512.Enabled = false;
            this.btnSHA512.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSHA512.Location = new System.Drawing.Point(846, 346);
            this.btnSHA512.Name = "btnSHA512";
            this.btnSHA512.Size = new System.Drawing.Size(70, 45);
            this.btnSHA512.TabIndex = 32;
            this.btnSHA512.Text = "SHA512";
            this.btnSHA512.UseVisualStyleBackColor = false;
            this.btnSHA512.Click += new System.EventHandler(this.btnSHA512_Click);
            // 
            // publishToolStripMenuItem
            // 
            this.publishToolStripMenuItem.Name = "publishToolStripMenuItem";
            this.publishToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.publishToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.publishToolStripMenuItem.Text = "Publish/Verify";
            this.publishToolStripMenuItem.Click += new System.EventHandler(this.publishToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(931, 410);
            this.Controls.Add(this.btnSHA512);
            this.Controls.Add(this.btnSHA256);
            this.Controls.Add(this.btnSHA1);
            this.Controls.Add(this.btnMD5);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblCurrentHash);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnHash);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnChoose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "HashChecker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hTLLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publishersToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnHash;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblCurrentHash;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txtOutputSHA512;
        private System.Windows.Forms.TextBox txtInputSHA512;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtOutputSHA256;
        private System.Windows.Forms.TextBox txtInputSHA256;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtOutputSHA1;
        private System.Windows.Forms.TextBox txtInputSHA1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtOutputMD5;
        private System.Windows.Forms.TextBox txtInputMD5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMD5;
        private System.Windows.Forms.Button btnSHA1;
        private System.Windows.Forms.Button btnSHA256;
        private System.Windows.Forms.Button btnSHA512;
        private System.Windows.Forms.ToolStripMenuItem publishToolStripMenuItem;
    }
}

