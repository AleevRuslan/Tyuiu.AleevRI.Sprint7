
namespace Tyuiu.AleevRI.Sprint7.Project.V10
{
    partial class FormMain
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
            this.panelUp_ARI = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOpen_ARI = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelLeftMenu_ARI = new System.Windows.Forms.Panel();
            this.buttonDelRows_ARI = new System.Windows.Forms.Button();
            this.buttonAddRows_ARI_ARI = new System.Windows.Forms.Button();
            this.openFileDialog_ARI = new System.Windows.Forms.OpenFileDialog();
            this.PriceOrder_ARI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOrder_ARI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address_ARI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountNumber_ARI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber_ARI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIO_ARI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewOrders_ARI = new System.Windows.Forms.DataGridView();
            this.saveFileDialog_ARI = new System.Windows.Forms.SaveFileDialog();
            this.ToolStripMenuItemHelp_ARI = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemInfo_ARI = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonGraphic_ARI = new System.Windows.Forms.Button();
            this.panelUp_ARI.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelLeftMenu_ARI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders_ARI)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUp_ARI
            // 
            this.panelUp_ARI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.panelUp_ARI.Controls.Add(this.menuStrip1);
            this.panelUp_ARI.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp_ARI.Location = new System.Drawing.Point(0, 0);
            this.panelUp_ARI.Name = "panelUp_ARI";
            this.panelUp_ARI.Size = new System.Drawing.Size(731, 56);
            this.panelUp_ARI.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.ToolStripMenuItemHelp_ARI,
            this.ToolStripMenuItemInfo_ARI});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(731, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemOpen_ARI,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // toolStripMenuItemOpen_ARI
            // 
            this.toolStripMenuItemOpen_ARI.Name = "toolStripMenuItemOpen_ARI";
            this.toolStripMenuItemOpen_ARI.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItemOpen_ARI.Text = "Открыть";
            this.toolStripMenuItemOpen_ARI.Click += new System.EventHandler(this.buttonOpenFile_ARI_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.buttonSaveFile_ARI_Click);
            // 
            // panelLeftMenu_ARI
            // 
            this.panelLeftMenu_ARI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.panelLeftMenu_ARI.Controls.Add(this.buttonDelRows_ARI);
            this.panelLeftMenu_ARI.Controls.Add(this.buttonGraphic_ARI);
            this.panelLeftMenu_ARI.Controls.Add(this.buttonAddRows_ARI_ARI);
            this.panelLeftMenu_ARI.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftMenu_ARI.Location = new System.Drawing.Point(0, 56);
            this.panelLeftMenu_ARI.Name = "panelLeftMenu_ARI";
            this.panelLeftMenu_ARI.Size = new System.Drawing.Size(186, 482);
            this.panelLeftMenu_ARI.TabIndex = 4;
            // 
            // buttonDelRows_ARI
            // 
            this.buttonDelRows_ARI.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonDelRows_ARI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelRows_ARI.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonDelRows_ARI.Location = new System.Drawing.Point(0, 281);
            this.buttonDelRows_ARI.Name = "buttonDelRows_ARI";
            this.buttonDelRows_ARI.Size = new System.Drawing.Size(186, 58);
            this.buttonDelRows_ARI.TabIndex = 9;
            this.buttonDelRows_ARI.Text = "Удалить строку";
            this.buttonDelRows_ARI.UseVisualStyleBackColor = true;
            this.buttonDelRows_ARI.Click += new System.EventHandler(this.buttonDelRows_ARI_Click);
            // 
            // buttonAddRows_ARI_ARI
            // 
            this.buttonAddRows_ARI_ARI.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonAddRows_ARI_ARI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddRows_ARI_ARI.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAddRows_ARI_ARI.Location = new System.Drawing.Point(0, 147);
            this.buttonAddRows_ARI_ARI.Name = "buttonAddRows_ARI_ARI";
            this.buttonAddRows_ARI_ARI.Size = new System.Drawing.Size(186, 58);
            this.buttonAddRows_ARI_ARI.TabIndex = 9;
            this.buttonAddRows_ARI_ARI.Text = "Добавить строку";
            this.buttonAddRows_ARI_ARI.UseVisualStyleBackColor = true;
            this.buttonAddRows_ARI_ARI.Click += new System.EventHandler(this.buttonAddRows_ARI_ARI_Click);
            // 
            // openFileDialog_ARI
            // 
            this.openFileDialog_ARI.FileName = "openFileDialog1";
            // 
            // PriceOrder_ARI
            // 
            this.PriceOrder_ARI.HeaderText = "Стоимость заказа";
            this.PriceOrder_ARI.Name = "PriceOrder_ARI";
            // 
            // NumberOrder_ARI
            // 
            this.NumberOrder_ARI.HeaderText = "Номер заказа";
            this.NumberOrder_ARI.MaxInputLength = 5;
            this.NumberOrder_ARI.Name = "NumberOrder_ARI";
            // 
            // Address_ARI
            // 
            this.Address_ARI.HeaderText = "Адрес";
            this.Address_ARI.Name = "Address_ARI";
            // 
            // AccountNumber_ARI
            // 
            this.AccountNumber_ARI.HeaderText = "Номер счета";
            this.AccountNumber_ARI.MaxInputLength = 5;
            this.AccountNumber_ARI.Name = "AccountNumber_ARI";
            // 
            // PhoneNumber_ARI
            // 
            this.PhoneNumber_ARI.HeaderText = "Номер телефона";
            this.PhoneNumber_ARI.MaxInputLength = 11;
            this.PhoneNumber_ARI.Name = "PhoneNumber_ARI";
            // 
            // FIO_ARI
            // 
            this.FIO_ARI.HeaderText = "ФИО";
            this.FIO_ARI.Name = "FIO_ARI";
            // 
            // dataGridViewOrders_ARI
            // 
            this.dataGridViewOrders_ARI.AllowUserToAddRows = false;
            this.dataGridViewOrders_ARI.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrders_ARI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders_ARI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FIO_ARI,
            this.PhoneNumber_ARI,
            this.AccountNumber_ARI,
            this.Address_ARI,
            this.NumberOrder_ARI,
            this.PriceOrder_ARI});
            this.dataGridViewOrders_ARI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOrders_ARI.Location = new System.Drawing.Point(186, 56);
            this.dataGridViewOrders_ARI.Name = "dataGridViewOrders_ARI";
            this.dataGridViewOrders_ARI.RowHeadersVisible = false;
            this.dataGridViewOrders_ARI.Size = new System.Drawing.Size(545, 482);
            this.dataGridViewOrders_ARI.TabIndex = 0;
            // 
            // ToolStripMenuItemHelp_ARI
            // 
            this.ToolStripMenuItemHelp_ARI.Name = "ToolStripMenuItemHelp_ARI";
            this.ToolStripMenuItemHelp_ARI.Size = new System.Drawing.Size(68, 20);
            this.ToolStripMenuItemHelp_ARI.Text = "Помощь";
            this.ToolStripMenuItemHelp_ARI.Click += new System.EventHandler(this.ToolStripMenuItemHelp_ARI_Click);
            // 
            // ToolStripMenuItemInfo_ARI
            // 
            this.ToolStripMenuItemInfo_ARI.Name = "ToolStripMenuItemInfo_ARI";
            this.ToolStripMenuItemInfo_ARI.Size = new System.Drawing.Size(94, 20);
            this.ToolStripMenuItemInfo_ARI.Text = "О программе";
            this.ToolStripMenuItemInfo_ARI.Click += new System.EventHandler(this.ToolStripMenuItemInfo_ARI_Click);
            // 
            // buttonGraphic_ARI
            // 
            this.buttonGraphic_ARI.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonGraphic_ARI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGraphic_ARI.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonGraphic_ARI.Location = new System.Drawing.Point(0, 27);
            this.buttonGraphic_ARI.Name = "buttonGraphic_ARI";
            this.buttonGraphic_ARI.Size = new System.Drawing.Size(186, 58);
            this.buttonGraphic_ARI.TabIndex = 9;
            this.buttonGraphic_ARI.Text = "График";
            this.buttonGraphic_ARI.UseVisualStyleBackColor = true;
            this.buttonGraphic_ARI.Click += new System.EventHandler(this.buttonAddRows_ARI_ARI_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 538);
            this.Controls.Add(this.dataGridViewOrders_ARI);
            this.Controls.Add(this.panelLeftMenu_ARI);
            this.Controls.Add(this.panelUp_ARI);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказы";
            this.panelUp_ARI.ResumeLayout(false);
            this.panelUp_ARI.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelLeftMenu_ARI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders_ARI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelUp_ARI;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panelLeftMenu_ARI;
        private System.Windows.Forms.Button buttonAddRows_ARI_ARI;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpen_ARI;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.Button buttonDelRows_ARI;
        private System.Windows.Forms.OpenFileDialog openFileDialog_ARI;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceOrder_ARI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOrder_ARI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address_ARI;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountNumber_ARI;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber_ARI;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO_ARI;
        private System.Windows.Forms.DataGridView dataGridViewOrders_ARI;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_ARI;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemHelp_ARI;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemInfo_ARI;
        private System.Windows.Forms.Button buttonGraphic_ARI;
    }
}