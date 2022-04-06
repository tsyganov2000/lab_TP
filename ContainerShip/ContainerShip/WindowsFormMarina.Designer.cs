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
            this.groupBoxPlace = new System.Windows.Forms.GroupBox();
            this.buttonPickUp = new System.Windows.Forms.Button();
            this.maskedTextBoxPlace = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.labelMarina = new System.Windows.Forms.Label();
            this.textBoxMarina = new System.Windows.Forms.TextBox();
            this.buttonAddMarina = new System.Windows.Forms.Button();
            this.listBoxMarina = new System.Windows.Forms.ListBox();
            this.buttonDelMarina = new System.Windows.Forms.Button();
            this.buttonAddShip = new System.Windows.Forms.Button();
            this.menuStripFile = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMarina)).BeginInit();
            this.groupBoxPlace.SuspendLayout();
            this.menuStripFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxMarina
            // 
            this.pictureBoxMarina.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxMarina.Location = new System.Drawing.Point(0, 24);
            this.pictureBoxMarina.Name = "pictureBoxMarina";
            this.pictureBoxMarina.Size = new System.Drawing.Size(637, 430);
            this.pictureBoxMarina.TabIndex = 0;
            this.pictureBoxMarina.TabStop = false;
            // 
            // groupBoxPlace
            // 
            this.groupBoxPlace.Controls.Add(this.buttonPickUp);
            this.groupBoxPlace.Controls.Add(this.maskedTextBoxPlace);
            this.groupBoxPlace.Controls.Add(this.labelPlace);
            this.groupBoxPlace.Location = new System.Drawing.Point(644, 354);
            this.groupBoxPlace.Name = "groupBoxPlace";
            this.groupBoxPlace.Size = new System.Drawing.Size(115, 94);
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
            this.labelMarina.Location = new System.Drawing.Point(671, 26);
            this.labelMarina.Name = "labelMarina";
            this.labelMarina.Size = new System.Drawing.Size(64, 15);
            this.labelMarina.TabIndex = 3;
            this.labelMarina.Text = "Пристани:";
            // 
            // textBoxMarina
            // 
            this.textBoxMarina.Location = new System.Drawing.Point(643, 44);
            this.textBoxMarina.Name = "textBoxMarina";
            this.textBoxMarina.Size = new System.Drawing.Size(116, 23);
            this.textBoxMarina.TabIndex = 4;
            // 
            // buttonAddMarina
            // 
            this.buttonAddMarina.Location = new System.Drawing.Point(643, 73);
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
            this.listBoxMarina.Location = new System.Drawing.Point(643, 117);
            this.listBoxMarina.Name = "listBoxMarina";
            this.listBoxMarina.Size = new System.Drawing.Size(116, 94);
            this.listBoxMarina.TabIndex = 6;
            this.listBoxMarina.SelectedIndexChanged += new System.EventHandler(this.listBoxMarina_SelectedIndexChanged);
            // 
            // buttonDelMarina
            // 
            this.buttonDelMarina.Location = new System.Drawing.Point(644, 217);
            this.buttonDelMarina.Name = "buttonDelMarina";
            this.buttonDelMarina.Size = new System.Drawing.Size(116, 29);
            this.buttonDelMarina.TabIndex = 7;
            this.buttonDelMarina.Text = "Удалить пристань";
            this.buttonDelMarina.UseVisualStyleBackColor = true;
            this.buttonDelMarina.Click += new System.EventHandler(this.buttonDelMarina_Click);
            // 
            // buttonAddShip
            // 
            this.buttonAddShip.Location = new System.Drawing.Point(644, 297);
            this.buttonAddShip.Name = "buttonAddShip";
            this.buttonAddShip.Size = new System.Drawing.Size(115, 43);
            this.buttonAddShip.TabIndex = 8;
            this.buttonAddShip.Text = "Добавить судно";
            this.buttonAddShip.UseVisualStyleBackColor = true;
            this.buttonAddShip.Click += new System.EventHandler(this.ButtonAddShip_Click);
            // 
            // menuStripFile
            // 
            this.menuStripFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStripFile.Location = new System.Drawing.Point(0, 0);
            this.menuStripFile.Name = "menuStripFile";
            this.menuStripFile.Size = new System.Drawing.Size(764, 24);
            this.menuStripFile.TabIndex = 9;
            this.menuStripFile.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt file | *.txt";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "txt file | *.txt";
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(645, 256);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(115, 23);
            this.buttonSort.TabIndex = 10;
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // WindowsFormMarina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 454);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonAddShip);
            this.Controls.Add(this.buttonDelMarina);
            this.Controls.Add(this.listBoxMarina);
            this.Controls.Add(this.buttonAddMarina);
            this.Controls.Add(this.textBoxMarina);
            this.Controls.Add(this.labelMarina);
            this.Controls.Add(this.groupBoxPlace);
            this.Controls.Add(this.pictureBoxMarina);
            this.Controls.Add(this.menuStripFile);
            this.MainMenuStrip = this.menuStripFile;
            this.Name = "WindowsFormMarina";
            this.Text = "Пристань";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMarina)).EndInit();
            this.groupBoxPlace.ResumeLayout(false);
            this.groupBoxPlace.PerformLayout();
            this.menuStripFile.ResumeLayout(false);
            this.menuStripFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBoxMarina;
        private GroupBox groupBoxPlace;
        private Button buttonPickUp;
        private MaskedTextBox maskedTextBoxPlace;
        private Label labelPlace;
        private Label labelMarina;
        private TextBox textBoxMarina;
        private Button buttonAddMarina;
        private ListBox listBoxMarina;
        private Button buttonDelMarina;
        private Button buttonAddShip;
        private MenuStrip menuStripFile;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem загрузитьToolStripMenuItem;
        private SaveFileDialog saveFileDialog;
        private OpenFileDialog openFileDialog;
        private Button buttonSort;
    }
}