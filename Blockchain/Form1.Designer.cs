namespace Blockchain
{
    partial class MainWindow
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
            this.addBlockBtn = new System.Windows.Forms.Button();
            this.inputDataBox = new System.Windows.Forms.TextBox();
            this.outputDataListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // addBlockBtn
            // 
            this.addBlockBtn.Location = new System.Drawing.Point(12, 38);
            this.addBlockBtn.Name = "addBlockBtn";
            this.addBlockBtn.Size = new System.Drawing.Size(776, 36);
            this.addBlockBtn.TabIndex = 0;
            this.addBlockBtn.Text = "Add";
            this.addBlockBtn.UseVisualStyleBackColor = true;
            this.addBlockBtn.Click += new System.EventHandler(this.addBlockBtn_Click);
            // 
            // inputDataBox
            // 
            this.inputDataBox.Location = new System.Drawing.Point(12, 12);
            this.inputDataBox.Name = "inputDataBox";
            this.inputDataBox.Size = new System.Drawing.Size(776, 20);
            this.inputDataBox.TabIndex = 1;
            // 
            // outputDataListBox
            // 
            this.outputDataListBox.FormattingEnabled = true;
            this.outputDataListBox.Location = new System.Drawing.Point(12, 80);
            this.outputDataListBox.Name = "outputDataListBox";
            this.outputDataListBox.Size = new System.Drawing.Size(776, 355);
            this.outputDataListBox.TabIndex = 2;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputDataListBox);
            this.Controls.Add(this.inputDataBox);
            this.Controls.Add(this.addBlockBtn);
            this.Name = "MainWindow";
            this.Text = "GenBlockchain";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBlockBtn;
        private System.Windows.Forms.TextBox inputDataBox;
        private System.Windows.Forms.ListBox outputDataListBox;
    }
}

