using ChartTest.Views;

namespace ChartTest
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ItemsList = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.angular = new LiveCharts.WinForms.AngularGauge();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.cartesian = new ChartTest.Views.SalesCartesianChart();
            this.pie = new ChartTest.Views.SalesPieChart();
            this.solid = new LiveCharts.WinForms.SolidGauge();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rightPanel);
            this.tabPage1.Controls.Add(this.cartesian);
            this.tabPage1.Controls.Add(this.ItemsList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CartesianChart";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ItemsList
            // 
            this.ItemsList.Dock = System.Windows.Forms.DockStyle.Left;
            this.ItemsList.FormattingEnabled = true;
            this.ItemsList.Location = new System.Drawing.Point(3, 3);
            this.ItemsList.Name = "ItemsList";
            this.ItemsList.Size = new System.Drawing.Size(120, 418);
            this.ItemsList.TabIndex = 1;
            this.ItemsList.SelectedIndexChanged += new System.EventHandler(this.ItemsList_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.angular);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "AngularChart";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // angular
            // 
            this.angular.Location = new System.Drawing.Point(3, 3);
            this.angular.Name = "angular";
            this.angular.Size = new System.Drawing.Size(786, 418);
            this.angular.TabIndex = 0;
            this.angular.Text = "angular";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "SolidChart";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.pie);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(792, 424);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "PieChart";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.panel3);
            this.rightPanel.Controls.Add(this.panel2);
            this.rightPanel.Controls.Add(this.panel1);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(603, 3);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(186, 418);
            this.rightPanel.TabIndex = 4;
            // 
            // cartesian
            // 
            this.cartesian.Dock = System.Windows.Forms.DockStyle.Left;
            this.cartesian.Location = new System.Drawing.Point(123, 3);
            this.cartesian.Name = "cartesian";
            this.cartesian.Size = new System.Drawing.Size(478, 418);
            this.cartesian.TabIndex = 0;
            this.cartesian.Text = "cartesian";
            // 
            // pie
            // 
            this.pie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pie.Location = new System.Drawing.Point(0, 0);
            this.pie.Name = "pie";
            this.pie.Size = new System.Drawing.Size(792, 424);
            this.pie.TabIndex = 0;
            this.pie.Text = "pieChart1";
            // 
            // solid
            // 
            this.solid.Location = new System.Drawing.Point(0, 3);
            this.solid.Name = "solid";
            this.solid.Size = new System.Drawing.Size(186, 136);
            this.solid.TabIndex = 0;
            this.solid.Text = "solidGauge1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.solid);
            this.panel1.Location = new System.Drawing.Point(0, 279);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 139);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 128);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(3, 137);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(179, 128);
            this.panel3.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "LiveCharts-диаграммы";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private SalesCartesianChart cartesian;
        private LiveCharts.WinForms.AngularGauge angular;
        private System.Windows.Forms.ListBox ItemsList;
        private System.Windows.Forms.TabPage tabPage4;
        private SalesPieChart pie;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel panel1;
        private LiveCharts.WinForms.SolidGauge solid;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}

