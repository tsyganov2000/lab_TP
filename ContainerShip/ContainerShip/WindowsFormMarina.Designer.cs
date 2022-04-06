namespace ContainerShip
{
    partial class WindowsFormMarina
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
            this.pictureBoxMarina = new System.Windows.Forms.PictureBox();
            this.buttonAddShip = new System.Windows.Forms.Button();
            this.buttonAddSuperShip = new System.Windows.Forms.Button();
            this.groupBoxPlace = new System.Windows.Forms.GroupBox();
            this.buttonPickUp = new System.Windows.Forms.Button();
            this.maskedTextBoxPlace = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.labelMarina = new System.Windows.Forms.Label();
            this.textBoxMarina = new System.Windows.Forms.TextBox();
            this.buttonAddMarina = new System.Windows.Forms.Button();
            this.listBoxMarina = new System.Windows.Forms.ListBox();
            this.buttonDelMarina = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMarina)).BeginInit();
            this.groupBoxPlace.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxMarina
            // 
            this.pictureBoxMarina.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxMarina.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMarina.Name = "pictureBoxMarina";
            this.pictureBoxMarina.Size = new System.Drawing.Size(637, 454);
            this.pictureBoxMarina.TabIndex = 0;
            this.pictureBoxMarina.TabStop = false;
            // 
            // buttonAddShip
            // 
            this.buttonAddShip.Location = new System.Drawing.Point(642, 260);
            this.buttonAddShip.Name = "buttonAddShip";
            this.buttonAddShip.Size = new System.Drawing.Size(117, 43);
            this.buttonAddShip.TabIndex = 1;
            this.buttonAddShip.Text = "Пришвартовать корабль";
            this.buttonAddShip.UseVisualStyleBackColor = true;
            this.buttonAddShip.Click += new System.EventHandler(this.buttonAddShip_Click);
            // 
            // buttonAddSuperShip
            // 
            this.buttonAddSuperShip.Location = new System.Drawing.Point(643, 309);
            this.buttonAddSuperShip.Name = "buttonAddSuperShip";
            this.buttonAddSuperShip.Size = new System.Drawing.Size(117, 43);
            this.buttonAddSuperShip.TabIndex = 2;
            this.buttonAddSuperShip.Text = "Пришвартовать контейнеровоз";
            this.buttonAddSuperShip.UseVisualStyleBackColor = true;
            this.buttonAddSuperShip.Click += new System.EventHandler(this.buttonAddSuperShip_Click);
            // 
            // groupBoxPlace
            // 
            this.groupBoxPlace.Controls.Add(this.buttonPickUp);
            this.groupBoxPlace.Controls.Add(this.maskedTextBoxPlace);
            this.groupBoxPlace.Controls.Add(this.labelPlace);
            this.groupBoxPlace.Location = new System.Drawing.Point(642, 358);
            this.groupBoxPlace.Name = "groupBoxPlace";
            this.groupBoxPlace.Size = new System.Drawing.Size(118, 90);
            this.groupBoxPlace.TabIndex = 3;
            this.groupBoxPlace.TabStop = false;
            this.groupBoxPlace.Text = "Забрать корабль";
            // 
            // buttonPickUp
            // 
            this.buttonPickUp.Location = new System.Drawing.Point(6, 60);
            this.buttonPickUp.Name = "buttonPickUp";
            this.buttonPickUp.Size = new System.Drawing.Size(106, 23);
            this.buttonPickUp.TabIndex = 2;
            this.buttonPickUp.Text = "Забрать";
            this.buttonPickUp.UseVisualStyleBackColor = true;
            this.buttonPickUp.Click += new System.EventHandler(this.buttonPickUp_Click);
            // 
            // maskedTextBoxPlace
            // 
            this.maskedTextBoxPlace.Location = new System.Drawing.Point(62, 31);
            this.maskedTextBoxPlace.Name = "maskedTextBoxPlace";
            this.maskedTextBoxPlace.Size = new System.Drawing.Size(45, 23);
            this.maskedTextBoxPlace.TabIndex = 1;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(13, 35);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(45, 15);
            this.labelPlace.TabIndex = 0;
            this.labelPlace.Text = "Место:";
            // 
            // labelMarina
            // 
            this.labelMarina.AutoSize = true;
            this.labelMarina.Location = new System.Drawing.Point(671, 1);
            this.labelMarina.Name = "labelMarina";
            this.labelMarina.Size = new System.Drawing.Size(64, 15);
            this.labelMarina.TabIndex = 3;
            this.labelMarina.Text = "Пристани:";
            // 
            // textBoxMarina
            // 
            this.textBoxMarina.Location = new System.Drawing.Point(643, 19);
            this.textBoxMarina.Name = "textBoxMarina";
            this.textBoxMarina.Size = new System.Drawing.Size(116, 23);
            this.textBoxMarina.TabIndex = 4;
            // 
            // buttonAddMarina
            // 
            this.buttonAddMarina.Location = new System.Drawing.Point(643, 48);
            this.buttonAddMarina.Name = "buttonAddMarina";
            this.buttonAddMarina.Size = new System.Drawing.Size(116, 38);
            this.buttonAddMarina.TabIndex = 5;
            this.buttonAddMarina.Text = "Добавить пристань";
            this.buttonAddMarina.UseVisualStyleBackColor = true;
            this.buttonAddMarina.Click += new System.EventHandler(this.buttonAddMarina_Click);
            // 
            // listBoxMarina
            // 
            this.listBoxMarina.FormattingEnabled = true;
            this.listBoxMarina.ItemHeight = 15;
            this.listBoxMarina.Location = new System.Drawing.Point(643, 92);
            this.listBoxMarina.Name = "listBoxMarina";
            this.listBoxMarina.Size = new System.Drawing.Size(116, 94);
            this.listBoxMarina.TabIndex = 6;
            this.listBoxMarina.SelectedIndexChanged += new System.EventHandler(this.listBoxMarina_SelectedIndexChanged);
            // 
            // buttonDelMarina
            // 
            this.buttonDelMarina.Location = new System.Drawing.Point(644, 192);
            this.buttonDelMarina.Name = "buttonDelMarina";
            this.buttonDelMarina.Size = new System.Drawing.Size(116, 29);
            this.buttonDelMarina.TabIndex = 7;
            this.buttonDelMarina.Text = "Удалить пристань";
            this.buttonDelMarina.UseVisualStyleBackColor = true;
            this.buttonDelMarina.Click += new System.EventHandler(this.buttonDelMarina_Click);
            // 
            // WindowsFormMarina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 454);
            this.Controls.Add(this.buttonDelMarina);
            this.Controls.Add(this.listBoxMarina);
            this.Controls.Add(this.buttonAddMarina);
            this.Controls.Add(this.textBoxMarina);
            this.Controls.Add(this.labelMarina);
            this.Controls.Add(this.groupBoxPlace);
            this.Controls.Add(this.buttonAddSuperShip);
            this.Controls.Add(this.buttonAddShip);
            this.Controls.Add(this.pictureBoxMarina);
            this.Name = "WindowsFormMarina";
            this.Text = "Пристань";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMarina)).EndInit();
            this.groupBoxPlace.ResumeLayout(false);
            this.groupBoxPlace.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBoxMarina;
        private Button buttonAddShip;
        private Button buttonAddSuperShip;
        private GroupBox groupBoxPlace;
        private Button buttonPickUp;
        private MaskedTextBox maskedTextBoxPlace;
        private Label labelPlace;
        private Label labelMarina;
        private TextBox textBoxMarina;
        private Button buttonAddMarina;
        private ListBox listBoxMarina;
        private Button buttonDelMarina;
    }
}