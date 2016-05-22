/*Programmer: aiglebleu at openmailbox dot org              Date: 2014-12-17    Developed under MIT License
 * 
 * --------------------------------------------
 * Declared Open-Sauce, you might do whatever
 * you want with these files. Crediting initial
 * author would be great thought.
 * --------------------------------------------
 * Proper copyrights:
 * 
 * The MIT License (MIT)

 * Copyright (c) 2014-2015 aiglebleu

 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 * 
 * 
 * Originally developed for: https://hightechlowlife.eu

         ,ggg,        gg  ,ggggggggggggggg       ,gggg,         ,gggg,        
        dP""Y8b       88 dP""""""88"""""""      d8" "8I        d8" "8I        
        Yb, `88       88 Yb,_    88             88  ,dP        88  ,dP        
         `"  88       88  `""    88          8888888P"      8888888P"         
             88aaaaaaa88         88             88             88             
             88"""""""88         88             88             88             
             88       88         88        ,aa,_88        ,aa,_88             
             88       88   gg,   88       dP" "88P       dP" "88P             
             88       Y8,   "Yb,,8P       Yb,_,d88b,,_   Yb,_,d88b,,_         
             88       `Y8     "Y8P'        "Y8P"  "Y88888 "Y8P"  "Y88888       

 */

//I feel like the compiler is ignoring all my comments.
using System;
using System.Windows.Forms;
using System.ComponentModel;
using HashChecker.Utilities;

namespace HashChecker
{
    public partial class Form1 : Form
    {

        //Initially
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Tooltip for input boxes
            toolTip1.SetToolTip(this.txtInputMD5, "Enter the MD5 hash you want to verify here");
            toolTip1.SetToolTip(this.txtInputSHA1, "Enter the SHA1 hash you want to verify here");
            toolTip1.SetToolTip(this.txtInputSHA256, "Enter the SHA256 hash you want to verify here");
            toolTip1.SetToolTip(this.txtInputSHA512, "Enter the SHA512 hash you want to verify here");

            //Tooltip for output boxes
            toolTip1.SetToolTip(this.txtOutputMD5, "Click the 'MD5 Calculator' button to get the MD5 hash value here");
            toolTip1.SetToolTip(this.txtOutputSHA1, "Click the 'SHA1 Calculator' button to get the SHA1 hash value here");
            toolTip1.SetToolTip(this.txtOutputSHA256, "Click the 'SHA256 Calculator' button to get the SHA256 hash value here");
            toolTip1.SetToolTip(this.txtOutputSHA512, "Click the 'SHA512 Calculator' button to get the SHA512 hash value here");

            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;

        }

        #region buttons

        private void btnCompleteHash_Click(object sender, EventArgs e)
        {
            startHashing("all");
        }

        private void btnMD5_Click(object sender, EventArgs e)
        {
            startHashing("md5");
        }

        private void btnSHA1_Click(object sender, EventArgs e)
        {
            startHashing("sha1");
        }

        private void btnSHA256_Click(object sender, EventArgs e)
        {
            startHashing("sha256");
        }

        private void btnSHA512_Click(object sender, EventArgs e)
        {
            startHashing("sha512");
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            clearTextBoxes();

            // Save the filename and enable hash button
            toggleHashButtons(true);
            file_struct.clear();

            file_struct.name = txtLocation.Text = openFileDialog1.FileName;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
            btnCancel.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnCancel.PerformClick();
            clearTextBoxes();
        }

        #endregion

        #region textBoxes

        private void txtInputMD5_TextChanged(object sender, EventArgs e)
        {
            displaying.compareTextBoxes((TextBox)sender, txtOutputMD5);
        }

        private void txtInputSHA1_TextChanged(object sender, EventArgs e)
        {
            displaying.compareTextBoxes((TextBox)sender, txtOutputSHA1);
        }

        private void txtInputSHA256_TextChanged(object sender, EventArgs e)
        {
            displaying.compareTextBoxes((TextBox)sender, txtOutputSHA256);
        }

        private void txtInputSHA512_TextChanged(object sender, EventArgs e)
        {
            displaying.compareTextBoxes((TextBox)sender, txtOutputSHA512);
        }

        #endregion

