namespace TestFileStorage
{
    partial class RegistrationForm
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
            this.RegButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.RegPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RegLoginTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RegButton
            // 
            this.RegButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegButton.Location = new System.Drawing.Point(15, 93);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(168, 40);
            this.RegButton.TabIndex = 0;
            this.RegButton.Text = "Зарегистрироваться";
            this.RegButton.UseVisualStyleBackColor = true;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Введите пароль:";
            // 
            // RegPasswordTextBox
            // 
            this.RegPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegPasswordTextBox.Location = new System.Drawing.Point(128, 54);
            this.RegPasswordTextBox.Name = "RegPasswordTextBox";
            this.RegPasswordTextBox.Size = new System.Drawing.Size(100, 22);
            this.RegPasswordTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите логин:";
            // 
            // RegLoginTextBox
            // 
            this.RegLoginTextBox.Location = new System.Drawing.Point(128, 24);
            this.RegLoginTextBox.Name = "RegLoginTextBox";
            this.RegLoginTextBox.Size = new System.Drawing.Size(100, 20);
            this.RegLoginTextBox.TabIndex = 7;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 158);
            this.Controls.Add(this.RegLoginTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RegPasswordTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegButton);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RegPasswordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RegLoginTextBox;
    }
}