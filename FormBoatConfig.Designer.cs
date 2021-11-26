namespace WindowsFormsBoat
{
    partial class FormBoatConfig
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
            this.groupBoxParameters = new System.Windows.Forms.GroupBox();
            this.checkBoxSail = new System.Windows.Forms.CheckBox();
            this.checkBoxAnchor = new System.Windows.Forms.CheckBox();
            this.checkBoxBack = new System.Windows.Forms.CheckBox();
            this.checkBoxFront = new System.Windows.Forms.CheckBox();
            this.labelMaxWeight = new System.Windows.Forms.Label();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.labelMaxSpeed = new System.Windows.Forms.Label();
            this.pictureBoxBoat = new System.Windows.Forms.PictureBox();
            this.groupBoxBoatType = new System.Windows.Forms.GroupBox();
            this.labelSailBoat = new System.Windows.Forms.Label();
            this.labelBoat = new System.Windows.Forms.Label();
            this.panelBoat = new System.Windows.Forms.Panel();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.panelWhiteColor = new System.Windows.Forms.Panel();
            this.labelSecondaryColor = new System.Windows.Forms.Label();
            this.panelPurpleColor = new System.Windows.Forms.Panel();
            this.panelYellowColor = new System.Windows.Forms.Panel();
            this.panelGreenColor = new System.Windows.Forms.Panel();
            this.panelPinkColor = new System.Windows.Forms.Panel();
            this.panelCyanColor = new System.Windows.Forms.Panel();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.panelOrangeColor = new System.Windows.Forms.Panel();
            this.panelRedColor = new System.Windows.Forms.Panel();
            this.buttonAppend = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoat)).BeginInit();
            this.groupBoxBoatType.SuspendLayout();
            this.panelBoat.SuspendLayout();
            this.groupBoxColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxParameters
            // 
            this.groupBoxParameters.Controls.Add(this.checkBoxSail);
            this.groupBoxParameters.Controls.Add(this.checkBoxAnchor);
            this.groupBoxParameters.Controls.Add(this.checkBoxBack);
            this.groupBoxParameters.Controls.Add(this.checkBoxFront);
            this.groupBoxParameters.Controls.Add(this.labelMaxWeight);
            this.groupBoxParameters.Controls.Add(this.numericUpDownWeight);
            this.groupBoxParameters.Controls.Add(this.numericUpDownMaxSpeed);
            this.groupBoxParameters.Controls.Add(this.labelMaxSpeed);
            this.groupBoxParameters.Location = new System.Drawing.Point(12, 156);
            this.groupBoxParameters.Name = "groupBoxParameters";
            this.groupBoxParameters.Size = new System.Drawing.Size(265, 100);
            this.groupBoxParameters.TabIndex = 0;
            this.groupBoxParameters.TabStop = false;
            this.groupBoxParameters.Text = "Parameters";
            // 
            // checkBoxSail
            // 
            this.checkBoxSail.AutoSize = true;
            this.checkBoxSail.Checked = true;
            this.checkBoxSail.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSail.Location = new System.Drawing.Point(179, 77);
            this.checkBoxSail.Name = "checkBoxSail";
            this.checkBoxSail.Size = new System.Drawing.Size(43, 17);
            this.checkBoxSail.TabIndex = 7;
            this.checkBoxSail.Text = "Sail";
            this.checkBoxSail.UseVisualStyleBackColor = true;
            // 
            // checkBoxAnchor
            // 
            this.checkBoxAnchor.AutoSize = true;
            this.checkBoxAnchor.Checked = true;
            this.checkBoxAnchor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAnchor.Location = new System.Drawing.Point(179, 54);
            this.checkBoxAnchor.Name = "checkBoxAnchor";
            this.checkBoxAnchor.Size = new System.Drawing.Size(60, 17);
            this.checkBoxAnchor.TabIndex = 6;
            this.checkBoxAnchor.Text = "Anchor";
            this.checkBoxAnchor.UseVisualStyleBackColor = true;
            // 
            // checkBoxBack
            // 
            this.checkBoxBack.AutoSize = true;
            this.checkBoxBack.Checked = true;
            this.checkBoxBack.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBack.Location = new System.Drawing.Point(179, 31);
            this.checkBoxBack.Name = "checkBoxBack";
            this.checkBoxBack.Size = new System.Drawing.Size(51, 17);
            this.checkBoxBack.TabIndex = 5;
            this.checkBoxBack.Text = "Back";
            this.checkBoxBack.UseVisualStyleBackColor = true;
            // 
            // checkBoxFront
            // 
            this.checkBoxFront.AutoSize = true;
            this.checkBoxFront.Checked = true;
            this.checkBoxFront.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFront.Location = new System.Drawing.Point(179, 8);
            this.checkBoxFront.Name = "checkBoxFront";
            this.checkBoxFront.Size = new System.Drawing.Size(50, 17);
            this.checkBoxFront.TabIndex = 4;
            this.checkBoxFront.Text = "Front";
            this.checkBoxFront.UseVisualStyleBackColor = true;
            // 
            // labelMaxWeight
            // 
            this.labelMaxWeight.AutoSize = true;
            this.labelMaxWeight.Location = new System.Drawing.Point(6, 64);
            this.labelMaxWeight.Name = "labelMaxWeight";
            this.labelMaxWeight.Size = new System.Drawing.Size(67, 13);
            this.labelMaxWeight.TabIndex = 1;
            this.labelMaxWeight.Text = "Max Weight:";
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(6, 80);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownWeight.TabIndex = 3;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownMaxSpeed
            // 
            this.numericUpDownMaxSpeed.Location = new System.Drawing.Point(9, 32);
            this.numericUpDownMaxSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Name = "numericUpDownMaxSpeed";
            this.numericUpDownMaxSpeed.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMaxSpeed.TabIndex = 2;
            this.numericUpDownMaxSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelMaxSpeed
            // 
            this.labelMaxSpeed.AutoSize = true;
            this.labelMaxSpeed.Location = new System.Drawing.Point(6, 16);
            this.labelMaxSpeed.Name = "labelMaxSpeed";
            this.labelMaxSpeed.Size = new System.Drawing.Size(64, 13);
            this.labelMaxSpeed.TabIndex = 0;
            this.labelMaxSpeed.Text = "Max Speed:";
            // 
            // pictureBoxBoat
            // 
            this.pictureBoxBoat.Location = new System.Drawing.Point(3, 22);
            this.pictureBoxBoat.Name = "pictureBoxBoat";
            this.pictureBoxBoat.Size = new System.Drawing.Size(191, 90);
            this.pictureBoxBoat.TabIndex = 1;
            this.pictureBoxBoat.TabStop = false;
            // 
            // groupBoxBoatType
            // 
            this.groupBoxBoatType.Controls.Add(this.labelSailBoat);
            this.groupBoxBoatType.Controls.Add(this.labelBoat);
            this.groupBoxBoatType.Location = new System.Drawing.Point(12, 12);
            this.groupBoxBoatType.Name = "groupBoxBoatType";
            this.groupBoxBoatType.Size = new System.Drawing.Size(129, 107);
            this.groupBoxBoatType.TabIndex = 2;
            this.groupBoxBoatType.TabStop = false;
            this.groupBoxBoatType.Text = "Boat Type";
            // 
            // labelSailBoat
            // 
            this.labelSailBoat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSailBoat.Location = new System.Drawing.Point(15, 62);
            this.labelSailBoat.Name = "labelSailBoat";
            this.labelSailBoat.Size = new System.Drawing.Size(100, 23);
            this.labelSailBoat.TabIndex = 1;
            this.labelSailBoat.Text = "Sailboat";
            this.labelSailBoat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSailBoat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelSailboat_MouseDown);
            // 
            // labelBoat
            // 
            this.labelBoat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBoat.Location = new System.Drawing.Point(15, 26);
            this.labelBoat.Name = "labelBoat";
            this.labelBoat.Size = new System.Drawing.Size(100, 23);
            this.labelBoat.TabIndex = 0;
            this.labelBoat.Text = "Simple Boat";
            this.labelBoat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBoat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelBoat_MouseDown);
            // 
            // panelBoat
            // 
            this.panelBoat.AllowDrop = true;
            this.panelBoat.Controls.Add(this.pictureBoxBoat);
            this.panelBoat.Location = new System.Drawing.Point(147, 15);
            this.panelBoat.Name = "panelBoat";
            this.panelBoat.Size = new System.Drawing.Size(197, 135);
            this.panelBoat.TabIndex = 2;
            this.panelBoat.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelBoat_DragDrop);
            this.panelBoat.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelBoat_DragEnter);
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.panelWhiteColor);
            this.groupBoxColors.Controls.Add(this.labelSecondaryColor);
            this.groupBoxColors.Controls.Add(this.panelPurpleColor);
            this.groupBoxColors.Controls.Add(this.panelYellowColor);
            this.groupBoxColors.Controls.Add(this.panelGreenColor);
            this.groupBoxColors.Controls.Add(this.panelPinkColor);
            this.groupBoxColors.Controls.Add(this.panelCyanColor);
            this.groupBoxColors.Controls.Add(this.labelMainColor);
            this.groupBoxColors.Controls.Add(this.panelOrangeColor);
            this.groupBoxColors.Controls.Add(this.panelRedColor);
            this.groupBoxColors.Location = new System.Drawing.Point(350, 15);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new System.Drawing.Size(142, 142);
            this.groupBoxColors.TabIndex = 2;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Colors";
            // 
            // panelWhiteColor
            // 
            this.panelWhiteColor.BackColor = System.Drawing.Color.White;
            this.panelWhiteColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWhiteColor.Location = new System.Drawing.Point(104, 113);
            this.panelWhiteColor.Name = "panelWhiteColor";
            this.panelWhiteColor.Size = new System.Drawing.Size(25, 25);
            this.panelWhiteColor.TabIndex = 2;
            // 
            // labelSecondaryColor
            // 
            this.labelSecondaryColor.AllowDrop = true;
            this.labelSecondaryColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSecondaryColor.Location = new System.Drawing.Point(11, 51);
            this.labelSecondaryColor.Name = "labelSecondaryColor";
            this.labelSecondaryColor.Size = new System.Drawing.Size(118, 23);
            this.labelSecondaryColor.TabIndex = 4;
            this.labelSecondaryColor.Text = "Secondary Color";
            this.labelSecondaryColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSecondaryColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelSecondaryColor_DragDrop);
            this.labelSecondaryColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
            // 
            // panelPurpleColor
            // 
            this.panelPurpleColor.BackColor = System.Drawing.Color.Purple;
            this.panelPurpleColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPurpleColor.Location = new System.Drawing.Point(73, 113);
            this.panelPurpleColor.Name = "panelPurpleColor";
            this.panelPurpleColor.Size = new System.Drawing.Size(25, 25);
            this.panelPurpleColor.TabIndex = 0;
            // 
            // panelYellowColor
            // 
            this.panelYellowColor.BackColor = System.Drawing.Color.Yellow;
            this.panelYellowColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelYellowColor.Location = new System.Drawing.Point(11, 82);
            this.panelYellowColor.Name = "panelYellowColor";
            this.panelYellowColor.Size = new System.Drawing.Size(25, 25);
            this.panelYellowColor.TabIndex = 0;
            // 
            // panelGreenColor
            // 
            this.panelGreenColor.BackColor = System.Drawing.Color.Green;
            this.panelGreenColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGreenColor.Location = new System.Drawing.Point(42, 113);
            this.panelGreenColor.Name = "panelGreenColor";
            this.panelGreenColor.Size = new System.Drawing.Size(25, 25);
            this.panelGreenColor.TabIndex = 0;
            // 
            // panelPinkColor
            // 
            this.panelPinkColor.BackColor = System.Drawing.Color.Pink;
            this.panelPinkColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPinkColor.Location = new System.Drawing.Point(104, 82);
            this.panelPinkColor.Name = "panelPinkColor";
            this.panelPinkColor.Size = new System.Drawing.Size(25, 25);
            this.panelPinkColor.TabIndex = 3;
            // 
            // panelCyanColor
            // 
            this.panelCyanColor.BackColor = System.Drawing.Color.Cyan;
            this.panelCyanColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCyanColor.Location = new System.Drawing.Point(11, 113);
            this.panelCyanColor.Name = "panelCyanColor";
            this.panelCyanColor.Size = new System.Drawing.Size(25, 25);
            this.panelCyanColor.TabIndex = 0;
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Location = new System.Drawing.Point(11, 16);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(118, 23);
            this.labelMainColor.TabIndex = 0;
            this.labelMainColor.Text = "Main Color";
            this.labelMainColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
            // 
            // panelOrangeColor
            // 
            this.panelOrangeColor.BackColor = System.Drawing.Color.Orange;
            this.panelOrangeColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOrangeColor.Location = new System.Drawing.Point(42, 82);
            this.panelOrangeColor.Name = "panelOrangeColor";
            this.panelOrangeColor.Size = new System.Drawing.Size(25, 25);
            this.panelOrangeColor.TabIndex = 0;
            // 
            // panelRedColor
            // 
            this.panelRedColor.BackColor = System.Drawing.Color.Red;
            this.panelRedColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRedColor.Location = new System.Drawing.Point(73, 82);
            this.panelRedColor.Name = "panelRedColor";
            this.panelRedColor.Size = new System.Drawing.Size(25, 25);
            this.panelRedColor.TabIndex = 0;
            // 
            // buttonAppend
            // 
            this.buttonAppend.Location = new System.Drawing.Point(350, 175);
            this.buttonAppend.Name = "buttonAppend";
            this.buttonAppend.Size = new System.Drawing.Size(142, 23);
            this.buttonAppend.TabIndex = 3;
            this.buttonAppend.Text = "Append";
            this.buttonAppend.UseVisualStyleBackColor = true;
            this.buttonAppend.Click += new System.EventHandler(this.buttonAppend_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(350, 205);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(142, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormBoatConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAppend);
            this.Controls.Add(this.groupBoxColors);
            this.Controls.Add(this.panelBoat);
            this.Controls.Add(this.groupBoxBoatType);
            this.Controls.Add(this.groupBoxParameters);
            this.Name = "FormBoatConfig";
            this.Text = "FormBoatConfig";
            this.groupBoxParameters.ResumeLayout(false);
            this.groupBoxParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoat)).EndInit();
            this.groupBoxBoatType.ResumeLayout(false);
            this.panelBoat.ResumeLayout(false);
            this.groupBoxColors.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxParameters;
        private System.Windows.Forms.Label labelMaxSpeed;
        private System.Windows.Forms.Label labelMaxWeight;
        private System.Windows.Forms.CheckBox checkBoxSail;
        private System.Windows.Forms.CheckBox checkBoxAnchor;
        private System.Windows.Forms.CheckBox checkBoxBack;
        private System.Windows.Forms.CheckBox checkBoxFront;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxSpeed;
        private System.Windows.Forms.PictureBox pictureBoxBoat;
        private System.Windows.Forms.GroupBox groupBoxBoatType;
        private System.Windows.Forms.Label labelSailBoat;
        private System.Windows.Forms.Label labelBoat;
        private System.Windows.Forms.Panel panelBoat;
        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.Label labelMainColor;
        private System.Windows.Forms.Label labelSecondaryColor;
        private System.Windows.Forms.Button buttonAppend;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panelWhiteColor;
        private System.Windows.Forms.Panel panelPurpleColor;
        private System.Windows.Forms.Panel panelYellowColor;
        private System.Windows.Forms.Panel panelGreenColor;
        private System.Windows.Forms.Panel panelPinkColor;
        private System.Windows.Forms.Panel panelCyanColor;
        private System.Windows.Forms.Panel panelOrangeColor;
        private System.Windows.Forms.Panel panelRedColor;
    }
}