        #region toolStripMenuItems

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnChoose.PerformClick();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void licenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(constants.license, "MIT License");
        }

        private void hTLLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://hightechlowlife.eu");
        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("HashChecker v{0}", constants.version), constants.version);
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("{0}\n{1}\n{2}",
                "1 - Click on the button",
                "2 - Choose the file you want to hash",
                "3 - Copy your verification checksum in the appropriated white box"
                ), "End user help");
        }

        private void publishersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("{0}\n{1}\n{2}",
                "1 - Click on the button",
                "2 - Choose the file you want to hash",
                "3 - Publish the output with your file to let users verify the hash"
                ), "Publisher help");
        }

        private void publishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string publisherString = String.Format(
                "{0,-6} : {1}\n" +
                "{2,-6} : {3}\n" +
                "{4,-6} : {5}\n" +
                "{6,-6} : {7}",
                    "MD5", file_struct.md5,
                    "SHA1", file_struct.sha1,
                    "SHA256", file_struct.sha256,
                    "SHA512", file_struct.sha512
                );
            Form frm = new frmPublisher(publisherString);

            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        #endregion

        #region backgroundWorker1

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // Computes hashes in background
            BackgroundWorker worker = sender as BackgroundWorker;
            Hashing compute = new Hashing(worker, txtLocation.Text);
            string jobList = e.Argument.ToString();

                if (!worker.CancellationPending)
                {
                    if (jobList == "all" || jobList == "md5")
                        file_struct.md5 = compute.md5();
                }
                else
                    e.Cancel = true;

                if (!worker.CancellationPending)
                {
                    if (jobList == "all" || jobList == "sha1")
                        file_struct.sha1 = compute.sha1();
                }
                else
                    e.Cancel = true;

                if (!worker.CancellationPending)
                {
                    if (jobList == "all" || jobList == "sha256")
                        file_struct.sha256 = compute.sha256();
                }
                else
                    e.Cancel = true;

                if (!worker.CancellationPending)
                {
                    if (jobList == "all" || jobList == "sha512")
                        file_struct.sha512 = compute.sha512();
                }
                else
                    e.Cancel = true;


        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage <= 100 && e.ProgressPercentage >= 0) // Normal reporting
            {
                progressBar1.Value = e.ProgressPercentage;
            }

            if (e.ProgressPercentage == 1000) // User requested cancellation
            {
                progressBar1.Value = 0;
            }

            if (e.UserState != null) // One computation finished
            {
                string hash = e.UserState.ToString();

                switch (hash.Length)
                {
                    case 32:
                        txtOutputMD5.Text = hash;
                        displaying.compareTextBoxes(txtInputMD5, txtOutputMD5);
                        lblCurrentHash.Text = "SHA1...";
                        break;
                    case 40:
                        txtOutputSHA1.Text = hash;
                        displaying.compareTextBoxes(txtInputSHA1, txtOutputSHA1);
                        lblCurrentHash.Text = "SHA256...";
                        break;
                    case 64:
                        txtOutputSHA256.Text = hash;
                        displaying.compareTextBoxes(txtInputSHA256, txtOutputSHA256);
                        lblCurrentHash.Text = "SHA512...";
                        break;
                    case 128:
                        txtOutputSHA512.Text = hash;
                        displaying.compareTextBoxes(txtInputSHA512, txtOutputSHA512);
                        lblCurrentHash.Text = "Idle...";
                        break;
                }

            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.ToString());
            }

            progressBar1.Value = 0;
            btnChoose.Enabled = true;
            toggleHashButtons(true);
            btnCancel.Enabled = false;
            lblCurrentHash.Text = "Idle...";
        }

        #endregion

        #region utilities

        private void startHashing(string algo)
        {
            string label;
            if (algo == "all")
                label = "md5";
            else
                label = algo;

            btnChoose.Enabled = false;
            btnCancel.Enabled = true;
            toggleHashButtons(false);
            lblCurrentHash.Text = String.Format("{0}...", label.ToUpper());

            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync(algo);
            }
        }

        private void toggleHashButtons(bool state)
        {
            foreach(Control btn in Controls)
            {
                if (btn.GetType() == typeof(Button))
                {
                    switch (btn.Name)
                    {
                        case "btnHash":
                        case "btnMD5":
                        case "btnSHA1":
                        case "btnSHA256":
                        case "btnSHA512":
                            btn.Enabled = state;
                            break;
                    }
                }
            }
        }

        private void clearTextBoxes()
        {
            // Empty the textBoxes
            txtOutputMD5.Text = String.Empty;
            txtOutputSHA1.Text = String.Empty;
            txtOutputSHA256.Text = String.Empty;
            txtOutputSHA512.Text = String.Empty;
        }


        #endregion

    }
}

