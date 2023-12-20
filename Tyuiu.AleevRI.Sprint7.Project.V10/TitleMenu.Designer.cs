
namespace Tyuiu.AleevRI.Sprint7.Project.V10
{
    partial class TitleMenu
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
            this.buttonLogIn_ARI = new System.Windows.Forms.Button();
            this.buttonEditData_ARI = new System.Windows.Forms.Button();
            this.buttonCar_ARI = new System.Windows.Forms.Button();
            this.panelUpMenu_ARI = new System.Windows.Forms.Panel();
            this.panelLeftMenu_ARI.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeftMenu_ARI
            // 
            this.panelLeftMenu_ARI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.panelLeftMenu_ARI.Controls.Add(this.buttonLogIn_ARI);
            this.panelLeftMenu_ARI.Controls.Add(this.buttonEditData_ARI);
            this.panelLeftMenu_ARI.Controls.Add(this.buttonCar_ARI);
            this.panelLeftMenu_ARI.Controls.Add(this.panelUpMenu_ARI);
            this.panelLeftMenu_ARI.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftMenu_ARI.Location = new System.Drawing.Point(0, 0);
            this.panelLeftMenu_ARI.Name = "panelLeftMenu_ARI";
            this.panelLeftMenu_ARI.Size = new System.Drawing.Size(186, 538);
            this.panelLeftMenu_ARI.TabIndex = 1;
            // 
            // buttonLogIn_ARI
            // 
            this.buttonLogIn_ARI.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLogIn_ARI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogIn_ARI.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonLogIn_ARI.Location = new System.Drawing.Point(0, 274);
            this.buttonLogIn_ARI.Name = "buttonLogIn_ARI";
            this.buttonLogIn_ARI.Size = new System.Drawing.Size(186, 58);
            this.buttonLogIn_ARI.TabIndex = 5;
            this.buttonLogIn_ARI.Text = "Авторизация";
            this.buttonLogIn_ARI.UseVisualStyleBackColor = true;
            // 
            // buttonEditData_ARI
            // 
            this.buttonEditData_ARI.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEditData_ARI.Enabled = false;
            this.buttonEditData_ARI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditData_ARI.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonEditData_ARI.Location = new System.Drawing.Point(0, 216);
            this.buttonEditData_ARI.Name = "buttonEditData_ARI";
            this.buttonEditData_ARI.Size = new System.Drawing.Size(186, 58);
            this.buttonEditData_ARI.TabIndex = 4;
            this.buttonEditData_ARI.UseVisualStyleBackColor = true;
            // 
            // buttonCar_ARI
            // 
            this.buttonCar_ARI.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCar_ARI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCar_ARI.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCar_ARI.Location = new System.Drawing.Point(0, 158);
            this.buttonCar_ARI.Name = "buttonCar_ARI";
            this.buttonCar_ARI.Size = new System.Drawing.Size(186, 58);
            this.buttonCar_ARI.TabIndex = 3;
            this.buttonCar_ARI.Text = "Регистрация";
            this.buttonCar_ARI.UseVisualStyleBackColor = true;
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
            // TitleMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 538);
            this.Controls.Add(this.panelLeftMenu_ARI);
            this.Name = "TitleMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TitleMenu";
            this.panelLeftMenu_ARI.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeftMenu_ARI;
        private System.Windows.Forms.Button buttonLogIn_ARI;
        private System.Windows.Forms.Button buttonEditData_ARI;
        private System.Windows.Forms.Button buttonCar_ARI;
        private System.Windows.Forms.Panel panelUpMenu_ARI;
    }
}