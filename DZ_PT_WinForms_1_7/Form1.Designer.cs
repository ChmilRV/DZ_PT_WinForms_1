namespace DZ_PT_WinForms_1_7
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_Year = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton_Month = new System.Windows.Forms.RadioButton();
            this.radioButton_Day = new System.Windows.Forms.RadioButton();
            this.radioButton_Minute = new System.Windows.Forms.RadioButton();
            this.radioButton_Second = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(88, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "До даты:";
            // 
            // radioButton_Year
            // 
            this.radioButton_Year.AutoSize = true;
            this.radioButton_Year.Location = new System.Drawing.Point(24, 80);
            this.radioButton_Year.Name = "radioButton_Year";
            this.radioButton_Year.Size = new System.Drawing.Size(42, 17);
            this.radioButton_Year.TabIndex = 3;
            this.radioButton_Year.TabStop = true;
            this.radioButton_Year.Text = "год";
            this.radioButton_Year.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton_Year.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(240, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "осталось";
            // 
            // radioButton_Month
            // 
            this.radioButton_Month.AutoSize = true;
            this.radioButton_Month.Location = new System.Drawing.Point(88, 80);
            this.radioButton_Month.Name = "radioButton_Month";
            this.radioButton_Month.Size = new System.Drawing.Size(57, 17);
            this.radioButton_Month.TabIndex = 5;
            this.radioButton_Month.TabStop = true;
            this.radioButton_Month.Text = "месяц";
            this.radioButton_Month.UseVisualStyleBackColor = true;
            // 
            // radioButton_Day
            // 
            this.radioButton_Day.AutoSize = true;
            this.radioButton_Day.Location = new System.Drawing.Point(160, 80);
            this.radioButton_Day.Name = "radioButton_Day";
            this.radioButton_Day.Size = new System.Drawing.Size(49, 17);
            this.radioButton_Day.TabIndex = 6;
            this.radioButton_Day.TabStop = true;
            this.radioButton_Day.Text = "день";
            this.radioButton_Day.UseVisualStyleBackColor = true;
            // 
            // radioButton_Minute
            // 
            this.radioButton_Minute.AutoSize = true;
            this.radioButton_Minute.Location = new System.Drawing.Point(224, 80);
            this.radioButton_Minute.Name = "radioButton_Minute";
            this.radioButton_Minute.Size = new System.Drawing.Size(55, 17);
            this.radioButton_Minute.TabIndex = 7;
            this.radioButton_Minute.TabStop = true;
            this.radioButton_Minute.Text = "минут";
            this.radioButton_Minute.UseVisualStyleBackColor = true;
            // 
            // radioButton_Second
            // 
            this.radioButton_Second.AutoSize = true;
            this.radioButton_Second.Location = new System.Drawing.Point(296, 80);
            this.radioButton_Second.Name = "radioButton_Second";
            this.radioButton_Second.Size = new System.Drawing.Size(60, 17);
            this.radioButton_Second.TabIndex = 8;
            this.radioButton_Second.TabStop = true;
            this.radioButton_Second.Text = "секунд";
            this.radioButton_Second.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(344, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 122);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButton_Second);
            this.Controls.Add(this.radioButton_Minute);
            this.Controls.Add(this.radioButton_Day);
            this.Controls.Add(this.radioButton_Month);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton_Year);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DZ_PT_WinForms_1_7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_Year;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton_Month;
        private System.Windows.Forms.RadioButton radioButton_Day;
        private System.Windows.Forms.RadioButton radioButton_Minute;
        private System.Windows.Forms.RadioButton radioButton_Second;
        private System.Windows.Forms.Label label3;
    }
}

