using LR_Graphics.View;

namespace LR_Graphics
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxItems = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rentalPieChart = new LR_Graphics.View.RentalPieChart();
            this.rentalCartesianChart = new LR_Graphics.View.RentalCartesianChart();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxItems
            // 
            this.listBoxItems.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxItems.FormattingEnabled = true;
            this.listBoxItems.ItemHeight = 18;
            this.listBoxItems.Location = new System.Drawing.Point(0, 0);
            this.listBoxItems.Name = "listBoxItems";
            this.listBoxItems.Size = new System.Drawing.Size(120, 412);
            this.listBoxItems.TabIndex = 0;
            this.listBoxItems.SelectedIndexChanged += new System.EventHandler(this.listBoxItems_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rentalPieChart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(517, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 412);
            this.panel1.TabIndex = 2;
            // 
            // rentalPieChart
            // 
            this.rentalPieChart.Dock = System.Windows.Forms.DockStyle.Right;
            this.rentalPieChart.Location = new System.Drawing.Point(6, 0);
            this.rentalPieChart.Name = "rentalPieChart";
            this.rentalPieChart.Size = new System.Drawing.Size(267, 412);
            this.rentalPieChart.TabIndex = 0;
            this.rentalPieChart.Text = "pieChart1";
            // 
            // rentalCartesianChart
            // 
            this.rentalCartesianChart.Dock = System.Windows.Forms.DockStyle.Left;
            this.rentalCartesianChart.Location = new System.Drawing.Point(120, 0);
            this.rentalCartesianChart.Name = "rentalCartesianChart";
            this.rentalCartesianChart.Size = new System.Drawing.Size(401, 412);
            this.rentalCartesianChart.TabIndex = 1;
            this.rentalCartesianChart.Text = "cartesianChart1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 412);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rentalCartesianChart);
            this.Controls.Add(this.listBoxItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Аренда спорт инвентаря";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxItems;
        private LR_Graphics.View.RentalCartesianChart rentalCartesianChart;
        private System.Windows.Forms.Panel panel1;
        private RentalPieChart rentalPieChart;
    }
}

