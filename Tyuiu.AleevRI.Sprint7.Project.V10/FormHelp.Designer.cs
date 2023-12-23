
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
            this.buttonBack_ARI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBack_ARI
            // 
            this.buttonBack_ARI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBack_ARI.Location = new System.Drawing.Point(441, 406);
            this.buttonBack_ARI.Name = "buttonBack_ARI";
            this.buttonBack_ARI.Size = new System.Drawing.Size(75, 23);
            this.buttonBack_ARI.TabIndex = 3;
            this.buttonBack_ARI.Text = "Назад";
            this.buttonBack_ARI.UseVisualStyleBackColor = true;
            this.buttonBack_ARI.Click += new System.EventHandler(this.buttonBack_ARI_Click);
            // 
            // FormHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 450);
            this.Controls.Add(this.buttonBack_ARI);
            this.Name = "FormHelp";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Помощь";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBack_ARI;
    }
}