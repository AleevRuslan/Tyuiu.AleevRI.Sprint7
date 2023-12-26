
namespace Tyuiu.AleevRI.Sprint7.Project.V10
{
    partial class FormGraph
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.saveFileDialog_ARI = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog_ARI = new System.Windows.Forms.OpenFileDialog();
            this.buttonBack_ARI = new System.Windows.Forms.Button();
            this.buttonGraphic_ARI = new System.Windows.Forms.Button();
            this.panelLeftMenu_ARI = new System.Windows.Forms.Panel();
            this.panelUp_ARI = new System.Windows.Forms.Panel();
            this.chartPrice_ARI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelLeftMenu_ARI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPrice_ARI)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog_ARI
            // 
            this.openFileDialog_ARI.FileName = "openFileDialog1";
            // 
            // buttonBack_ARI
            // 
            this.buttonBack_ARI.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonBack_ARI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack_ARI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack_ARI.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonBack_ARI.Location = new System.Drawing.Point(0, 327);
            this.buttonBack_ARI.Name = "buttonBack_ARI";
            this.buttonBack_ARI.Size = new System.Drawing.Size(186, 58);
            this.buttonBack_ARI.TabIndex = 9;
            this.buttonBack_ARI.Text = "Назад";
            this.buttonBack_ARI.UseVisualStyleBackColor = true;
            this.buttonBack_ARI.Click += new System.EventHandler(this.buttonBack_ARI_Click);
            // 
            // buttonGraphic_ARI
            // 
            this.buttonGraphic_ARI.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonGraphic_ARI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGraphic_ARI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGraphic_ARI.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonGraphic_ARI.Location = new System.Drawing.Point(0, 83);
            this.buttonGraphic_ARI.Name = "buttonGraphic_ARI";
            this.buttonGraphic_ARI.Size = new System.Drawing.Size(186, 58);
            this.buttonGraphic_ARI.TabIndex = 9;
            this.buttonGraphic_ARI.Text = "Построить график";
            this.buttonGraphic_ARI.UseVisualStyleBackColor = true;
            this.buttonGraphic_ARI.Click += new System.EventHandler(this.buttonGraphic_ARI_Click);
            // 
            // panelLeftMenu_ARI
            // 
            this.panelLeftMenu_ARI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.panelLeftMenu_ARI.Controls.Add(this.buttonBack_ARI);
            this.panelLeftMenu_ARI.Controls.Add(this.buttonGraphic_ARI);
            this.panelLeftMenu_ARI.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftMenu_ARI.Location = new System.Drawing.Point(0, 56);
            this.panelLeftMenu_ARI.Name = "panelLeftMenu_ARI";
            this.panelLeftMenu_ARI.Size = new System.Drawing.Size(186, 449);
            this.panelLeftMenu_ARI.TabIndex = 7;
            // 
            // panelUp_ARI
            // 
            this.panelUp_ARI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.panelUp_ARI.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp_ARI.Location = new System.Drawing.Point(0, 0);
            this.panelUp_ARI.Name = "panelUp_ARI";
            this.panelUp_ARI.Size = new System.Drawing.Size(960, 56);
            this.panelUp_ARI.TabIndex = 6;
            // 
            // chartPrice_ARI
            // 
            chartArea2.AxisX.Title = "Клиенты";
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea2.AxisY.Title = "Стоимость";
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea2.Name = "ChartArea1";
            this.chartPrice_ARI.ChartAreas.Add(chartArea2);
            this.chartPrice_ARI.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chartPrice_ARI.Legends.Add(legend2);
            this.chartPrice_ARI.Location = new System.Drawing.Point(186, 56);
            this.chartPrice_ARI.Name = "chartPrice_ARI";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Стоимость";
            series2.YValuesPerPoint = 4;
            this.chartPrice_ARI.Series.Add(series2);
            this.chartPrice_ARI.Size = new System.Drawing.Size(774, 449);
            this.chartPrice_ARI.TabIndex = 8;
            this.chartPrice_ARI.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title2.Name = "Title1";
            title2.Text = "Диаграмма стоимостей заказов";
            this.chartPrice_ARI.Titles.Add(title2);
            // 
            // FormGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 505);
            this.Controls.Add(this.chartPrice_ARI);
            this.Controls.Add(this.panelLeftMenu_ARI);
            this.Controls.Add(this.panelUp_ARI);
            this.MinimumSize = new System.Drawing.Size(976, 544);
            this.Name = "FormGraph";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelLeftMenu_ARI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartPrice_ARI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog_ARI;
        private System.Windows.Forms.OpenFileDialog openFileDialog_ARI;
        private System.Windows.Forms.Button buttonBack_ARI;
        private System.Windows.Forms.Button buttonGraphic_ARI;
        private System.Windows.Forms.Panel panelLeftMenu_ARI;
        private System.Windows.Forms.Panel panelUp_ARI;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPrice_ARI;
    }
}