using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace HashChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Take a stream of data from a file
            Stream file = chooseFile();

            //If the file was readable, no errors occured
            if (file != null)
            {
                //Initialize an instance of the SHA1 class calculator
                HashAlgorithm sha = new SHA1CryptoServiceProvider();

                //Compute the hash of the file and store it in an array of bytes
                byte[] result = sha.ComputeHash(file);

                //Make this array readable
                string message = BitConverter.ToString(result).Replace("-", string.Empty);

                //Show it
                MessageBox.Show(message);
            }

        }

        private Stream chooseFile()
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        return openFileDialog1.OpenFile();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("{0}\n{1}", "Error, impossible to open the file. Error Code: ", ex.Message));
                }
            }
            return null;
        }

    }
}
