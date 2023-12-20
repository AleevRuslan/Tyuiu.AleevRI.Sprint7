
namespace Tyuiu.AleevRI.Sprint7.Project.V10
{
    partial class FormAddOrder
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
            this.panelUpMenu_ARI = new System.Windows.Forms.Panel();
            this.buttonBack_ARI = new System.Windows.Forms.Button();
            this.panelLeftMenu_ARI.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeftMenu_ARI
            // 
            this.panelLeftMenu_ARI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.panelLeftMenu_ARI.Controls.Add(this.buttonBack_ARI);
            this.panelLeftMenu_ARI.Controls.Add(this.panelUpMenu_ARI);
            this.panelLeftMenu_ARI.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftMenu_ARI.Location = new System.Drawing.Point(0, 0);
            this.panelLeftMenu_ARI.Name = "panelLeftMenu_ARI";
            this.panelLeftMenu_ARI.Size = new System.Drawing.Size(186, 538);
            this.panelLeftMenu_ARI.TabIndex = 1;
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
            // buttonBack_ARI
            // 
            this.buttonBack_ARI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack_ARI.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonBack_ARI.Location = new System.Drawing.Point(0, 427);
            this.buttonBack_ARI.Name = "buttonBack_ARI";
            this.buttonBack_ARI.Size = new System.Drawing.Size(186, 58);
            this.buttonBack_ARI.TabIndex = 10;
            this.buttonBack_ARI.Text = "Назад";
            this.buttonBack_ARI.UseVisualStyleBackColor = true;
            this.buttonBack_ARI.Click += new System.EventHandler(this.buttonBack_ARI_Click);
            // 
            // FormAddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 538);
            this.Controls.Add(this.panelLeftMenu_ARI);
            this.Name = "FormAddOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить заказ";
            this.panelLeftMenu_ARI.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeftMenu_ARI;
        private System.Windows.Forms.Panel panelUpMenu_ARI;
        private System.Windows.Forms.Button buttonBack_ARI;
    }
}