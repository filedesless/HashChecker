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

        public struct File
        {
            public string name;
            public FileStream data;
            public string md5;
            public string sha1;
            public string sha256;
            public string sha512;
        }

        MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
        SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
        SHA256CryptoServiceProvider sha256 = new SHA256CryptoServiceProvider();
        SHA512CryptoServiceProvider sha512 = new SHA512CryptoServiceProvider();


        public File file;

        /// <summary>
        /// Compute the checksum of a chosen file
        /// </summary>
        public void compute()
        {
            
            //If the file was readable, no errors occured
            if (file.data != null)
            {
                byte[] hash;
                if (file.md5 == null)
                {
                    hash = md5.ComputeHash(file.data);
                    file.md5 = BitConverter.ToString(hash).Replace("-", "");
                }

                if (file.sha1 == null)
                {
                    hash = sha1.ComputeHash(file.data);
                    file.sha1 = BitConverter.ToString(hash).Replace("-", "");
                }

                if (file.sha256 == null)
                {
                    hash = sha256.ComputeHash(file.data);
                    file.sha256 = BitConverter.ToString(hash).Replace("-", "");
                }

                if (file.sha512 == null)
                {
                    hash = sha512.ComputeHash(file.data);
                    file.sha512 = BitConverter.ToString(hash).Replace("-", "");
                }                

            }
        }

        public void showChecksums(TextBox md5, TextBox sha1, TextBox sha256, TextBox sha512)
        {
            md5.Text = file.md5;
            sha1.Text = file.sha1;
            sha256.Text = file.sha256;
            sha512.Text = file.sha512;
        }

        public void showLocation(TextBox location)
        {
            location.Text = file.name;
        }


        /// <summary>
        /// Choose a file on the disk
        /// </summary>
        /// <returns>Return the file chosen by the user</returns>
        public Stream chooseFile()
        {
            //Initialize a data stream and my OpenFileDialog box
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
                    if ((openFileDialog1.OpenFile()) != null)
                    {
                        file.name = openFileDialog1.FileName;
                        file.data = (FileStream)openFileDialog1.OpenFile();
                        file.md5 = null;
                        file.sha1 = null;
                        file.sha256 = null;
                        file.sha512 = null;
                        return file.data;
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
