using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Pdb2Mdb_GUI
{
    public partial class ConversionResultsForm : Form
    {
        private readonly Dictionary<string, Pdb2MdbConverter.ConversionResult> _conversionResults;

        public ConversionResultsForm(Dictionary<string, Pdb2MdbConverter.ConversionResult> conversionResults)
        {
            _conversionResults = conversionResults;
            InitializeComponent();
        }

        private void ConversionResultsForm_Load(object sender, System.EventArgs e)
        {
            foreach (Pdb2MdbConverter.ConversionResult curResult in _conversionResults.Values)
            {
                if (curResult.Success)
                {
                    ResultsBox.AppendText($"{Path.GetDirectoryName(curResult.Path)}\\", Color.LimeGreen);
                    ResultsBox.AppendText($"{Path.GetFileName(curResult.Path)}\n", Color.Green);
                }
                else
                {
                    ResultsBox.AppendText($"{Path.GetDirectoryName(curResult.Path)}\\", Color.Red);
                    ResultsBox.AppendText($"{Path.GetFileName(curResult.Path)}", Color.DarkRed);
                    ResultsBox.AppendText($"({curResult.Error.Message})\n", Color.IndianRed);
                }
            }
        }
    }
}
