namespace DZ_PT_WinForms_1_8
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
            this.groupBox1_FueLStation = new System.Windows.Forms.GroupBox();
            this.groupBox_FuelTotalSumm = new System.Windows.Forms.GroupBox();
            this.label3_grn = new System.Windows.Forms.Label();
            this.label_FuelTotalSumm = new System.Windows.Forms.Label();
            this.label1_grn = new System.Windows.Forms.Label();
            this.groupBox2_SumVolume = new System.Windows.Forms.GroupBox();
            this.label2_grn = new System.Windows.Forms.Label();
            this.label_litre = new System.Windows.Forms.Label();
            this.textBox_FuelSumm = new System.Windows.Forms.TextBox();
            this.textBox_FuelVolume = new System.Windows.Forms.TextBox();
            this.radioButton_FuelSumm = new System.Windows.Forms.RadioButton();
            this.radioButton_FuelVolume = new System.Windows.Forms.RadioButton();
            this.textBox_FuelPrice = new System.Windows.Forms.TextBox();
            this.label_FuelPrice = new System.Windows.Forms.Label();
            this.comboBox_Fuel = new System.Windows.Forms.ComboBox();
            this.label_Fuel = new System.Windows.Forms.Label();
            this.groupBox1_FueLStation.SuspendLayout();
            this.groupBox_FuelTotalSumm.SuspendLayout();
            this.groupBox2_SumVolume.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1_FueLStation
            // 
            this.groupBox1_FueLStation.Controls.Add(this.groupBox_FuelTotalSumm);
            this.groupBox1_FueLStation.Controls.Add(this.label1_grn);
            this.groupBox1_FueLStation.Controls.Add(this.groupBox2_SumVolume);
            this.groupBox1_FueLStation.Controls.Add(this.textBox_FuelPrice);
            this.groupBox1_FueLStation.Controls.Add(this.label_FuelPrice);
            this.groupBox1_FueLStation.Controls.Add(this.comboBox_Fuel);
            this.groupBox1_FueLStation.Controls.Add(this.label_Fuel);
            this.groupBox1_FueLStation.Location = new System.Drawing.Point(8, 8);
            this.groupBox1_FueLStation.Name = "groupBox1_FueLStation";
            this.groupBox1_FueLStation.Size = new System.Drawing.Size(256, 280);
            this.groupBox1_FueLStation.TabIndex = 0;
            this.groupBox1_FueLStation.TabStop = false;
            this.groupBox1_FueLStation.Text = "Автозаправка";
            // 
            // groupBox_FuelTotalSumm
            // 
            this.groupBox_FuelTotalSumm.Controls.Add(this.label3_grn);
            this.groupBox_FuelTotalSumm.Controls.Add(this.label_FuelTotalSumm);
            this.groupBox_FuelTotalSumm.Location = new System.Drawing.Point(8, 200);
            this.groupBox_FuelTotalSumm.Name = "groupBox_FuelTotalSumm";
            this.groupBox_FuelTotalSumm.Size = new System.Drawing.Size(240, 72);
            this.groupBox_FuelTotalSumm.TabIndex = 6;
            this.groupBox_FuelTotalSumm.TabStop = false;
            this.groupBox_FuelTotalSumm.Text = "К оплате:";
            // 
            // label3_grn
            // 
            this.label3_grn.AutoSize = true;
            this.label3_grn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3_grn.Location = new System.Drawing.Point(176, 40);
            this.label3_grn.Name = "label3_grn";
            this.label3_grn.Size = new System.Drawing.Size(46, 24);
            this.label3_grn.TabIndex = 1;
            this.label3_grn.Text = "грн.";
            // 
            // label_FuelTotalSumm
            // 
            this.label_FuelTotalSumm.AutoSize = true;
            this.label_FuelTotalSumm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_FuelTotalSumm.Location = new System.Drawing.Point(88, 32);
            this.label_FuelTotalSumm.Name = "label_FuelTotalSumm";
            this.label_FuelTotalSumm.Size = new System.Drawing.Size(67, 31);
            this.label_FuelTotalSumm.TabIndex = 0;
            this.label_FuelTotalSumm.Text = "0,00";
            // 
            // label1_grn
            // 
            this.label1_grn.AutoSize = true;
            this.label1_grn.Location = new System.Drawing.Point(224, 72);
            this.label1_grn.Name = "label1_grn";
            this.label1_grn.Size = new System.Drawing.Size(27, 13);
            this.label1_grn.TabIndex = 5;
            this.label1_grn.Text = "грн.";
            // 
            // groupBox2_SumVolume
            // 
            this.groupBox2_SumVolume.Controls.Add(this.label2_grn);
            this.groupBox2_SumVolume.Controls.Add(this.label_litre);
            this.groupBox2_SumVolume.Controls.Add(this.textBox_FuelSumm);
            this.groupBox2_SumVolume.Controls.Add(this.textBox_FuelVolume);
            this.groupBox2_SumVolume.Controls.Add(this.radioButton_FuelSumm);
            this.groupBox2_SumVolume.Controls.Add(this.radioButton_FuelVolume);
            this.groupBox2_SumVolume.Location = new System.Drawing.Point(8, 104);
            this.groupBox2_SumVolume.Name = "groupBox2_SumVolume";
            this.groupBox2_SumVolume.Size = new System.Drawing.Size(240, 88);
            this.groupBox2_SumVolume.TabIndex = 4;
            this.groupBox2_SumVolume.TabStop = false;
            // 
            // label2_grn
            // 
            this.label2_grn.AutoSize = true;
            this.label2_grn.Location = new System.Drawing.Point(200, 64);
            this.label2_grn.Name = "label2_grn";
            this.label2_grn.Size = new System.Drawing.Size(27, 13);
            this.label2_grn.TabIndex = 5;
            this.label2_grn.Text = "грн.";
            // 
            // label_litre
            // 
            this.label_litre.AutoSize = true;
            this.label_litre.Location = new System.Drawing.Point(200, 32);
            this.label_litre.Name = "label_litre";
            this.label_litre.Size = new System.Drawing.Size(13, 13);
            this.label_litre.TabIndex = 4;
            this.label_litre.Text = "л";
            // 
            // textBox_FuelSumm
            // 
            this.textBox_FuelSumm.Location = new System.Drawing.Point(88, 56);
            this.textBox_FuelSumm.Name = "textBox_FuelSumm";
            this.textBox_FuelSumm.Size = new System.Drawing.Size(100, 20);
            this.textBox_FuelSumm.TabIndex = 3;
            // 
            // textBox_FuelVolume
            // 
            this.textBox_FuelVolume.Location = new System.Drawing.Point(88, 24);
            this.textBox_FuelVolume.Name = "textBox_FuelVolume";
            this.textBox_FuelVolume.Size = new System.Drawing.Size(100, 20);
            this.textBox_FuelVolume.TabIndex = 2;
            this.textBox_FuelVolume.TextChanged += new System.EventHandler(this.textBox1_FuelVolume_TextChanged);
            // 
            // radioButton_FuelSumm
            // 
            this.radioButton_FuelSumm.AutoSize = true;
            this.radioButton_FuelSumm.Location = new System.Drawing.Point(16, 56);
            this.radioButton_FuelSumm.Name = "radioButton_FuelSumm";
            this.radioButton_FuelSumm.Size = new System.Drawing.Size(59, 17);
            this.radioButton_FuelSumm.TabIndex = 1;
            this.radioButton_FuelSumm.TabStop = true;
            this.radioButton_FuelSumm.Text = "Сумма";
            this.radioButton_FuelSumm.UseVisualStyleBackColor = true;
            this.radioButton_FuelSumm.CheckedChanged += new System.EventHandler(this.radioButton2_FuelSumm_CheckedChanged);
            // 
            // radioButton_FuelVolume
            // 
            this.radioButton_FuelVolume.AutoSize = true;
            this.radioButton_FuelVolume.Location = new System.Drawing.Point(16, 24);
            this.radioButton_FuelVolume.Name = "radioButton_FuelVolume";
            this.radioButton_FuelVolume.Size = new System.Drawing.Size(60, 17);
            this.radioButton_FuelVolume.TabIndex = 0;
            this.radioButton_FuelVolume.TabStop = true;
            this.radioButton_FuelVolume.Text = "Объем";
            this.radioButton_FuelVolume.UseVisualStyleBackColor = true;
            this.radioButton_FuelVolume.CheckedChanged += new System.EventHandler(this.radioButton1_FuelVolume_CheckedChanged);
            // 
            // textBox_FuelPrice
            // 
            this.textBox_FuelPrice.AutoCompleteCustomSource.AddRange(new string[] {
            "22,55",
            "23,65",
            "24,80",
            "26,90",
            "12,00",
            "23,20"});
            this.textBox_FuelPrice.Location = new System.Drawing.Point(96, 64);
            this.textBox_FuelPrice.Name = "textBox_FuelPrice";
            this.textBox_FuelPrice.ReadOnly = true;
            this.textBox_FuelPrice.Size = new System.Drawing.Size(120, 20);
            this.textBox_FuelPrice.TabIndex = 3;
            this.textBox_FuelPrice.TextChanged += new System.EventHandler(this.textBox_FuelPrice_TextChanged);
            // 
            // label_FuelPrice
            // 
            this.label_FuelPrice.AutoSize = true;
            this.label_FuelPrice.Location = new System.Drawing.Point(24, 72);
            this.label_FuelPrice.Name = "label_FuelPrice";
            this.label_FuelPrice.Size = new System.Drawing.Size(33, 13);
            this.label_FuelPrice.TabIndex = 2;
            this.label_FuelPrice.Text = "Цена";
            // 
            // comboBox_Fuel
            // 
            this.comboBox_Fuel.FormattingEnabled = true;
            this.comboBox_Fuel.Items.AddRange(new object[] {
            "А-80",
            "А-92",
            "А-95",
            "А-98",
            "LPG",
            "Disel"});
            this.comboBox_Fuel.Location = new System.Drawing.Point(96, 24);
            this.comboBox_Fuel.Name = "comboBox_Fuel";
            this.comboBox_Fuel.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Fuel.TabIndex = 1;
            this.comboBox_Fuel.SelectedIndexChanged += new System.EventHandler(this.comboBox_Fuel_SelectedIndexChanged);
            // 
            // label_Fuel
            // 
            this.label_Fuel.AutoSize = true;
            this.label_Fuel.Location = new System.Drawing.Point(16, 32);
            this.label_Fuel.Name = "label_Fuel";
            this.label_Fuel.Size = new System.Drawing.Size(50, 13);
            this.label_Fuel.TabIndex = 0;
            this.label_Fuel.Text = "Топливо";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1_FueLStation);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BestOil";
            this.groupBox1_FueLStation.ResumeLayout(false);
            this.groupBox1_FueLStation.PerformLayout();
            this.groupBox_FuelTotalSumm.ResumeLayout(false);
            this.groupBox_FuelTotalSumm.PerformLayout();
            this.groupBox2_SumVolume.ResumeLayout(false);
            this.groupBox2_SumVolume.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1_FueLStation;
        private System.Windows.Forms.Label label_Fuel;
        private System.Windows.Forms.ComboBox comboBox_Fuel;
        private System.Windows.Forms.TextBox textBox_FuelPrice;
        private System.Windows.Forms.Label label_FuelPrice;
        private System.Windows.Forms.GroupBox groupBox2_SumVolume;
        private System.Windows.Forms.Label label1_grn;
        private System.Windows.Forms.Label label2_grn;
        private System.Windows.Forms.Label label_litre;
        private System.Windows.Forms.TextBox textBox_FuelSumm;
        private System.Windows.Forms.TextBox textBox_FuelVolume;
        private System.Windows.Forms.RadioButton radioButton_FuelSumm;
        private System.Windows.Forms.RadioButton radioButton_FuelVolume;
        private System.Windows.Forms.GroupBox groupBox_FuelTotalSumm;
        private System.Windows.Forms.Label label_FuelTotalSumm;
        private System.Windows.Forms.Label label3_grn;
    }
}

