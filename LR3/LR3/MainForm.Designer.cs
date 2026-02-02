namespace LR3
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
            this.CategoriesListBox = new System.Windows.Forms.ListBox();
            this.DrugsComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CategoriesListBox
            // 
            this.CategoriesListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.CategoriesListBox.FormattingEnabled = true;
            this.CategoriesListBox.Location = new System.Drawing.Point(0, 0);
            this.CategoriesListBox.Name = "CategoriesListBox";
            this.CategoriesListBox.Size = new System.Drawing.Size(120, 450);
            this.CategoriesListBox.TabIndex = 0;
            this.CategoriesListBox.SelectedIndexChanged += new System.EventHandler(this.CategoriesListBox_SelectedIndexChanged);
            // 
            // DrugsComboBox
            // 
            this.DrugsComboBox.FormattingEnabled = true;
            this.DrugsComboBox.Location = new System.Drawing.Point(141, 13);
            this.DrugsComboBox.Name = "DrugsComboBox";
            this.DrugsComboBox.Size = new System.Drawing.Size(192, 21);
            this.DrugsComboBox.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DrugsComboBox);
            this.Controls.Add(this.CategoriesListBox);
            this.Name = "MainForm";
            this.Text = "Кувалдаев_вариант4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox CategoriesListBox;
        private System.Windows.Forms.ComboBox DrugsComboBox;
    }
}

