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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxSail = new System.Windows.Forms.CheckBox();
            this.checkBoxAnchor = new System.Windows.Forms.CheckBox();
            this.checkBoxBack = new System.Windows.Forms.CheckBox();
            this.checkBoxFront = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxBoat = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelSailBoat = new System.Windows.Forms.Label();
            this.labelBoat = new System.Windows.Forms.Label();
            this.panelBoat = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelSecondaryColor = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonAppend = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoat)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panelBoat.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxSail);
            this.groupBox1.Controls.Add(this.checkBoxAnchor);
            this.groupBox1.Controls.Add(this.checkBoxBack);
            this.groupBox1.Controls.Add(this.checkBoxFront);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDownWeight);
            this.groupBox1.Controls.Add(this.numericUpDownMaxSpeed);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Max Weight:";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Max Speed:";
            // 
            // pictureBoxBoat
            // 
            this.pictureBoxBoat.Location = new System.Drawing.Point(3, 22);
            this.pictureBoxBoat.Name = "pictureBoxBoat";
            this.pictureBoxBoat.Size = new System.Drawing.Size(191, 90);
            this.pictureBoxBoat.TabIndex = 1;
            this.pictureBoxBoat.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelSailBoat);
            this.groupBox2.Controls.Add(this.labelBoat);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(129, 107);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Boat Type";
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.labelSecondaryColor);
            this.groupBox3.Controls.Add(this.panel7);
            this.groupBox3.Controls.Add(this.panel4);
            this.groupBox3.Controls.Add(this.panel5);
            this.groupBox3.Controls.Add(this.panel8);
            this.groupBox3.Controls.Add(this.panel6);
            this.groupBox3.Controls.Add(this.labelMainColor);
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Location = new System.Drawing.Point(350, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(142, 142);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Colors";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(104, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(25, 25);
            this.panel1.TabIndex = 2;
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
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(73, 113);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(25, 25);
            this.panel7.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(11, 82);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(25, 25);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(42, 113);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(25, 25);
            this.panel5.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Location = new System.Drawing.Point(104, 82);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(25, 25);
            this.panel8.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(11, 113);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(25, 25);
            this.panel6.TabIndex = 0;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(42, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(25, 25);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(73, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(25, 25);
            this.panel2.TabIndex = 0;
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
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panelBoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormBoatConfig";
            this.Text = "FormBoatConfig";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoat)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panelBoat.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxSail;
        private System.Windows.Forms.CheckBox checkBoxAnchor;
        private System.Windows.Forms.CheckBox checkBoxBack;
        private System.Windows.Forms.CheckBox checkBoxFront;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxSpeed;
        private System.Windows.Forms.PictureBox pictureBoxBoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelSailBoat;
        private System.Windows.Forms.Label labelBoat;
        private System.Windows.Forms.Panel panelBoat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelMainColor;
        private System.Windows.Forms.Label labelSecondaryColor;
        private System.Windows.Forms.Button buttonAppend;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}