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
            this.OrderButton = new System.Windows.Forms.Button();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.QuantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.GroupComboBox = new System.Windows.Forms.ComboBox();
            this.ImagePictureBox = new System.Windows.Forms.PictureBox();
            this.DrugListBox = new System.Windows.Forms.ListBox();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.ExpiryDateLabel = new System.Windows.Forms.Label();
            this.SupplierLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderButton
            // 
            this.OrderButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderButton.Location = new System.Drawing.Point(619, 372);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(169, 40);
            this.OrderButton.TabIndex = 0;
            this.OrderButton.Text = "Заказать";
            this.OrderButton.UseVisualStyleBackColor = true;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceLabel.Location = new System.Drawing.Point(333, 19);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(45, 19);
            this.PriceLabel.TabIndex = 1;
            this.PriceLabel.Text = "label1";
            // 
            // QuantityNumericUpDown
            // 
            this.QuantityNumericUpDown.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuantityNumericUpDown.Location = new System.Drawing.Point(619, 330);
            this.QuantityNumericUpDown.Name = "QuantityNumericUpDown";
            this.QuantityNumericUpDown.Size = new System.Drawing.Size(169, 26);
            this.QuantityNumericUpDown.TabIndex = 2;
            // 
            // GroupComboBox
            // 
            this.GroupComboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupComboBox.FormattingEnabled = true;
            this.GroupComboBox.Location = new System.Drawing.Point(29, 12);
            this.GroupComboBox.Name = "GroupComboBox";
            this.GroupComboBox.Size = new System.Drawing.Size(232, 27);
            this.GroupComboBox.TabIndex = 3;
            // 
            // ImagePictureBox
            // 
            this.ImagePictureBox.Location = new System.Drawing.Point(564, 12);
            this.ImagePictureBox.Name = "ImagePictureBox";
            this.ImagePictureBox.Size = new System.Drawing.Size(224, 207);
            this.ImagePictureBox.TabIndex = 4;
            this.ImagePictureBox.TabStop = false;
            // 
            // DrugListBox
            // 
            this.DrugListBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DrugListBox.FormattingEnabled = true;
            this.DrugListBox.ItemHeight = 19;
            this.DrugListBox.Location = new System.Drawing.Point(29, 47);
            this.DrugListBox.Name = "DrugListBox";
            this.DrugListBox.Size = new System.Drawing.Size(232, 365);
            this.DrugListBox.TabIndex = 5;
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ManufacturerLabel.Location = new System.Drawing.Point(334, 61);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(45, 19);
            this.ManufacturerLabel.TabIndex = 6;
            this.ManufacturerLabel.Text = "label2";
            // 
            // ExpiryDateLabel
            // 
            this.ExpiryDateLabel.AutoSize = true;
            this.ExpiryDateLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExpiryDateLabel.Location = new System.Drawing.Point(334, 102);
            this.ExpiryDateLabel.Name = "ExpiryDateLabel";
            this.ExpiryDateLabel.Size = new System.Drawing.Size(45, 19);
            this.ExpiryDateLabel.TabIndex = 7;
            this.ExpiryDateLabel.Text = "label3";
            // 
            // SupplierLabel
            // 
            this.SupplierLabel.AutoSize = true;
            this.SupplierLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SupplierLabel.Location = new System.Drawing.Point(334, 142);
            this.SupplierLabel.Name = "SupplierLabel";
            this.SupplierLabel.Size = new System.Drawing.Size(45, 19);
            this.SupplierLabel.TabIndex = 8;
            this.SupplierLabel.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SupplierLabel);
            this.Controls.Add(this.ExpiryDateLabel);
            this.Controls.Add(this.ManufacturerLabel);
            this.Controls.Add(this.DrugListBox);
            this.Controls.Add(this.ImagePictureBox);
            this.Controls.Add(this.GroupComboBox);
            this.Controls.Add(this.QuantityNumericUpDown);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.OrderButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.NumericUpDown QuantityNumericUpDown;
        private System.Windows.Forms.ComboBox GroupComboBox;
        private System.Windows.Forms.PictureBox ImagePictureBox;
        private System.Windows.Forms.ListBox DrugListBox;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label ExpiryDateLabel;
        private System.Windows.Forms.Label SupplierLabel;
    }
}

