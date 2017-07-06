namespace ClientUSBDetector
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
            this.listInfo = new System.Windows.Forms.ListBox();
            this.getInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listInfo
            // 
            this.listInfo.FormattingEnabled = true;
            this.listInfo.Location = new System.Drawing.Point(-1, 0);
            this.listInfo.Name = "listInfo";
            this.listInfo.Size = new System.Drawing.Size(209, 355);
            this.listInfo.TabIndex = 0;
            // 
            // getInfo
            // 
            this.getInfo.Location = new System.Drawing.Point(-1, 352);
            this.getInfo.Name = "getInfo";
            this.getInfo.Size = new System.Drawing.Size(209, 30);
            this.getInfo.TabIndex = 1;
            this.getInfo.Text = "GetInfo";
            this.getInfo.UseVisualStyleBackColor = true;
            this.getInfo.Click += new System.EventHandler(this.getInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 380);
            this.Controls.Add(this.getInfo);
            this.Controls.Add(this.listInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listInfo;
        private System.Windows.Forms.Button getInfo;
    }
}

