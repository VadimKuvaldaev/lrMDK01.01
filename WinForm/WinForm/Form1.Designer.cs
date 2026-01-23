using System;

namespace WinForm
{
    partial class MainForms
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public EventHandler MainForm_Load { get; private set; }

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
            this.panel1 = new System.Windows.Forms.Panel();
            this.studentListBox = new System.Windows.Forms.ListBox();
            this.picture = new System.Windows.Forms.PictureBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.avgLabel = new System.Windows.Forms.Label();
            this.ticketnumberLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            this.panel1.Controls.Add(this.ticketnumberLabel);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ticketnumberLabel);
            this.panel1.Controls.Add(this.avgLabel);
            this.panel1.Controls.Add(this.ageLabel);
            this.panel1.Controls.Add(this.picture);
            this.panel1.Location = new System.Drawing.Point(338, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 451);
            this.panel1.TabIndex = 0;
            // 
            // studentListBox
            // 
            this.studentListBox.FormattingEnabled = true;
            this.studentListBox.Location = new System.Drawing.Point(-4, 0);
            this.studentListBox.Name = "studentListBox";
            this.studentListBox.Size = new System.Drawing.Size(345, 459);
            this.studentListBox.TabIndex = 1;
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(27, 12);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(154, 155);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(27, 192);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(26, 13);
            this.ageLabel.TabIndex = 1;
            this.ageLabel.Text = "Age";
            // 
            // avgLabel
            // 
            this.avgLabel.AutoSize = true;
            this.avgLabel.Location = new System.Drawing.Point(27, 221);
            this.avgLabel.Name = "avgLabel";
            this.avgLabel.Size = new System.Drawing.Size(26, 13);
            this.avgLabel.TabIndex = 2;
            this.avgLabel.Text = "Avg";
            // 
            // ticketnumberLabel
            // 
            this.ticketnumberLabel.AutoSize = true;
            this.ticketnumberLabel.Location = new System.Drawing.Point(27, 251);
            this.ticketnumberLabel.Name = "ticketnumberLabel";
            this.ticketnumberLabel.Size = new System.Drawing.Size(74, 13);
            this.ticketnumberLabel.TabIndex = 3;
            this.ticketnumberLabel.Text = "TicketNumber";
            // 
            // MainForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.studentListBox);
            this.Controls.Add(this.panel1);
            this.Name = "MainForms";
            this.Text = "MainForms";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox studentListBox;
        private System.Windows.Forms.Label ticketnumberLabel;
        private System.Windows.Forms.Label avgLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.PictureBox picture;
    }
}

