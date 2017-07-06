namespace TwiterManager
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.sendTwit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 17);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(486, 56);
            this.listBox1.TabIndex = 3;
            // 
            // sendTwit
            // 
            this.sendTwit.Location = new System.Drawing.Point(12, 80);
            this.sendTwit.Name = "sendTwit";
            this.sendTwit.Size = new System.Drawing.Size(109, 36);
            this.sendTwit.TabIndex = 6;
            this.sendTwit.Text = "SendCPU and memory status";
            this.sendTwit.UseVisualStyleBackColor = true;
            this.sendTwit.Click += new System.EventHandler(this.sendTwit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 36);
            this.button1.TabIndex = 11;
            this.button1.Text = "C:\\";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(192, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 36);
            this.button2.TabIndex = 12;
            this.button2.Text = "D:\\";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(257, 80);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(59, 36);
            this.button3.TabIndex = 13;
            this.button3.Text = "E:\\";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(322, 80);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 36);
            this.button4.TabIndex = 14;
            this.button4.Text = "Other";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 137);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sendTwit);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button sendTwit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

