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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();

            main.computeSHA1(txtOutputSHA1);

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            txtOutputSHA1.ReadOnly = true;
        }

        private void txtInputSHA1_TextChanged(object sender, EventArgs e)
        {
            if (txtInputSHA1.Text == txtOutputSHA1.Text)
                txtInputSHA1.BackColor = System.Drawing.Color.FromArgb(00, 255, 00);
            else
                if (txtInputSHA1.Text == "")
                    txtInputSHA1.BackColor = System.Drawing.Color.White;
                else
                    txtInputSHA1.BackColor = System.Drawing.Color.FromArgb(255, 00, 00);
        }

    }
}
