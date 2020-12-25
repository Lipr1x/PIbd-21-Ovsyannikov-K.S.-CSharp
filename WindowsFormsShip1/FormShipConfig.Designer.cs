namespace WindowsFormsTruck
{
    partial class FormShipConfig
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
			this.labelWarShip = new System.Windows.Forms.Label();
			this.labelShip = new System.Windows.Forms.Label();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.checkBoxRadar = new System.Windows.Forms.CheckBox();
			this.checkBoxWeapon = new System.Windows.Forms.CheckBox();
			this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownMaxSpeed = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panelShip = new System.Windows.Forms.Panel();
			this.pictureBoxShip = new System.Windows.Forms.PictureBox();
			this.groupBoxColors = new System.Windows.Forms.GroupBox();
			this.panelBlue = new System.Windows.Forms.Panel();
			this.panelGreen = new System.Windows.Forms.Panel();
			this.panelOrange = new System.Windows.Forms.Panel();
			this.panelGray = new System.Windows.Forms.Panel();
			this.panelWhite = new System.Windows.Forms.Panel();
			this.panelBlack = new System.Windows.Forms.Panel();
			this.panelYellow = new System.Windows.Forms.Panel();
			this.panelRed = new System.Windows.Forms.Panel();
			this.labelDopColor = new System.Windows.Forms.Label();
			this.labelMainColor = new System.Windows.Forms.Label();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).BeginInit();
			this.panelShip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxShip)).BeginInit();
			this.groupBoxColors.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.labelWarShip);
			this.groupBox1.Controls.Add(this.labelShip);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(212, 127);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Тип корабля";
			// 
			// labelWarShip
			// 
			this.labelWarShip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelWarShip.Location = new System.Drawing.Point(46, 80);
			this.labelWarShip.Name = "labelWarShip";
			this.labelWarShip.Size = new System.Drawing.Size(109, 31);
			this.labelWarShip.TabIndex = 1;
			this.labelWarShip.Text = "Крейсер";
			this.labelWarShip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelWarShip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelWarShip_MouseDown);
			// 
			// labelShip
			// 
			this.labelShip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelShip.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelShip.Location = new System.Drawing.Point(46, 33);
			this.labelShip.Name = "labelShip";
			this.labelShip.Size = new System.Drawing.Size(109, 31);
			this.labelShip.TabIndex = 1;
			this.labelShip.Text = "Военный корабль";
			this.labelShip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelShip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelShip_MouseDown);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.checkBoxRadar);
			this.groupBox2.Controls.Add(this.checkBoxWeapon);
			this.groupBox2.Controls.Add(this.numericUpDownWeight);
			this.groupBox2.Controls.Add(this.numericUpDownMaxSpeed);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Location = new System.Drawing.Point(12, 244);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(241, 165);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Параметры";
			// 
			// checkBoxRadar
			// 
			this.checkBoxRadar.AutoSize = true;
			this.checkBoxRadar.Location = new System.Drawing.Point(178, 111);
			this.checkBoxRadar.Name = "checkBoxRadar";
			this.checkBoxRadar.Size = new System.Drawing.Size(57, 17);
			this.checkBoxRadar.TabIndex = 5;
			this.checkBoxRadar.Text = "Радар";
			this.checkBoxRadar.UseVisualStyleBackColor = true;
			// 
			// checkBoxWeapon
			// 
			this.checkBoxWeapon.AutoSize = true;
			this.checkBoxWeapon.Location = new System.Drawing.Point(176, 69);
			this.checkBoxWeapon.Name = "checkBoxWeapon";
			this.checkBoxWeapon.Size = new System.Drawing.Size(59, 17);
			this.checkBoxWeapon.TabIndex = 4;
			this.checkBoxWeapon.Text = "Пушка";
			this.checkBoxWeapon.UseVisualStyleBackColor = true;
			// 
			// numericUpDownWeight
			// 
			this.numericUpDownWeight.Location = new System.Drawing.Point(11, 121);
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
			this.numericUpDownWeight.Size = new System.Drawing.Size(73, 20);
			this.numericUpDownWeight.TabIndex = 3;
			this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// numericUpDownMaxSpeed
			// 
			this.numericUpDownMaxSpeed.Location = new System.Drawing.Point(11, 62);
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
			this.numericUpDownMaxSpeed.Size = new System.Drawing.Size(73, 20);
			this.numericUpDownMaxSpeed.TabIndex = 2;
			this.numericUpDownMaxSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(14, 94);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 13);
			this.label4.TabIndex = 1;
			this.label4.Text = "Вес корабля";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(14, 38);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(134, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Максимальная скорость";
			// 
			// panelShip
			// 
			this.panelShip.AllowDrop = true;
			this.panelShip.Controls.Add(this.pictureBoxShip);
			this.panelShip.Location = new System.Drawing.Point(387, 25);
			this.panelShip.Name = "panelShip";
			this.panelShip.Size = new System.Drawing.Size(264, 171);
			this.panelShip.TabIndex = 2;
			this.panelShip.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelShip_DragDrop);
			this.panelShip.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelShip_DragEnter);
			// 
			// pictureBoxShip
			// 
			this.pictureBoxShip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBoxShip.Location = new System.Drawing.Point(3, 3);
			this.pictureBoxShip.Name = "pictureBoxShip";
			this.pictureBoxShip.Size = new System.Drawing.Size(256, 158);
			this.pictureBoxShip.TabIndex = 0;
			this.pictureBoxShip.TabStop = false;
			// 
			// groupBoxColors
			// 
			this.groupBoxColors.Controls.Add(this.panelBlue);
			this.groupBoxColors.Controls.Add(this.panelGreen);
			this.groupBoxColors.Controls.Add(this.panelOrange);
			this.groupBoxColors.Controls.Add(this.panelGray);
			this.groupBoxColors.Controls.Add(this.panelWhite);
			this.groupBoxColors.Controls.Add(this.panelBlack);
			this.groupBoxColors.Controls.Add(this.panelYellow);
			this.groupBoxColors.Controls.Add(this.panelRed);
			this.groupBoxColors.Controls.Add(this.labelDopColor);
			this.groupBoxColors.Controls.Add(this.labelMainColor);
			this.groupBoxColors.Location = new System.Drawing.Point(752, 34);
			this.groupBoxColors.Name = "groupBoxColors";
			this.groupBoxColors.Size = new System.Drawing.Size(410, 223);
			this.groupBoxColors.TabIndex = 3;
			this.groupBoxColors.TabStop = false;
			this.groupBoxColors.Text = "Цвета";
			// 
			// panelBlue
			// 
			this.panelBlue.BackColor = System.Drawing.Color.Blue;
			this.panelBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelBlue.Location = new System.Drawing.Point(303, 145);
			this.panelBlue.Name = "panelBlue";
			this.panelBlue.Size = new System.Drawing.Size(39, 37);
			this.panelBlue.TabIndex = 8;
			// 
			// panelGreen
			// 
			this.panelGreen.BackColor = System.Drawing.Color.Green;
			this.panelGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelGreen.Location = new System.Drawing.Point(207, 145);
			this.panelGreen.Name = "panelGreen";
			this.panelGreen.Size = new System.Drawing.Size(39, 37);
			this.panelGreen.TabIndex = 7;
			// 
			// panelOrange
			// 
			this.panelOrange.BackColor = System.Drawing.Color.Orange;
			this.panelOrange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelOrange.Location = new System.Drawing.Point(129, 145);
			this.panelOrange.Name = "panelOrange";
			this.panelOrange.Size = new System.Drawing.Size(39, 37);
			this.panelOrange.TabIndex = 6;
			// 
			// panelGray
			// 
			this.panelGray.BackColor = System.Drawing.Color.Gray;
			this.panelGray.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelGray.Location = new System.Drawing.Point(33, 145);
			this.panelGray.Name = "panelGray";
			this.panelGray.Size = new System.Drawing.Size(39, 37);
			this.panelGray.TabIndex = 5;
			// 
			// panelWhite
			// 
			this.panelWhite.BackColor = System.Drawing.Color.White;
			this.panelWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelWhite.Location = new System.Drawing.Point(303, 83);
			this.panelWhite.Name = "panelWhite";
			this.panelWhite.Size = new System.Drawing.Size(39, 37);
			this.panelWhite.TabIndex = 4;
			// 
			// panelBlack
			// 
			this.panelBlack.BackColor = System.Drawing.Color.Black;
			this.panelBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelBlack.Location = new System.Drawing.Point(207, 83);
			this.panelBlack.Name = "panelBlack";
			this.panelBlack.Size = new System.Drawing.Size(39, 37);
			this.panelBlack.TabIndex = 3;
			// 
			// panelYellow
			// 
			this.panelYellow.BackColor = System.Drawing.Color.Yellow;
			this.panelYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelYellow.Location = new System.Drawing.Point(129, 83);
			this.panelYellow.Name = "panelYellow";
			this.panelYellow.Size = new System.Drawing.Size(39, 37);
			this.panelYellow.TabIndex = 9;
			// 
			// panelRed
			// 
			this.panelRed.BackColor = System.Drawing.Color.Red;
			this.panelRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelRed.Location = new System.Drawing.Point(33, 83);
			this.panelRed.Name = "panelRed";
			this.panelRed.Size = new System.Drawing.Size(39, 37);
			this.panelRed.TabIndex = 0;
			// 
			// labelDopColor
			// 
			this.labelDopColor.AllowDrop = true;
			this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelDopColor.Location = new System.Drawing.Point(207, 31);
			this.labelDopColor.Name = "labelDopColor";
			this.labelDopColor.Size = new System.Drawing.Size(135, 38);
			this.labelDopColor.TabIndex = 1;
			this.labelDopColor.Text = "Доп. цвет";
			this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
			this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelColor_DragEnter);
			// 
			// labelMainColor
			// 
			this.labelMainColor.AllowDrop = true;
			this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelMainColor.Location = new System.Drawing.Point(33, 31);
			this.labelMainColor.Name = "labelMainColor";
			this.labelMainColor.Size = new System.Drawing.Size(135, 38);
			this.labelMainColor.TabIndex = 0;
			this.labelMainColor.Text = "Основной цвет";
			this.labelMainColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragDrop);
			this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelColor_DragEnter);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(1009, 287);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(153, 39);
			this.buttonAdd.TabIndex = 4;
			this.buttonAdd.Text = "Добавить";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(1011, 346);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(153, 39);
			this.buttonCancel.TabIndex = 5;
			this.buttonCancel.Text = "отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// FormShipConfig
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1176, 450);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.groupBoxColors);
			this.Controls.Add(this.panelShip);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "FormShipConfig";
			this.Text = "FormShipConfig";
			this.Load += new System.EventHandler(this.FormShipConfig_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).EndInit();
			this.panelShip.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxShip)).EndInit();
			this.groupBoxColors.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelWarShip;
        private System.Windows.Forms.Label labelShip;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxRadar;
        private System.Windows.Forms.CheckBox checkBoxWeapon;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelShip;
        private System.Windows.Forms.PictureBox pictureBoxShip;
        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelOrange;
        private System.Windows.Forms.Panel panelGray;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelMainColor;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
    }
}