namespace BorwellChallenge
{
    partial class Form1
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
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblPaint = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblInfoStart = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.btnAddWall = new System.Windows.Forms.Button();
            this.btnAddDoor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstWalls = new System.Windows.Forms.ListBox();
            this.lstDoors = new System.Windows.Forms.ListBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnHelpRestart = new System.Windows.Forms.Button();
            this.btnHelpCalculate = new System.Windows.Forms.Button();
            this.btnHelpStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.BackColor = System.Drawing.Color.Transparent;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(250, 101);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(91, 20);
            this.lblWidth.TabIndex = 0;
            this.lblWidth.Text = "Width (m):";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(44, 99);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(81, 20);
            this.lblQuantity.TabIndex = 1;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.BackColor = System.Drawing.Color.Transparent;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(461, 101);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(98, 20);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "Height (m):";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.BackColor = System.Drawing.Color.Transparent;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(478, 354);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(0, 20);
            this.lblArea.TabIndex = 3;
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.BackColor = System.Drawing.Color.Transparent;
            this.lblVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.Location = new System.Drawing.Point(478, 402);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(0, 20);
            this.lblVolume.TabIndex = 4;
            // 
            // lblPaint
            // 
            this.lblPaint.AutoSize = true;
            this.lblPaint.BackColor = System.Drawing.Color.Transparent;
            this.lblPaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaint.Location = new System.Drawing.Point(478, 455);
            this.lblPaint.Name = "lblPaint";
            this.lblPaint.Size = new System.Drawing.Size(0, 20);
            this.lblPaint.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCalculate.Location = new System.Drawing.Point(48, 350);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(107, 35);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "2. Then click the \'Calculate\' button";
            // 
            // lblInfoStart
            // 
            this.lblInfoStart.AutoSize = true;
            this.lblInfoStart.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoStart.Location = new System.Drawing.Point(23, 66);
            this.lblInfoStart.Name = "lblInfoStart";
            this.lblInfoStart.Size = new System.Drawing.Size(249, 20);
            this.lblInfoStart.TabIndex = 14;
            this.lblInfoStart.Text = "1. Please fill in the following below.";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(329, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(297, 29);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "Room - Paint Challenge.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(460, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "3. Results will show in the section below.";
            // 
            // nudWidth
            // 
            this.nudWidth.DecimalPlaces = 3;
            this.nudWidth.Location = new System.Drawing.Point(340, 102);
            this.nudWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(86, 20);
            this.nudWidth.TabIndex = 18;
            this.nudWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(142, 102);
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(56, 20);
            this.nudQuantity.TabIndex = 19;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudHeight
            // 
            this.nudHeight.DecimalPlaces = 3;
            this.nudHeight.Location = new System.Drawing.Point(558, 104);
            this.nudHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(86, 20);
            this.nudHeight.TabIndex = 20;
            this.nudHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddWall
            // 
            this.btnAddWall.Location = new System.Drawing.Point(169, 142);
            this.btnAddWall.Name = "btnAddWall";
            this.btnAddWall.Size = new System.Drawing.Size(90, 23);
            this.btnAddWall.TabIndex = 21;
            this.btnAddWall.Text = "Add Walls";
            this.btnAddWall.UseVisualStyleBackColor = true;
            this.btnAddWall.Click += new System.EventHandler(this.btnAddWall_Click);
            // 
            // btnAddDoor
            // 
            this.btnAddDoor.Location = new System.Drawing.Point(558, 142);
            this.btnAddDoor.Name = "btnAddDoor";
            this.btnAddDoor.Size = new System.Drawing.Size(128, 23);
            this.btnAddDoor.TabIndex = 22;
            this.btnAddDoor.Text = "Add Door or Window";
            this.btnAddDoor.UseVisualStyleBackColor = true;
            this.btnAddDoor.Click += new System.EventHandler(this.btnAddDoor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 24;
            // 
            // lstWalls
            // 
            this.lstWalls.FormattingEnabled = true;
            this.lstWalls.Location = new System.Drawing.Point(48, 171);
            this.lstWalls.Name = "lstWalls";
            this.lstWalls.Size = new System.Drawing.Size(313, 69);
            this.lstWalls.TabIndex = 26;
            // 
            // lstDoors
            // 
            this.lstDoors.FormattingEnabled = true;
            this.lstDoors.Location = new System.Drawing.Point(464, 171);
            this.lstDoors.Name = "lstDoors";
            this.lstDoors.Size = new System.Drawing.Size(313, 69);
            this.lstDoors.TabIndex = 27;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 3;
            this.numericUpDown1.Location = new System.Drawing.Point(776, 107);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(86, 20);
            this.numericUpDown1.TabIndex = 29;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(679, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Length (m):";
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.IndianRed;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRestart.Location = new System.Drawing.Point(48, 414);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(107, 35);
            this.btnRestart.TabIndex = 30;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnHelpRestart
            // 
            this.btnHelpRestart.Location = new System.Drawing.Point(169, 414);
            this.btnHelpRestart.Name = "btnHelpRestart";
            this.btnHelpRestart.Size = new System.Drawing.Size(34, 20);
            this.btnHelpRestart.TabIndex = 31;
            this.btnHelpRestart.Text = "?";
            this.btnHelpRestart.UseVisualStyleBackColor = true;
            this.btnHelpRestart.Click += new System.EventHandler(this.btnHelpRestart_Click);
            // 
            // btnHelpCalculate
            // 
            this.btnHelpCalculate.Location = new System.Drawing.Point(169, 350);
            this.btnHelpCalculate.Name = "btnHelpCalculate";
            this.btnHelpCalculate.Size = new System.Drawing.Size(34, 20);
            this.btnHelpCalculate.TabIndex = 32;
            this.btnHelpCalculate.Text = "?";
            this.btnHelpCalculate.UseVisualStyleBackColor = true;
            this.btnHelpCalculate.Click += new System.EventHandler(this.btnHelpCalculate_Click);
            // 
            // btnHelpStart
            // 
            this.btnHelpStart.Location = new System.Drawing.Point(278, 66);
            this.btnHelpStart.Name = "btnHelpStart";
            this.btnHelpStart.Size = new System.Drawing.Size(34, 20);
            this.btnHelpStart.TabIndex = 33;
            this.btnHelpStart.Text = "?";
            this.btnHelpStart.UseVisualStyleBackColor = true;
            this.btnHelpStart.Click += new System.EventHandler(this.btnHelpStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(974, 570);
            this.Controls.Add(this.btnHelpStart);
            this.Controls.Add(this.btnHelpCalculate);
            this.Controls.Add(this.btnHelpRestart);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstDoors);
            this.Controls.Add(this.lstWalls);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddDoor);
            this.Controls.Add(this.btnAddWall);
            this.Controls.Add(this.nudHeight);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.nudWidth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblInfoStart);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblPaint);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblWidth);
            this.Name = "Form1";
            this.Text = "Borwell Challenge.";
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblPaint;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblInfoStart;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.Button btnAddWall;
        private System.Windows.Forms.Button btnAddDoor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstWalls;
        private System.Windows.Forms.ListBox lstDoors;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnHelpRestart;
        private System.Windows.Forms.Button btnHelpCalculate;
        private System.Windows.Forms.Button btnHelpStart;
    }
}

