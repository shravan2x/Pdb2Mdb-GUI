using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pdb2Mdb;

namespace Pdb2Mdb_GUI
{
    public partial class MainForm : Form
    {
        private Dictionary<string, Pdb2MdbConverter.ConversionResult> _recentConversionResults;

        public MainForm()
        {
            InitializeComponent();
        }

        private void DndLabel_DragEnter(object sender, DragEventArgs e)
        {
            DndLabel.BackColor = Color.PaleGreen;
            e.Effect = DragDropEffects.Copy;
        }

        private void DndLabel_DragLeave(object sender, EventArgs e)
        {
            DndLabel.BackColor = Color.Transparent;
        }

        private async void DndLabel_DragDrop(object sender, DragEventArgs e)
        {
            DndLabel.BackColor = Color.Transparent;

            string[] droppedPaths = (string[]) e.Data.GetData(DataFormats.FileDrop);
            await ConvertAllAsync(droppedPaths);
        }

        private void DetailsButton_Click(object sender, EventArgs e)
        {
            ConversionResultsForm resultsForm = new ConversionResultsForm(_recentConversionResults);
            resultsForm.ShowDialog();
        }

        private async Task ConvertAllAsync(string[] paths)
        {
            List<string> netPaths = Pdb2MdbConverter.GetNetResourcePaths(paths);
            Dictionary<string, Pdb2MdbConverter.ConversionResult> conversionResults = new Dictionary<string, Pdb2MdbConverter.ConversionResult>();

            // Clear results
            DndPanel.Enabled = false;
            ConversionProgress.Value = 0;
            ResultGroup.Enabled = false;
            SuccessResultLabel.Text = "-";

            // Convert
            for (int index = 0; index < netPaths.Count; index++)
            {
                Pdb2MdbConverter.ConversionResult curResult = await Pdb2MdbConverter.ConvertNetResourceAsync(netPaths[index]);
                conversionResults.Add(netPaths[index], curResult);

                ConversionProgress.Value = (int) ((float) (index + 1) / netPaths.Count * 100);
            }

            // Display results
            DndPanel.Enabled = true;
            ResultGroup.Enabled = true;
            int numSuccessful = conversionResults.Values.Count(result => result.Success);
            SuccessResultLabel.Text = $"{numSuccessful}/{netPaths.Count}";

            _recentConversionResults = conversionResults;
        }
    }
}
