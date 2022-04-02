namespace ContainerShip
{
    partial class WindowsFormShipConfig
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
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.checkBoxContainers = new System.Windows.Forms.CheckBox();
            this.checkBoxCran = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.groupBoxShips = new System.Windows.Forms.GroupBox();
            this.labelSuperShip = new System.Windows.Forms.Label();
            this.labelShip = new System.Windows.Forms.Label();
            this.panelShipConfig = new System.Windows.Forms.Panel();
            this.pictureBoxShipConfig = new System.Windows.Forms.PictureBox();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelOrange = new System.Windows.Forms.Panel();
            this.panelGray = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).BeginInit();
            this.groupBoxShips.SuspendLayout();
            this.panelShipConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShipConfig)).BeginInit();
            this.groupBoxColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Controls.Add(this.checkBoxContainers);
            this.groupBoxSettings.Controls.Add(this.checkBoxCran);
            this.groupBoxSettings.Controls.Add(this.numericUpDownWeight);
            this.groupBoxSettings.Controls.Add(this.numericUpDownSpeed);
            this.groupBoxSettings.Controls.Add(this.labelWeight);
            this.groupBoxSettings.Controls.Add(this.labelSpeed);
            this.groupBoxSettings.Location = new System.Drawing.Point(2, 168);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(373, 121);
            this.groupBoxSettings.TabIndex = 0;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Параметры";
            // 
            // checkBoxContainers
            // 
            this.checkBoxContainers.AutoSize = true;
            this.checkBoxContainers.Checked = true;
            this.checkBoxContainers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxContainers.Location = new System.Drawing.Point(206, 69);
            this.checkBoxContainers.Name = "checkBoxContainers";
            this.checkBoxContainers.Size = new System.Drawing.Size(149, 19);
            this.checkBoxContainers.TabIndex = 5;
            this.checkBoxContainers.Text = "Наличие контейнеров";
            this.checkBoxContainers.UseVisualStyleBackColor = true;
            // 
            // checkBoxCran
            // 
            this.checkBoxCran.AutoSize = true;
            this.checkBoxCran.Checked = true;
            this.checkBoxCran.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCran.Location = new System.Drawing.Point(206, 33);
            this.checkBoxCran.Name = "checkBoxCran";
            this.checkBoxCran.Size = new System.Drawing.Size(110, 19);
            this.checkBoxCran.TabIndex = 4;
            this.checkBoxCran.Text = "Наличие крана";
            this.checkBoxCran.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(90, 90);
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
            this.numericUpDownWeight.Size = new System.Drawing.Size(66, 23);
            this.numericUpDownWeight.TabIndex = 3;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // numericUpDownSpeed
            // 
            this.numericUpDownSpeed.Location = new System.Drawing.Point(90, 44);
            this.numericUpDownSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownSpeed.Name = "numericUpDownSpeed";
            this.numericUpDownSpeed.Size = new System.Drawing.Size(66, 23);
            this.numericUpDownSpeed.TabIndex = 2;
            this.numericUpDownSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(28, 70);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(78, 15);
            this.labelWeight.TabIndex = 1;
            this.labelWeight.Text = "Вес корабля:";
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(28, 23);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(95, 15);
            this.labelSpeed.TabIndex = 0;
            this.labelSpeed.Text = "Макс. скорость:";
            // 
            // groupBoxShips
            // 
            this.groupBoxShips.Controls.Add(this.labelSuperShip);
            this.groupBoxShips.Controls.Add(this.labelShip);
            this.groupBoxShips.Location = new System.Drawing.Point(14, 14);
            this.groupBoxShips.Name = "groupBoxShips";
            this.groupBoxShips.Size = new System.Drawing.Size(168, 148);
            this.groupBoxShips.TabIndex = 2;
            this.groupBoxShips.TabStop = false;
            this.groupBoxShips.Text = "Тип судна";
            // 
            // labelSuperShip
            // 
            this.labelSuperShip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSuperShip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSuperShip.Location = new System.Drawing.Point(16, 85);
            this.labelSuperShip.Name = "labelSuperShip";
            this.labelSuperShip.Size = new System.Drawing.Size(136, 39);
            this.labelSuperShip.TabIndex = 1;
            this.labelSuperShip.Text = "Контейнеровоз";
            this.labelSuperShip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSuperShip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelObject_MouseDown);
            // 
            // labelShip
            // 
            this.labelShip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelShip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelShip.Location = new System.Drawing.Point(16, 28);
            this.labelShip.Name = "labelShip";
            this.labelShip.Size = new System.Drawing.Size(136, 39);
            this.labelShip.TabIndex = 0;
            this.labelShip.Text = "Корабль";
            this.labelShip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelShip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelObject_MouseDown);
            // 
            // panelShipConfig
            // 
            this.panelShipConfig.AllowDrop = true;
            this.panelShipConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelShipConfig.Controls.Add(this.pictureBoxShipConfig);
            this.panelShipConfig.Location = new System.Drawing.Point(188, 7);
            this.panelShipConfig.Name = "panelShipConfig";
            this.panelShipConfig.Size = new System.Drawing.Size(186, 167);
            this.panelShipConfig.TabIndex = 3;
            this.panelShipConfig.DragDrop += new System.Windows.Forms.DragEventHandler(this.PanelShipConfig_DragDrop);
            this.panelShipConfig.DragEnter += new System.Windows.Forms.DragEventHandler(this.PanelShipConfig_DragEnter);
            // 
            // pictureBoxShipConfig
            // 
            this.pictureBoxShipConfig.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxShipConfig.Location = new System.Drawing.Point(44, 54);
            this.pictureBoxShipConfig.Name = "pictureBoxShipConfig";
            this.pictureBoxShipConfig.Size = new System.Drawing.Size(96, 57);
            this.pictureBoxShipConfig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxShipConfig.TabIndex = 0;
            this.pictureBoxShipConfig.TabStop = false;
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.panelBlue);
            this.groupBoxColors.Controls.Add(this.panelGreen);
            this.groupBoxColors.Controls.Add(this.panelOrange);
            this.groupBoxColors.Controls.Add(this.panelGray);
            this.groupBoxColors.Controls.Add(this.panelWhite);
            this.groupBoxColors.Controls.Add(this.panelYellow);
            this.groupBoxColors.Controls.Add(this.panelBlack);
            this.groupBoxColors.Controls.Add(this.panelRed);
            this.groupBoxColors.Controls.Add(this.labelDopColor);
            this.groupBoxColors.Controls.Add(this.labelMainColor);
            this.groupBoxColors.Location = new System.Drawing.Point(386, 11);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new System.Drawing.Size(249, 188);
            this.groupBoxColors.TabIndex = 4;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Цвета";
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(195, 136);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(38, 36);
            this.panelBlue.TabIndex = 6;
            this.panelBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelColor_MouseDown);
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelGreen.Location = new System.Drawing.Point(138, 136);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(38, 36);
            this.panelGreen.TabIndex = 6;
            this.panelGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelColor_MouseDown);
            // 
            // panelOrange
            // 
            this.panelOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelOrange.Location = new System.Drawing.Point(74, 136);
            this.panelOrange.Name = "panelOrange";
            this.panelOrange.Size = new System.Drawing.Size(38, 36);
            this.panelOrange.TabIndex = 6;
            this.panelOrange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelColor_MouseDown);
            // 
            // panelGray
            // 
            this.panelGray.BackColor = System.Drawing.Color.Gray;
            this.panelGray.Location = new System.Drawing.Point(19, 136);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(38, 36);
            this.panelGray.TabIndex = 6;
            this.panelGray.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelColor_MouseDown);
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.Location = new System.Drawing.Point(195, 79);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(38, 36);
            this.panelWhite.TabIndex = 5;
            this.panelWhite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelColor_MouseDown);
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(74, 79);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(38, 36);
            this.panelYellow.TabIndex = 3;
            this.panelYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelColor_MouseDown);
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(138, 79);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(38, 36);
            this.panelBlack.TabIndex = 4;
            this.panelBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelColor_MouseDown);
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(19, 79);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(38, 36);
            this.panelRed.TabIndex = 2;
            this.panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelColor_MouseDown);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDopColor.Location = new System.Drawing.Point(129, 25);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(113, 39);
            this.labelDopColor.TabIndex = 1;
            this.labelDopColor.Text = "Доп. цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.LabelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.LabelMainColor_DragEnter);
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMainColor.Location = new System.Drawing.Point(8, 25);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(113, 39);
            this.labelMainColor.TabIndex = 0;
            this.labelMainColor.Text = "Основной цвет";
            this.labelMainColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.LabelMainColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.LabelMainColor_DragEnter);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(553, 217);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(553, 253);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // WindowsFormShipConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 291);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxColors);
            this.Controls.Add(this.panelShipConfig);
            this.Controls.Add(this.groupBoxShips);
            this.Controls.Add(this.groupBoxSettings);
            this.Name = "WindowsFormShipConfig";
            this.Text = "Выбор корабля";
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).EndInit();
            this.groupBoxShips.ResumeLayout(false);
            this.panelShipConfig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShipConfig)).EndInit();
            this.groupBoxColors.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxSettings;
        private Label labelSpeed;
        private CheckBox checkBoxContainers;
        private CheckBox checkBoxCran;
        private NumericUpDown numericUpDownWeight;
        private NumericUpDown numericUpDownSpeed;
        private Label labelWeight;
        private GroupBox groupBoxShips;
        private Label labelSuperShip;
        private Label labelShip;
        private Panel panelShipConfig;
        private PictureBox pictureBoxShipConfig;
        private GroupBox groupBoxColors;
        private Panel panelBlue;
        private Panel panelGreen;
        private Panel panelOrange;
        private Panel panelGray;
        private Panel panelWhite;
        private Panel panelYellow;
        private Panel panelBlack;
        private Panel panelRed;
        private Label labelDopColor;
        private Label labelMainColor;
        private Button buttonAdd;
        private Button buttonCancel;
    }
}