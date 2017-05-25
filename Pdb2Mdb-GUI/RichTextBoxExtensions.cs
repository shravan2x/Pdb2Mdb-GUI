using System.Drawing;
using System.Windows.Forms;

namespace Pdb2Mdb_GUI
{
    /* 
     * Credit: https://stackoverflow.com/users/8799/nathan-baulch from https://stackoverflow.com/questions/1926264/color-different-parts-of-a-richtextbox-string
     */

    public static class RichTextBoxExtensions
    {
        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }
}
