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
            this.rentalListBox = new System.Windows.Forms.ListBox();
            this.cartesian = new LiveCharts.WinForms.CartesianChart();
            this.pie = new LiveCharts.WinForms.PieChart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rentalListBox
            // 
            this.rentalListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.rentalListBox.FormattingEnabled = true;
            this.rentalListBox.Location = new System.Drawing.Point(0, 0);
            this.rentalListBox.Name = "rentalListBox";
            this.rentalListBox.Size = new System.Drawing.Size(120, 459);
            this.rentalListBox.TabIndex = 2;
            // 
            // cartesian
            // 
            this.cartesian.Dock = System.Windows.Forms.DockStyle.Left;
            this.cartesian.Location = new System.Drawing.Point(120, 0);
            this.cartesian.Name = "cartesian";
            this.cartesian.Size = new System.Drawing.Size(462, 459);
            this.cartesian.TabIndex = 3;
            this.cartesian.Text = "cartesianChart1";
            // 
            // pie
            // 
            this.pie.Dock = System.Windows.Forms.DockStyle.Right;
            this.pie.Location = new System.Drawing.Point(6, 0);
            this.pie.Name = "pie";
            this.pie.Size = new System.Drawing.Size(206, 459);
            this.pie.TabIndex = 0;
            this.pie.Text = "pieChart1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pie);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(585, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 459);
            this.panel1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 459);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cartesian);
            this.Controls.Add(this.rentalListBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox rentalListBox;
        private LiveCharts.WinForms.CartesianChart cartesian;
        private LiveCharts.WinForms.PieChart pie;
        private System.Windows.Forms.Panel panel1;
    }
}

