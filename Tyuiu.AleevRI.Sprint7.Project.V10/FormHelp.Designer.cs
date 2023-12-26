
namespace Tyuiu.AleevRI.Sprint7.Project.V10
{
    partial class FormHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelp));
            this.buttonBack_ARI = new System.Windows.Forms.Button();
            this.labelInfo_ARI = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBack_ARI
            // 
            this.buttonBack_ARI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBack_ARI.Location = new System.Drawing.Point(425, 199);
            this.buttonBack_ARI.Name = "buttonBack_ARI";
            this.buttonBack_ARI.Size = new System.Drawing.Size(75, 23);
            this.buttonBack_ARI.TabIndex = 3;
            this.buttonBack_ARI.Text = "Назад";
            this.buttonBack_ARI.UseVisualStyleBackColor = true;
            this.buttonBack_ARI.Click += new System.EventHandler(this.buttonBack_ARI_Click);
            // 
            // labelInfo_ARI
            // 
            this.labelInfo_ARI.AutoSize = true;
            this.labelInfo_ARI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo_ARI.Location = new System.Drawing.Point(12, 48);
            this.labelInfo_ARI.Name = "labelInfo_ARI";
            this.labelInfo_ARI.Size = new System.Drawing.Size(506, 112);
            this.labelInfo_ARI.TabIndex = 4;
            this.labelInfo_ARI.Text = resources.GetString("labelInfo_ARI.Text");
            // 
            // FormHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 246);
            this.Controls.Add(this.labelInfo_ARI);
            this.Controls.Add(this.buttonBack_ARI);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(544, 285);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(544, 285);
            this.Name = "FormHelp";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Помощь";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack_ARI;
        private System.Windows.Forms.Label labelInfo_ARI;
    }
}