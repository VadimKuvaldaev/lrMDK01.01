namespace LR3
{
    partial class Form1
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
            this.DrugsComboBox = new System.Windows.Forms.ComboBox();
            this.GroupsListBox = new System.Windows.Forms.ListBox();
            this.DrugPictureBox = new System.Windows.Forms.PictureBox();
            this.DrugInfoLabel = new System.Windows.Forms.Label();
            this.QuantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.OrderButton = new System.Windows.Forms.Button();
            this.OrderTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DrugPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // DrugsComboBox
            // 
            this.DrugsComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DrugsComboBox.FormattingEnabled = true;
            this.DrugsComboBox.Location = new System.Drawing.Point(33, 13);
            this.DrugsComboBox.Name = "DrugsComboBox";
            this.DrugsComboBox.Size = new System.Drawing.Size(223, 27);
            this.DrugsComboBox.TabIndex = 0;
            // 
            // GroupsListBox
            // 
            this.GroupsListBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupsListBox.FormattingEnabled = true;
            this.GroupsListBox.ItemHeight = 19;
            this.GroupsListBox.Location = new System.Drawing.Point(33, 66);
            this.GroupsListBox.Name = "GroupsListBox";
            this.GroupsListBox.Size = new System.Drawing.Size(223, 365);
            this.GroupsListBox.TabIndex = 1;
            // 
            // DrugPictureBox
            // 
            this.DrugPictureBox.Location = new System.Drawing.Point(611, 12);
            this.DrugPictureBox.Name = "DrugPictureBox";
            this.DrugPictureBox.Size = new System.Drawing.Size(177, 164);
            this.DrugPictureBox.TabIndex = 2;
            this.DrugPictureBox.TabStop = false;
            // 
            // DrugInfoLabel
            // 
            this.DrugInfoLabel.AutoSize = true;
            this.DrugInfoLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DrugInfoLabel.Location = new System.Drawing.Point(403, 21);
            this.DrugInfoLabel.Name = "DrugInfoLabel";
            this.DrugInfoLabel.Size = new System.Drawing.Size(97, 19);
            this.DrugInfoLabel.TabIndex = 3;
            this.DrugInfoLabel.Text = "DrugInfoLabel";
            // 
            // QuantityNumericUpDown
            // 
            this.QuantityNumericUpDown.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuantityNumericUpDown.Location = new System.Drawing.Point(668, 272);
            this.QuantityNumericUpDown.Name = "QuantityNumericUpDown";
            this.QuantityNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.QuantityNumericUpDown.TabIndex = 4;
            // 
            // OrderButton
            // 
            this.OrderButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderButton.Location = new System.Drawing.Point(668, 221);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(120, 36);
            this.OrderButton.TabIndex = 5;
            this.OrderButton.Text = "Заказать";
            this.OrderButton.UseVisualStyleBackColor = true;
            // 
            // OrderTextBox
            // 
            this.OrderTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderTextBox.Location = new System.Drawing.Point(668, 308);
            this.OrderTextBox.Name = "OrderTextBox";
            this.OrderTextBox.Size = new System.Drawing.Size(120, 26);
            this.OrderTextBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OrderTextBox);
            this.Controls.Add(this.OrderButton);
            this.Controls.Add(this.QuantityNumericUpDown);
            this.Controls.Add(this.DrugInfoLabel);
            this.Controls.Add(this.DrugPictureBox);
            this.Controls.Add(this.GroupsListBox);
            this.Controls.Add(this.DrugsComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DrugPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DrugsComboBox;
        private System.Windows.Forms.ListBox GroupsListBox;
        private System.Windows.Forms.PictureBox DrugPictureBox;
        private System.Windows.Forms.Label DrugInfoLabel;
        private System.Windows.Forms.NumericUpDown QuantityNumericUpDown;
        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.TextBox OrderTextBox;
    }
}

