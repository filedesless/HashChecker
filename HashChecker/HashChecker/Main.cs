/* The MIT License (MIT)

 * Copyright (c) <year> <copyright holders>

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
 */

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
        /// <param name="Algorithm">Algorithm to use (SHA1, MD5 ...)</param>
        public void compute(TextBox input, TextBox output)
        {
            //Take a stream of data from a file
            Stream file = chooseFile();

            //If the file was readable, no errors occured
            if (file != null)
            {
                //Initialize an instance of the hash function class calculator
                HashAlgorithm HashFunction;
                switch (output.Name)
                {
                    case "txtOutputSHA1" :
                        HashFunction = new SHA1CryptoServiceProvider();
                        break;
                    case "txtOutputMD5":
                        HashFunction = new MD5CryptoServiceProvider();
                        break;
                    case "txtOutputSHA256":
                        HashFunction = new SHA256CryptoServiceProvider();
                        break;
                    case "txtOutputSHA512":
                        HashFunction = new SHA512CryptoServiceProvider();
                        break;
                    default :
                        HashFunction = new SHA1CryptoServiceProvider();
                        break;
                }

                //Compute the hash of the file and store it in an array of bytes
                byte[] result = HashFunction.ComputeHash(file);

                //Make this array readable
                string message = BitConverter.ToString(result).Replace("-", string.Empty);

                //Show it
                output.Text = message;

                //Check the hash
                HashVerification(input, output);
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

        /// <summary>
        /// Verify that the txtOutput is the same as txtInput
        /// </summary>
        /// <param name="inputTxtBox">TextBox where user put the hash to verify</param>
        /// <param name="outputTxtBox">TextBox where the calculated sum is showed</param>
        /// <remarks>If one of them is blank, there's no need to check</remarks>
        public void HashVerification(TextBox inputTxtBox, TextBox outputTxtBox)
        {
            //Nothing to check if one of them is blank
            if (inputTxtBox.Text == "" || outputTxtBox.Text == "")
                inputTxtBox.BackColor = System.Drawing.Color.White; //Make it white!
            else
                //If they're the same
                if (inputTxtBox.Text == outputTxtBox.Text)
                    inputTxtBox.BackColor = System.Drawing.Color.FromArgb(00, 255, 00); //Grats! Make it green!
                else
                    //If they're different
                    inputTxtBox.BackColor = System.Drawing.Color.FromArgb(255, 00, 00); //Uh ho.. Make it red!!
        }

    }
}
