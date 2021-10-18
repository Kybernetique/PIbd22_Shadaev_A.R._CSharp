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
            this.buttonSetBoat = new System.Windows.Forms.Button();
            this.buttonSetSailboat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonTakeVessel = new System.Windows.Forms.Button();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHarbor)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxHarbor
            // 
            this.pictureBoxHarbor.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxHarbor.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxHarbor.Name = "pictureBoxHarbor";
            this.pictureBoxHarbor.Size = new System.Drawing.Size(674, 450);
            this.pictureBoxHarbor.TabIndex = 0;
            this.pictureBoxHarbor.TabStop = false;
            // 
            // buttonSetBoat
            // 
            this.buttonSetBoat.AutoSize = true;
            this.buttonSetBoat.Location = new System.Drawing.Point(680, 12);
            this.buttonSetBoat.Name = "buttonSetBoat";
            this.buttonSetBoat.Size = new System.Drawing.Size(108, 24);
            this.buttonSetBoat.TabIndex = 1;
            this.buttonSetBoat.Text = "Set Boat";
            this.buttonSetBoat.UseCompatibleTextRendering = true;
            this.buttonSetBoat.UseVisualStyleBackColor = true;
            this.buttonSetBoat.Click += new System.EventHandler(this.buttonSetBoat_Click_1);
            // 
            // buttonSetSailboat
            // 
            this.buttonSetSailboat.AutoSize = true;
            this.buttonSetSailboat.Location = new System.Drawing.Point(680, 42);
            this.buttonSetSailboat.Name = "buttonSetSailboat";
            this.buttonSetSailboat.Size = new System.Drawing.Size(108, 23);
            this.buttonSetSailboat.TabIndex = 2;
            this.buttonSetSailboat.Text = "Set Sailboat";
            this.buttonSetSailboat.UseVisualStyleBackColor = true;
            this.buttonSetSailboat.Click += new System.EventHandler(this.buttonSetSailboat_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonTakeVessel);
            this.groupBox1.Controls.Add(this.maskedTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(680, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(108, 80);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Take Vessel";
            // 
            // buttonTakeVessel
            // 
            this.buttonTakeVessel.AutoSize = true;
            this.buttonTakeVessel.Location = new System.Drawing.Point(9, 43);
            this.buttonTakeVessel.Name = "buttonTakeVessel";
            this.buttonTakeVessel.Size = new System.Drawing.Size(93, 30);
            this.buttonTakeVessel.TabIndex = 2;
            this.buttonTakeVessel.Text = "Take";
            this.buttonTakeVessel.UseVisualStyleBackColor = true;
            this.buttonTakeVessel.Click += new System.EventHandler(this.buttonTakeVessel_Click_1);
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(46, 17);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(53, 20);
            this.maskedTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Place:";
            // 
            // FormHarbor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSetSailboat);
            this.Controls.Add(this.buttonSetBoat);
            this.Controls.Add(this.pictureBoxHarbor);
            this.Name = "FormHarbor";
            this.Text = "Harbor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHarbor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxHarbor;
        private System.Windows.Forms.Button buttonSetBoat;
        private System.Windows.Forms.Button buttonSetSailboat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonTakeVessel;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label label1;
    }
}