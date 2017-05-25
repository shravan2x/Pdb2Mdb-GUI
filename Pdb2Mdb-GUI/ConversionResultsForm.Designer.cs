namespace Pdb2Mdb_GUI
{
    partial class ConversionResultsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ResultsBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ResultsBox
            // 
            this.ResultsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultsBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultsBox.Location = new System.Drawing.Point(12, 12);
            this.ResultsBox.Name = "ResultsBox";
            this.ResultsBox.ReadOnly = true;
            this.ResultsBox.Size = new System.Drawing.Size(846, 688);
            this.ResultsBox.TabIndex = 0;
            this.ResultsBox.Text = "";
            this.ResultsBox.WordWrap = false;
            // 
            // ConversionResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 712);
            this.Controls.Add(this.ResultsBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(892, 768);
            this.Name = "ConversionResultsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Conversion Results";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ConversionResultsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ResultsBox;
    }
}