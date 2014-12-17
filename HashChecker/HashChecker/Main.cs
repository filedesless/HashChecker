using System;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace HashChecker
{
    class Main
    {

        /// <summary>
        /// Compute the checksum of a chosen file
        /// </summary>
        /// <param name="output">Textbox where the calculated sum must be showed</param>
        public void computeSHA1(TextBox output)
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
                output.Text = message;
            }
        }

        /// <summary>
        /// Choose a file on the disk
        /// </summary>
        /// <returns>Return the file chosen by the user</returns>
        public Stream chooseFile()
        {
            //Initialize a data stream and my OpenFileDialog box
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            //OpenFileDialog box settings
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            //If a file is chosen, and is readable, return it's data stream
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
