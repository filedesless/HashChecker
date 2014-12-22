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

//I feel like the compiler is ignoring all my commentaries.
using System;
using System.Windows.Forms;
using System.IO;

namespace HashChecker
{
    public partial class Form1 : Form
    {

        //Initially

        Main main = new Main(); //Refer to 'Main.cs'

        Stream file;
        

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

            //Label
            label1.Text = String.Format("{0}\n{1}\n{2}",
                "1 - Click on the button",
                "2 - Choose the file you want to hash",
                "3 - Copy your verification checksum in the appropriated white box"
                );
        }



        //When user click on a button

        private void btnCompleteHash_Click(object sender, EventArgs e)
        {
            main.compute();
            main.showChecksums(txtOutputMD5, txtOutputSHA1, txtOutputSHA256, txtOutputSHA512);
            main.HashVerification(txtInputMD5, txtOutputMD5);
            main.HashVerification(txtInputSHA1, txtOutputSHA1);
            main.HashVerification(txtInputSHA256, txtOutputSHA256);
            main.HashVerification(txtInputSHA512, txtOutputSHA512);
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            file = main.chooseFile();
            if (file != null)
            {
                btnHash.Enabled = true;
                main.showLocation(txtLocation);
            }
            else
            {
                btnHash.Enabled = false;
                txtLocation.Text = String.Empty;
                txtOutputMD5.Text = String.Empty;
                txtOutputSHA1.Text = String.Empty;
                txtOutputSHA256.Text = String.Empty;
                txtOutputSHA512.Text = String.Empty;
            }

        }




        //When Text Boxes change

        private void txtInputSHA1_TextChanged(object sender, EventArgs e)
        {
            main.HashVerification((TextBox)sender, txtOutputSHA1);
        }

        private void txtInputMD5_TextChanged(object sender, EventArgs e)
        {
            main.HashVerification((TextBox)sender, txtOutputMD5);
        }

        private void txtInputSHA256_TextChanged(object sender, EventArgs e)
        {
            main.HashVerification((TextBox)sender, txtOutputSHA256);
        }

        private void txtInputSHA512_TextChanged(object sender, EventArgs e)
        {
            main.HashVerification((TextBox)sender, txtOutputSHA512);
        }





    }
}
