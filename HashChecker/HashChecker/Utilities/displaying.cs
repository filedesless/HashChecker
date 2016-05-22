using System.Windows.Forms;

namespace HashChecker.Utilities
{
    static class displaying
    {

        public static void compareTextBoxes(TextBox inputTxtBox, TextBox outputTxtBox)
        {
            inputTxtBox.BackColor = TextBoxColor(inputTxtBox.Text, outputTxtBox.Text);
        }

        public static void compareTextBoxes(RichTextBox inputTxtBox, RichTextBox outputTxtBox)
        {
            inputTxtBox.BackColor = TextBoxColor(inputTxtBox.Text.Trim(), outputTxtBox.Text.Trim());
        }

        public static System.Drawing.Color TextBoxColor(string txt1, string txt2)
        {
            //Nothing to check if one of them is blank
            if (txt1 == "" || txt2 == "")
                return System.Drawing.Color.White; //Make it white!
            else
                //If they're the same
                if (txt1.ToUpper() == txt2.ToUpper())
                return System.Drawing.Color.Green; //Grats! Make it green!
            else
                //If they're different
                return System.Drawing.Color.Red; //Uh ho.. Make it red!!
        }

    }
}
