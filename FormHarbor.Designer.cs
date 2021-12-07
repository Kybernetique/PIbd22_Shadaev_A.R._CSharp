namespace WindowsFormsBoat
{
    partial class FormHarbor
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
            this.pictureBoxHarbor = new System.Windows.Forms.PictureBox();
            this.groupBoxTakeBoat = new System.Windows.Forms.GroupBox();
            this.buttonTakeBoat = new System.Windows.Forms.Button();
            this.maskedTextBoxPlace = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.buttonAddHarbor = new System.Windows.Forms.Button();
            this.buttonDelHarbor = new System.Windows.Forms.Button();
            this.textBoxNewLevelName = new System.Windows.Forms.TextBox();
            this.listBoxHarbors = new System.Windows.Forms.ListBox();
            this.Harbors = new System.Windows.Forms.Label();
            this.buttonAddBoat = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHarbor)).BeginInit();
            this.groupBoxTakeBoat.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxHarbor
            // 
            this.pictureBoxHarbor.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxHarbor.Location = new System.Drawing.Point(0, 24);
            this.pictureBoxHarbor.Name = "pictureBoxHarbor";
            this.pictureBoxHarbor.Size = new System.Drawing.Size(674, 437);
            this.pictureBoxHarbor.TabIndex = 0;
            this.pictureBoxHarbor.TabStop = false;
            // 
            // groupBoxTakeBoat
            // 
            this.groupBoxTakeBoat.Controls.Add(this.buttonTakeBoat);
            this.groupBoxTakeBoat.Controls.Add(this.maskedTextBoxPlace);
            this.groupBoxTakeBoat.Controls.Add(this.labelPlace);
            this.groupBoxTakeBoat.Location = new System.Drawing.Point(680, 358);
            this.groupBoxTakeBoat.Name = "groupBoxTakeBoat";
            this.groupBoxTakeBoat.Size = new System.Drawing.Size(108, 80);
            this.groupBoxTakeBoat.TabIndex = 3;
            this.groupBoxTakeBoat.TabStop = false;
            this.groupBoxTakeBoat.Text = "Take Boat";
            // 
            // buttonTakeBoat
            // 
            this.buttonTakeBoat.AutoSize = true;
            this.buttonTakeBoat.Location = new System.Drawing.Point(9, 43);
            this.buttonTakeBoat.Name = "buttonTakeBoat";
            this.buttonTakeBoat.Size = new System.Drawing.Size(93, 30);
            this.buttonTakeBoat.TabIndex = 2;
            this.buttonTakeBoat.Text = "Take";
            this.buttonTakeBoat.UseVisualStyleBackColor = true;
            this.buttonTakeBoat.Click += new System.EventHandler(this.buttonTakeBoat_Click_1);
            // 
            // maskedTextBoxPlace
            // 
            this.maskedTextBoxPlace.Location = new System.Drawing.Point(46, 17);
            this.maskedTextBoxPlace.Name = "maskedTextBoxPlace";
            this.maskedTextBoxPlace.Size = new System.Drawing.Size(53, 20);
            this.maskedTextBoxPlace.TabIndex = 1;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(6, 20);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(37, 13);
            this.labelPlace.TabIndex = 0;
            this.labelPlace.Text = "Place:";
            // 
            // buttonAddHarbor
            // 
            this.buttonAddHarbor.Location = new System.Drawing.Point(680, 51);
            this.buttonAddHarbor.Name = "buttonAddHarbor";
            this.buttonAddHarbor.Size = new System.Drawing.Size(108, 24);
            this.buttonAddHarbor.TabIndex = 4;
            this.buttonAddHarbor.Text = "Add Harbor";
            this.buttonAddHarbor.UseVisualStyleBackColor = true;
            this.buttonAddHarbor.Click += new System.EventHandler(this.buttonAddHarbor_Click);
            // 
            // buttonDelHarbor
            // 
            this.buttonDelHarbor.Location = new System.Drawing.Point(680, 181);
            this.buttonDelHarbor.Name = "buttonDelHarbor";
            this.buttonDelHarbor.Size = new System.Drawing.Size(108, 24);
            this.buttonDelHarbor.TabIndex = 5;
            this.buttonDelHarbor.Text = "Del Harbor";
            this.buttonDelHarbor.UseVisualStyleBackColor = true;
            this.buttonDelHarbor.Click += new System.EventHandler(this.buttonDelHarbor_Click);
            // 
            // textBoxNewLevelName
            // 
            this.textBoxNewLevelName.Location = new System.Drawing.Point(680, 25);
            this.textBoxNewLevelName.Name = "textBoxNewLevelName";
            this.textBoxNewLevelName.Size = new System.Drawing.Size(108, 20);
            this.textBoxNewLevelName.TabIndex = 6;
            // 
            // listBoxHarbors
            // 
            this.listBoxHarbors.FormattingEnabled = true;
            this.listBoxHarbors.Location = new System.Drawing.Point(680, 80);
            this.listBoxHarbors.Name = "listBoxHarbors";
            this.listBoxHarbors.Size = new System.Drawing.Size(108, 95);
            this.listBoxHarbors.TabIndex = 7;
            this.listBoxHarbors.SelectedIndexChanged += new System.EventHandler(this.listBoxHarbors_SelectedIndexChanged);
            // 
            // Harbors
            // 
            this.Harbors.AutoSize = true;
            this.Harbors.Location = new System.Drawing.Point(677, 9);
            this.Harbors.Name = "Harbors";
            this.Harbors.Size = new System.Drawing.Size(47, 13);
            this.Harbors.TabIndex = 8;
            this.Harbors.Text = "Harbors:";
            // 
            // buttonAddBoat
            // 
            this.buttonAddBoat.Location = new System.Drawing.Point(680, 329);
            this.buttonAddBoat.Name = "buttonAddBoat";
            this.buttonAddBoat.Size = new System.Drawing.Size(108, 23);
            this.buttonAddBoat.TabIndex = 9;
            this.buttonAddBoat.Text = "Add Boat";
            this.buttonAddBoat.UseVisualStyleBackColor = true;
            this.buttonAddBoat.Click += new System.EventHandler(this.buttonAddBoat_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(804, 24);
            this.menuStrip.TabIndex = 10;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt file | *.txt";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(680, 245);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(108, 27);
            this.buttonSort.TabIndex = 11;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click_1);
            // 
            // FormHarbor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonAddBoat);
            this.Controls.Add(this.Harbors);
            this.Controls.Add(this.listBoxHarbors);
            this.Controls.Add(this.textBoxNewLevelName);
            this.Controls.Add(this.buttonDelHarbor);
            this.Controls.Add(this.buttonAddHarbor);
            this.Controls.Add(this.groupBoxTakeBoat);
            this.Controls.Add(this.pictureBoxHarbor);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormHarbor";
            this.Text = "Harbor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHarbor)).EndInit();
            this.groupBoxTakeBoat.ResumeLayout(false);
            this.groupBoxTakeBoat.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxHarbor;
        private System.Windows.Forms.GroupBox groupBoxTakeBoat;
        private System.Windows.Forms.Button buttonTakeBoat;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlace;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Button buttonAddHarbor;
        private System.Windows.Forms.Button buttonDelHarbor;
        private System.Windows.Forms.TextBox textBoxNewLevelName;
        private System.Windows.Forms.ListBox listBoxHarbors;
        private System.Windows.Forms.Label Harbors;
        private System.Windows.Forms.Button buttonAddBoat;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonSort;
    }
}