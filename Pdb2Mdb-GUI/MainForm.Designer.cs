namespace Pdb2Mdb_GUI
{
    partial class MainForm
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
            this.DndPanel = new System.Windows.Forms.Panel();
            this.ConversionProgress = new System.Windows.Forms.ProgressBar();
            this.DndLabel = new System.Windows.Forms.Label();
            this.ResultGroup = new System.Windows.Forms.GroupBox();
            this.SuccessLabel = new System.Windows.Forms.Label();
            this.SuccessResultLabel = new System.Windows.Forms.Label();
            this.DetailsButton = new System.Windows.Forms.Button();
            this.DndPanel.SuspendLayout();
            this.ResultGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // DndPanel
            // 
            this.DndPanel.Controls.Add(this.DndLabel);
            this.DndPanel.Location = new System.Drawing.Point(12, 12);
            this.DndPanel.Name = "DndPanel";
            this.DndPanel.Size = new System.Drawing.Size(424, 204);
            this.DndPanel.TabIndex = 0;
            // 
            // ConversionProgress
            // 
            this.ConversionProgress.Location = new System.Drawing.Point(12, 222);
            this.ConversionProgress.Name = "ConversionProgress";
            this.ConversionProgress.Size = new System.Drawing.Size(424, 38);
            this.ConversionProgress.TabIndex = 3;
            // 
            // DndLabel
            // 
            this.DndLabel.AllowDrop = true;
            this.DndLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DndLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DndLabel.Location = new System.Drawing.Point(0, 0);
            this.DndLabel.Name = "DndLabel";
            this.DndLabel.Size = new System.Drawing.Size(424, 204);
            this.DndLabel.TabIndex = 0;
            this.DndLabel.Text = "To convert, drag .dll or .exe files or even directories here !";
            this.DndLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DndLabel.DragDrop += new System.Windows.Forms.DragEventHandler(this.DndLabel_DragDrop);
            this.DndLabel.DragEnter += new System.Windows.Forms.DragEventHandler(this.DndLabel_DragEnter);
            this.DndLabel.DragLeave += new System.EventHandler(this.DndLabel_DragLeave);
            // 
            // ResultGroup
            // 
            this.ResultGroup.Controls.Add(this.DetailsButton);
            this.ResultGroup.Controls.Add(this.SuccessResultLabel);
            this.ResultGroup.Controls.Add(this.SuccessLabel);
            this.ResultGroup.Enabled = false;
            this.ResultGroup.Location = new System.Drawing.Point(12, 266);
            this.ResultGroup.Name = "ResultGroup";
            this.ResultGroup.Size = new System.Drawing.Size(424, 73);
            this.ResultGroup.TabIndex = 4;
            this.ResultGroup.TabStop = false;
            this.ResultGroup.Text = "Conversion Results";
            // 
            // SuccessLabel
            // 
            this.SuccessLabel.AutoSize = true;
            this.SuccessLabel.Location = new System.Drawing.Point(16, 32);
            this.SuccessLabel.Name = "SuccessLabel";
            this.SuccessLabel.Size = new System.Drawing.Size(74, 20);
            this.SuccessLabel.TabIndex = 0;
            this.SuccessLabel.Text = "Success:";
            // 
            // SuccessResultLabel
            // 
            this.SuccessResultLabel.AutoSize = true;
            this.SuccessResultLabel.Location = new System.Drawing.Point(113, 32);
            this.SuccessResultLabel.Name = "SuccessResultLabel";
            this.SuccessResultLabel.Size = new System.Drawing.Size(14, 20);
            this.SuccessResultLabel.TabIndex = 1;
            this.SuccessResultLabel.Text = "-";
            // 
            // DetailsButton
            // 
            this.DetailsButton.Location = new System.Drawing.Point(240, 27);
            this.DetailsButton.Name = "DetailsButton";
            this.DetailsButton.Size = new System.Drawing.Size(166, 30);
            this.DetailsButton.TabIndex = 2;
            this.DetailsButton.Text = "Details";
            this.DetailsButton.UseVisualStyleBackColor = true;
            this.DetailsButton.Click += new System.EventHandler(this.DetailsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 350);
            this.Controls.Add(this.ResultGroup);
            this.Controls.Add(this.ConversionProgress);
            this.Controls.Add(this.DndPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Pdb2Mdb-GUI";
            this.TopMost = true;
            this.DndPanel.ResumeLayout(false);
            this.ResultGroup.ResumeLayout(false);
            this.ResultGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DndPanel;
        private System.Windows.Forms.Label DndLabel;
        private System.Windows.Forms.ProgressBar ConversionProgress;
        private System.Windows.Forms.GroupBox ResultGroup;
        private System.Windows.Forms.Label SuccessLabel;
        private System.Windows.Forms.Label SuccessResultLabel;
        private System.Windows.Forms.Button DetailsButton;
    }
}

