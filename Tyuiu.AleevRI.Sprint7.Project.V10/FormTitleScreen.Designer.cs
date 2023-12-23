
namespace Tyuiu.AleevRI.Sprint7.Project.V10
{
    partial class FormTitleScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTitleScreen));
            this.buttonToMainForm_ARI = new System.Windows.Forms.Button();
            this.buttonHelp_ARI = new System.Windows.Forms.Button();
            this.buttonAbout_ARI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonToMainForm_ARI
            // 
            this.buttonToMainForm_ARI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToMainForm_ARI.Location = new System.Drawing.Point(99, 45);
            this.buttonToMainForm_ARI.Name = "buttonToMainForm_ARI";
            this.buttonToMainForm_ARI.Size = new System.Drawing.Size(145, 51);
            this.buttonToMainForm_ARI.TabIndex = 0;
            this.buttonToMainForm_ARI.Text = "Перейти в приложение";
            this.buttonToMainForm_ARI.UseVisualStyleBackColor = true;
            this.buttonToMainForm_ARI.Click += new System.EventHandler(this.buttonToMainForm_ARI_Click);
            // 
            // buttonHelp_ARI
            // 
            this.buttonHelp_ARI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_ARI.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_ARI.Image")));
            this.buttonHelp_ARI.Location = new System.Drawing.Point(12, 141);
            this.buttonHelp_ARI.Name = "buttonHelp_ARI";
            this.buttonHelp_ARI.Size = new System.Drawing.Size(54, 54);
            this.buttonHelp_ARI.TabIndex = 1;
            this.buttonHelp_ARI.UseVisualStyleBackColor = true;
            this.buttonHelp_ARI.Click += new System.EventHandler(this.buttonHelp_ARI_Click);
            // 
            // buttonAbout_ARI
            // 
            this.buttonAbout_ARI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbout_ARI.Image = ((System.Drawing.Image)(resources.GetObject("buttonAbout_ARI.Image")));
            this.buttonAbout_ARI.Location = new System.Drawing.Point(275, 141);
            this.buttonAbout_ARI.Name = "buttonAbout_ARI";
            this.buttonAbout_ARI.Size = new System.Drawing.Size(54, 54);
            this.buttonAbout_ARI.TabIndex = 1;
            this.buttonAbout_ARI.UseVisualStyleBackColor = true;
            this.buttonAbout_ARI.Click += new System.EventHandler(this.buttonAbout_ARI_Click);
            // 
            // FormTitleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 207);
            this.Controls.Add(this.buttonAbout_ARI);
            this.Controls.Add(this.buttonHelp_ARI);
            this.Controls.Add(this.buttonToMainForm_ARI);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTitleScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonToMainForm_ARI;
        private System.Windows.Forms.Button buttonHelp_ARI;
        private System.Windows.Forms.Button buttonAbout_ARI;
    }
}