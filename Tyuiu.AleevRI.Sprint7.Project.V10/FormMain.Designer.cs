
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
            this.panelLeftMenu_ARI = new System.Windows.Forms.Panel();
            this.buttonDeleteOrder_ARI_ARI = new System.Windows.Forms.Button();
            this.buttonEditOrder_ARI = new System.Windows.Forms.Button();
            this.buttonAddOrder_ARI = new System.Windows.Forms.Button();
            this.panelUpMenu_ARI = new System.Windows.Forms.Panel();
            this.panelLeftMenu_ARI.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeftMenu_ARI
            // 
            this.panelLeftMenu_ARI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.panelLeftMenu_ARI.Controls.Add(this.buttonDeleteOrder_ARI_ARI);
            this.panelLeftMenu_ARI.Controls.Add(this.buttonEditOrder_ARI);
            this.panelLeftMenu_ARI.Controls.Add(this.buttonAddOrder_ARI);
            this.panelLeftMenu_ARI.Controls.Add(this.panelUpMenu_ARI);
            this.panelLeftMenu_ARI.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftMenu_ARI.Location = new System.Drawing.Point(0, 0);
            this.panelLeftMenu_ARI.Name = "panelLeftMenu_ARI";
            this.panelLeftMenu_ARI.Size = new System.Drawing.Size(186, 538);
            this.panelLeftMenu_ARI.TabIndex = 2;
            // 
            // buttonDeleteOrder_ARI_ARI
            // 
            this.buttonDeleteOrder_ARI_ARI.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDeleteOrder_ARI_ARI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteOrder_ARI_ARI.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonDeleteOrder_ARI_ARI.Location = new System.Drawing.Point(0, 274);
            this.buttonDeleteOrder_ARI_ARI.Name = "buttonDeleteOrder_ARI_ARI";
            this.buttonDeleteOrder_ARI_ARI.Size = new System.Drawing.Size(186, 58);
            this.buttonDeleteOrder_ARI_ARI.TabIndex = 9;
            this.buttonDeleteOrder_ARI_ARI.Text = "Удалить заказ";
            this.buttonDeleteOrder_ARI_ARI.UseVisualStyleBackColor = true;
            // 
            // buttonEditOrder_ARI
            // 
            this.buttonEditOrder_ARI.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEditOrder_ARI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditOrder_ARI.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonEditOrder_ARI.Location = new System.Drawing.Point(0, 216);
            this.buttonEditOrder_ARI.Name = "buttonEditOrder_ARI";
            this.buttonEditOrder_ARI.Size = new System.Drawing.Size(186, 58);
            this.buttonEditOrder_ARI.TabIndex = 8;
            this.buttonEditOrder_ARI.Text = "Редактировать заказ";
            this.buttonEditOrder_ARI.UseVisualStyleBackColor = true;
            this.buttonEditOrder_ARI.Click += new System.EventHandler(this.buttonEditOrder_ARI_Click);
            // 
            // buttonAddOrder_ARI
            // 
            this.buttonAddOrder_ARI.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddOrder_ARI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddOrder_ARI.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonAddOrder_ARI.Location = new System.Drawing.Point(0, 158);
            this.buttonAddOrder_ARI.Name = "buttonAddOrder_ARI";
            this.buttonAddOrder_ARI.Size = new System.Drawing.Size(186, 58);
            this.buttonAddOrder_ARI.TabIndex = 7;
            this.buttonAddOrder_ARI.Text = "Добавить заказ";
            this.buttonAddOrder_ARI.UseVisualStyleBackColor = true;
            this.buttonAddOrder_ARI.Click += new System.EventHandler(this.buttonAddOrder_ARI_Click);
            // 
            // panelUpMenu_ARI
            // 
            this.panelUpMenu_ARI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.panelUpMenu_ARI.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUpMenu_ARI.Location = new System.Drawing.Point(0, 0);
            this.panelUpMenu_ARI.Name = "panelUpMenu_ARI";
            this.panelUpMenu_ARI.Size = new System.Drawing.Size(186, 158);
            this.panelUpMenu_ARI.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 538);
            this.Controls.Add(this.panelLeftMenu_ARI);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.panelLeftMenu_ARI.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeftMenu_ARI;
        private System.Windows.Forms.Panel panelUpMenu_ARI;
        private System.Windows.Forms.Button buttonDeleteOrder_ARI_ARI;
        private System.Windows.Forms.Button buttonEditOrder_ARI;
        private System.Windows.Forms.Button buttonAddOrder_ARI;
    }
}