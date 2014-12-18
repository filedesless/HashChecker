/*Programmer: aiglebleu at openmailbox dot org              Date: 2014-12-17
 * 
 * --------------------------------------------
 * Declared Open-Sauce, you might do whatever
 * you want with these files. Crediting initial
 * author would be great thought.
 * --------------------------------------------
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

namespace HashChecker
{
    public partial class Form1 : Form
    {

      
  
        //Initially

        Main main = new Main(); //Refer to 'Main.cs'

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
                "1 - Click on one hash calculator",
                "2 - Choose the file you want to hash",
                "3 - Copy your verification hash in the white box"
                );
        }



        //When user click on a button

        private void btnMD5_Click(object sender, EventArgs e)
        {
            main.compute(txtInputMD5, txtOutputMD5);
        }

        private void btnSHA1_Click(object sender, EventArgs e)
        {
            main.compute(txtInputSHA1, txtOutputSHA1);
        }

        private void btnSHA256_Click(object sender, EventArgs e)
        {
            main.compute(txtInputSHA256, txtOutputSHA256);
        }

        private void btnSHA512_Click(object sender, EventArgs e)
        {
            main.compute(txtInputSHA512, txtOutputSHA512);
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
