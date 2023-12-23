
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
            this.panelLeftMenu_ARI = new System.Windows.Forms.Panel();
            this.buttonAddRows_ARI_ARI = new System.Windows.Forms.Button();
            this.buttonSaveFile_ARI = new System.Windows.Forms.Button();
            this.buttonOpenFile_ARI = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonDelRows_ARI = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FIO_ARI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelUp_ARI.SuspendLayout();
            this.panelLeftMenu_ARI.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUp_ARI
            // 
            this.panelUp_ARI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.panelUp_ARI.Controls.Add(this.menuStrip1);
            this.panelUp_ARI.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp_ARI.Location = new System.Drawing.Point(0, 0);
            this.panelUp_ARI.Name = "panelUp_ARI";
            this.panelUp_ARI.Size = new System.Drawing.Size(755, 56);
            this.panelUp_ARI.TabIndex = 3;
            // 
            // panelLeftMenu_ARI
            // 
            this.panelLeftMenu_ARI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.panelLeftMenu_ARI.Controls.Add(this.buttonDelRows_ARI);
            this.panelLeftMenu_ARI.Controls.Add(this.buttonAddRows_ARI_ARI);
            this.panelLeftMenu_ARI.Controls.Add(this.buttonSaveFile_ARI);
            this.panelLeftMenu_ARI.Controls.Add(this.buttonOpenFile_ARI);
            this.panelLeftMenu_ARI.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftMenu_ARI.Location = new System.Drawing.Point(0, 56);
            this.panelLeftMenu_ARI.Name = "panelLeftMenu_ARI";
            this.panelLeftMenu_ARI.Size = new System.Drawing.Size(186, 482);
            this.panelLeftMenu_ARI.TabIndex = 4;
            // 
            // buttonAddRows_ARI_ARI
            // 
            this.buttonAddRows_ARI_ARI.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonAddRows_ARI_ARI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddRows_ARI_ARI.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAddRows_ARI_ARI.Location = new System.Drawing.Point(0, 296);
            this.buttonAddRows_ARI_ARI.Name = "buttonAddRows_ARI_ARI";
            this.buttonAddRows_ARI_ARI.Size = new System.Drawing.Size(186, 58);
            this.buttonAddRows_ARI_ARI.TabIndex = 9;
            this.buttonAddRows_ARI_ARI.Text = "Добавить строку";
            this.buttonAddRows_ARI_ARI.UseVisualStyleBackColor = true;
            // 
            // buttonSaveFile_ARI
            // 
            this.buttonSaveFile_ARI.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonSaveFile_ARI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveFile_ARI.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSaveFile_ARI.Location = new System.Drawing.Point(0, 207);
            this.buttonSaveFile_ARI.Name = "buttonSaveFile_ARI";
            this.buttonSaveFile_ARI.Size = new System.Drawing.Size(186, 58);
            this.buttonSaveFile_ARI.TabIndex = 8;
            this.buttonSaveFile_ARI.Text = "Сохранить файл";
            this.buttonSaveFile_ARI.UseVisualStyleBackColor = true;
            // 
            // buttonOpenFile_ARI
            // 
            this.buttonOpenFile_ARI.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonOpenFile_ARI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile_ARI.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonOpenFile_ARI.Location = new System.Drawing.Point(0, 117);
            this.buttonOpenFile_ARI.Name = "buttonOpenFile_ARI";
            this.buttonOpenFile_ARI.Size = new System.Drawing.Size(186, 58);
            this.buttonOpenFile_ARI.TabIndex = 7;
            this.buttonOpenFile_ARI.Text = "Открыть файл";
            this.buttonOpenFile_ARI.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(755, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // buttonDelRows_ARI
            // 
            this.buttonDelRows_ARI.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonDelRows_ARI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelRows_ARI.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonDelRows_ARI.Location = new System.Drawing.Point(0, 379);
            this.buttonDelRows_ARI.Name = "buttonDelRows_ARI";
            this.buttonDelRows_ARI.Size = new System.Drawing.Size(186, 58);
            this.buttonDelRows_ARI.TabIndex = 9;
            this.buttonDelRows_ARI.Text = "Удалить строку";
            this.buttonDelRows_ARI.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FIO_ARI,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(186, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(569, 482);
            this.dataGridView1.TabIndex = 5;
            // 
            // FIO_ARI
            // 
            this.FIO_ARI.HeaderText = "ФИО";
            this.FIO_ARI.Name = "FIO_ARI";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Номер счета";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Адрес";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Номер заказа";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 538);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelLeftMenu_ARI);
            this.Controls.Add(this.panelUp_ARI);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelUp_ARI.ResumeLayout(false);
            this.panelUp_ARI.PerformLayout();
            this.panelLeftMenu_ARI.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelUp_ARI;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panelLeftMenu_ARI;
        private System.Windows.Forms.Button buttonAddRows_ARI_ARI;
        private System.Windows.Forms.Button buttonSaveFile_ARI;
        private System.Windows.Forms.Button buttonOpenFile_ARI;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.Button buttonDelRows_ARI;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO_ARI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}