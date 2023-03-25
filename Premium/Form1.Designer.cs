namespace Premium
{
    partial class FormPremiumScoring
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
            this.GroupBoxSpeedWork = new System.Windows.Forms.GroupBox();
            this.RadioButtonSpeed0 = new System.Windows.Forms.RadioButton();
            this.RadioButtonSpeed1 = new System.Windows.Forms.RadioButton();
            this.RadioButtonSpeed2 = new System.Windows.Forms.RadioButton();
            this.RadioButtonSpeed3 = new System.Windows.Forms.RadioButton();
            this.RadioButtonSpeed4 = new System.Windows.Forms.RadioButton();
            this.RadioButtonSpeed5 = new System.Windows.Forms.RadioButton();
            this.GroupBoxDecorWork = new System.Windows.Forms.GroupBox();
            this.RadioButtonDecor0 = new System.Windows.Forms.RadioButton();
            this.RadioButtonDecor1 = new System.Windows.Forms.RadioButton();
            this.RadioButtonDecor5 = new System.Windows.Forms.RadioButton();
            this.RadioButtonDecor2 = new System.Windows.Forms.RadioButton();
            this.RadioButtonDecor4 = new System.Windows.Forms.RadioButton();
            this.RadioButtonDecor3 = new System.Windows.Forms.RadioButton();
            this.GroupBoxQualityWork = new System.Windows.Forms.GroupBox();
            this.RadioButtonQuality0 = new System.Windows.Forms.RadioButton();
            this.RadioButtonQuality1 = new System.Windows.Forms.RadioButton();
            this.RadioButtonQuality5 = new System.Windows.Forms.RadioButton();
            this.RadioButtonQuality3 = new System.Windows.Forms.RadioButton();
            this.RadioButtonQuality2 = new System.Windows.Forms.RadioButton();
            this.RadioButtonQuality4 = new System.Windows.Forms.RadioButton();
            this.TextBoxSalary = new System.Windows.Forms.TextBox();
            this.LabelSalary = new System.Windows.Forms.Label();
            this.ButtonScoring = new System.Windows.Forms.Button();
            this.LabelAdditionalPremium = new System.Windows.Forms.Label();
            this.TextBoxAdditionalPremium = new System.Windows.Forms.TextBox();
            this.LabelTotalPremium = new System.Windows.Forms.Label();
            this.LabelСurrency = new System.Windows.Forms.Label();
            this.TextBoxCurrency = new System.Windows.Forms.TextBox();
            this.GroupBoxSpeedWork.SuspendLayout();
            this.GroupBoxDecorWork.SuspendLayout();
            this.GroupBoxQualityWork.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxSpeedWork
            // 
            this.GroupBoxSpeedWork.Controls.Add(this.RadioButtonSpeed0);
            this.GroupBoxSpeedWork.Controls.Add(this.RadioButtonSpeed1);
            this.GroupBoxSpeedWork.Controls.Add(this.RadioButtonSpeed2);
            this.GroupBoxSpeedWork.Controls.Add(this.RadioButtonSpeed3);
            this.GroupBoxSpeedWork.Controls.Add(this.RadioButtonSpeed4);
            this.GroupBoxSpeedWork.Controls.Add(this.RadioButtonSpeed5);
            this.GroupBoxSpeedWork.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxSpeedWork.Name = "GroupBoxSpeedWork";
            this.GroupBoxSpeedWork.Size = new System.Drawing.Size(174, 153);
            this.GroupBoxSpeedWork.TabIndex = 0;
            this.GroupBoxSpeedWork.TabStop = false;
            this.GroupBoxSpeedWork.Text = "Скорость завершения работы";
            // 
            // RadioButtonSpeed0
            // 
            this.RadioButtonSpeed0.AutoSize = true;
            this.RadioButtonSpeed0.Checked = true;
            this.RadioButtonSpeed0.Location = new System.Drawing.Point(6, 130);
            this.RadioButtonSpeed0.Name = "RadioButtonSpeed0";
            this.RadioButtonSpeed0.Size = new System.Drawing.Size(70, 17);
            this.RadioButtonSpeed0.TabIndex = 8;
            this.RadioButtonSpeed0.TabStop = true;
            this.RadioButtonSpeed0.Text = "0 баллов";
            this.RadioButtonSpeed0.UseVisualStyleBackColor = true;
            this.RadioButtonSpeed0.CheckedChanged += new System.EventHandler(this.RadioButtonSpeed0_CheckedChanged);
            // 
            // RadioButtonSpeed1
            // 
            this.RadioButtonSpeed1.AutoSize = true;
            this.RadioButtonSpeed1.Location = new System.Drawing.Point(6, 107);
            this.RadioButtonSpeed1.Name = "RadioButtonSpeed1";
            this.RadioButtonSpeed1.Size = new System.Drawing.Size(58, 17);
            this.RadioButtonSpeed1.TabIndex = 7;
            this.RadioButtonSpeed1.Text = "1 балл";
            this.RadioButtonSpeed1.UseVisualStyleBackColor = true;
            this.RadioButtonSpeed1.CheckedChanged += new System.EventHandler(this.RadioButtonSpeed1_CheckedChanged);
            // 
            // RadioButtonSpeed2
            // 
            this.RadioButtonSpeed2.AutoSize = true;
            this.RadioButtonSpeed2.Location = new System.Drawing.Point(6, 84);
            this.RadioButtonSpeed2.Name = "RadioButtonSpeed2";
            this.RadioButtonSpeed2.Size = new System.Drawing.Size(64, 17);
            this.RadioButtonSpeed2.TabIndex = 6;
            this.RadioButtonSpeed2.Text = "2 балла";
            this.RadioButtonSpeed2.UseVisualStyleBackColor = true;
            this.RadioButtonSpeed2.CheckedChanged += new System.EventHandler(this.RadioButtonSpeed2_CheckedChanged);
            // 
            // RadioButtonSpeed3
            // 
            this.RadioButtonSpeed3.AutoSize = true;
            this.RadioButtonSpeed3.Location = new System.Drawing.Point(6, 62);
            this.RadioButtonSpeed3.Name = "RadioButtonSpeed3";
            this.RadioButtonSpeed3.Size = new System.Drawing.Size(64, 17);
            this.RadioButtonSpeed3.TabIndex = 5;
            this.RadioButtonSpeed3.Text = "3 балла";
            this.RadioButtonSpeed3.UseVisualStyleBackColor = true;
            this.RadioButtonSpeed3.CheckedChanged += new System.EventHandler(this.RadioButtonSpeed3_CheckedChanged);
            // 
            // RadioButtonSpeed4
            // 
            this.RadioButtonSpeed4.AutoSize = true;
            this.RadioButtonSpeed4.Location = new System.Drawing.Point(6, 40);
            this.RadioButtonSpeed4.Name = "RadioButtonSpeed4";
            this.RadioButtonSpeed4.Size = new System.Drawing.Size(64, 17);
            this.RadioButtonSpeed4.TabIndex = 4;
            this.RadioButtonSpeed4.Text = "4 балла";
            this.RadioButtonSpeed4.UseVisualStyleBackColor = true;
            this.RadioButtonSpeed4.CheckedChanged += new System.EventHandler(this.RadioButtonSpeed4_CheckedChanged);
            // 
            // RadioButtonSpeed5
            // 
            this.RadioButtonSpeed5.AutoSize = true;
            this.RadioButtonSpeed5.Location = new System.Drawing.Point(6, 19);
            this.RadioButtonSpeed5.Name = "RadioButtonSpeed5";
            this.RadioButtonSpeed5.Size = new System.Drawing.Size(70, 17);
            this.RadioButtonSpeed5.TabIndex = 3;
            this.RadioButtonSpeed5.Text = "5 баллов";
            this.RadioButtonSpeed5.UseVisualStyleBackColor = true;
            this.RadioButtonSpeed5.CheckedChanged += new System.EventHandler(this.RadioButtonSpeed5_CheckedChanged);
            // 
            // GroupBoxDecorWork
            // 
            this.GroupBoxDecorWork.Controls.Add(this.RadioButtonDecor0);
            this.GroupBoxDecorWork.Controls.Add(this.RadioButtonDecor1);
            this.GroupBoxDecorWork.Controls.Add(this.RadioButtonDecor5);
            this.GroupBoxDecorWork.Controls.Add(this.RadioButtonDecor2);
            this.GroupBoxDecorWork.Controls.Add(this.RadioButtonDecor4);
            this.GroupBoxDecorWork.Controls.Add(this.RadioButtonDecor3);
            this.GroupBoxDecorWork.Location = new System.Drawing.Point(192, 12);
            this.GroupBoxDecorWork.Name = "GroupBoxDecorWork";
            this.GroupBoxDecorWork.Size = new System.Drawing.Size(129, 153);
            this.GroupBoxDecorWork.TabIndex = 1;
            this.GroupBoxDecorWork.TabStop = false;
            this.GroupBoxDecorWork.Text = "Оформление работы";
            // 
            // RadioButtonDecor0
            // 
            this.RadioButtonDecor0.AutoSize = true;
            this.RadioButtonDecor0.Checked = true;
            this.RadioButtonDecor0.Location = new System.Drawing.Point(6, 130);
            this.RadioButtonDecor0.Name = "RadioButtonDecor0";
            this.RadioButtonDecor0.Size = new System.Drawing.Size(70, 17);
            this.RadioButtonDecor0.TabIndex = 9;
            this.RadioButtonDecor0.TabStop = true;
            this.RadioButtonDecor0.Text = "0 баллов";
            this.RadioButtonDecor0.UseVisualStyleBackColor = true;
            this.RadioButtonDecor0.CheckedChanged += new System.EventHandler(this.RadioButtonDecor0_CheckedChanged);
            // 
            // RadioButtonDecor1
            // 
            this.RadioButtonDecor1.AutoSize = true;
            this.RadioButtonDecor1.Location = new System.Drawing.Point(6, 108);
            this.RadioButtonDecor1.Name = "RadioButtonDecor1";
            this.RadioButtonDecor1.Size = new System.Drawing.Size(58, 17);
            this.RadioButtonDecor1.TabIndex = 12;
            this.RadioButtonDecor1.Text = "1 балл";
            this.RadioButtonDecor1.UseVisualStyleBackColor = true;
            this.RadioButtonDecor1.CheckedChanged += new System.EventHandler(this.RadioButtonDecor1_CheckedChanged);
            // 
            // RadioButtonDecor5
            // 
            this.RadioButtonDecor5.AutoSize = true;
            this.RadioButtonDecor5.Location = new System.Drawing.Point(6, 18);
            this.RadioButtonDecor5.Name = "RadioButtonDecor5";
            this.RadioButtonDecor5.Size = new System.Drawing.Size(70, 17);
            this.RadioButtonDecor5.TabIndex = 8;
            this.RadioButtonDecor5.Text = "5 баллов";
            this.RadioButtonDecor5.UseVisualStyleBackColor = true;
            this.RadioButtonDecor5.CheckedChanged += new System.EventHandler(this.RadioButtonDecor5_CheckedChanged);
            // 
            // RadioButtonDecor2
            // 
            this.RadioButtonDecor2.AutoSize = true;
            this.RadioButtonDecor2.Location = new System.Drawing.Point(6, 87);
            this.RadioButtonDecor2.Name = "RadioButtonDecor2";
            this.RadioButtonDecor2.Size = new System.Drawing.Size(64, 17);
            this.RadioButtonDecor2.TabIndex = 11;
            this.RadioButtonDecor2.Text = "2 балла";
            this.RadioButtonDecor2.UseVisualStyleBackColor = true;
            this.RadioButtonDecor2.CheckedChanged += new System.EventHandler(this.RadioButtonDecor2_CheckedChanged);
            // 
            // RadioButtonDecor4
            // 
            this.RadioButtonDecor4.AutoSize = true;
            this.RadioButtonDecor4.Location = new System.Drawing.Point(6, 41);
            this.RadioButtonDecor4.Name = "RadioButtonDecor4";
            this.RadioButtonDecor4.Size = new System.Drawing.Size(64, 17);
            this.RadioButtonDecor4.TabIndex = 9;
            this.RadioButtonDecor4.Text = "4 балла";
            this.RadioButtonDecor4.UseVisualStyleBackColor = true;
            this.RadioButtonDecor4.CheckedChanged += new System.EventHandler(this.RadioButtonDecor4_CheckedChanged);
            // 
            // RadioButtonDecor3
            // 
            this.RadioButtonDecor3.AutoSize = true;
            this.RadioButtonDecor3.Location = new System.Drawing.Point(6, 64);
            this.RadioButtonDecor3.Name = "RadioButtonDecor3";
            this.RadioButtonDecor3.Size = new System.Drawing.Size(64, 17);
            this.RadioButtonDecor3.TabIndex = 10;
            this.RadioButtonDecor3.Text = "3 балла";
            this.RadioButtonDecor3.UseVisualStyleBackColor = true;
            this.RadioButtonDecor3.CheckedChanged += new System.EventHandler(this.RadioButtonDecor3_CheckedChanged);
            // 
            // GroupBoxQualityWork
            // 
            this.GroupBoxQualityWork.Controls.Add(this.RadioButtonQuality0);
            this.GroupBoxQualityWork.Controls.Add(this.RadioButtonQuality1);
            this.GroupBoxQualityWork.Controls.Add(this.RadioButtonQuality5);
            this.GroupBoxQualityWork.Controls.Add(this.RadioButtonQuality3);
            this.GroupBoxQualityWork.Controls.Add(this.RadioButtonQuality2);
            this.GroupBoxQualityWork.Controls.Add(this.RadioButtonQuality4);
            this.GroupBoxQualityWork.Location = new System.Drawing.Point(327, 12);
            this.GroupBoxQualityWork.Name = "GroupBoxQualityWork";
            this.GroupBoxQualityWork.Size = new System.Drawing.Size(129, 153);
            this.GroupBoxQualityWork.TabIndex = 2;
            this.GroupBoxQualityWork.TabStop = false;
            this.GroupBoxQualityWork.Text = "Качество работы";
            // 
            // RadioButtonQuality0
            // 
            this.RadioButtonQuality0.AutoSize = true;
            this.RadioButtonQuality0.Location = new System.Drawing.Point(6, 130);
            this.RadioButtonQuality0.Name = "RadioButtonQuality0";
            this.RadioButtonQuality0.Size = new System.Drawing.Size(70, 17);
            this.RadioButtonQuality0.TabIndex = 13;
            this.RadioButtonQuality0.Text = "0 баллов";
            this.RadioButtonQuality0.UseVisualStyleBackColor = true;
            this.RadioButtonQuality0.CheckedChanged += new System.EventHandler(this.RadioButtonQuality0_CheckedChanged);
            // 
            // RadioButtonQuality1
            // 
            this.RadioButtonQuality1.AutoSize = true;
            this.RadioButtonQuality1.Location = new System.Drawing.Point(6, 108);
            this.RadioButtonQuality1.Name = "RadioButtonQuality1";
            this.RadioButtonQuality1.Size = new System.Drawing.Size(58, 17);
            this.RadioButtonQuality1.TabIndex = 17;
            this.RadioButtonQuality1.Text = "1 балл";
            this.RadioButtonQuality1.UseVisualStyleBackColor = true;
            this.RadioButtonQuality1.CheckedChanged += new System.EventHandler(this.RadioButtonQuality1_CheckedChanged);
            // 
            // RadioButtonQuality5
            // 
            this.RadioButtonQuality5.AutoSize = true;
            this.RadioButtonQuality5.Location = new System.Drawing.Point(6, 18);
            this.RadioButtonQuality5.Name = "RadioButtonQuality5";
            this.RadioButtonQuality5.Size = new System.Drawing.Size(70, 17);
            this.RadioButtonQuality5.TabIndex = 13;
            this.RadioButtonQuality5.Text = "5 баллов";
            this.RadioButtonQuality5.UseVisualStyleBackColor = true;
            this.RadioButtonQuality5.CheckedChanged += new System.EventHandler(this.RadioButtonQuality5_CheckedChanged);
            // 
            // RadioButtonQuality3
            // 
            this.RadioButtonQuality3.AutoSize = true;
            this.RadioButtonQuality3.Location = new System.Drawing.Point(6, 64);
            this.RadioButtonQuality3.Name = "RadioButtonQuality3";
            this.RadioButtonQuality3.Size = new System.Drawing.Size(64, 17);
            this.RadioButtonQuality3.TabIndex = 15;
            this.RadioButtonQuality3.Text = "3 балла";
            this.RadioButtonQuality3.UseVisualStyleBackColor = true;
            this.RadioButtonQuality3.CheckedChanged += new System.EventHandler(this.RadioButtonQuality3_CheckedChanged);
            // 
            // RadioButtonQuality2
            // 
            this.RadioButtonQuality2.AutoSize = true;
            this.RadioButtonQuality2.Location = new System.Drawing.Point(6, 87);
            this.RadioButtonQuality2.Name = "RadioButtonQuality2";
            this.RadioButtonQuality2.Size = new System.Drawing.Size(64, 17);
            this.RadioButtonQuality2.TabIndex = 16;
            this.RadioButtonQuality2.Text = "2 балла";
            this.RadioButtonQuality2.UseVisualStyleBackColor = true;
            this.RadioButtonQuality2.CheckedChanged += new System.EventHandler(this.RadioButtonQuality2_CheckedChanged);
            // 
            // RadioButtonQuality4
            // 
            this.RadioButtonQuality4.AutoSize = true;
            this.RadioButtonQuality4.Location = new System.Drawing.Point(6, 41);
            this.RadioButtonQuality4.Name = "RadioButtonQuality4";
            this.RadioButtonQuality4.Size = new System.Drawing.Size(64, 17);
            this.RadioButtonQuality4.TabIndex = 14;
            this.RadioButtonQuality4.Text = "4 балла";
            this.RadioButtonQuality4.UseVisualStyleBackColor = true;
            this.RadioButtonQuality4.CheckedChanged += new System.EventHandler(this.RadioButtonQuality4_CheckedChanged);
            // 
            // TextBoxSalary
            // 
            this.TextBoxSalary.Location = new System.Drawing.Point(18, 184);
            this.TextBoxSalary.Name = "TextBoxSalary";
            this.TextBoxSalary.Size = new System.Drawing.Size(132, 20);
            this.TextBoxSalary.TabIndex = 3;
            // 
            // LabelSalary
            // 
            this.LabelSalary.AutoSize = true;
            this.LabelSalary.Location = new System.Drawing.Point(15, 168);
            this.LabelSalary.Name = "LabelSalary";
            this.LabelSalary.Size = new System.Drawing.Size(135, 13);
            this.LabelSalary.TabIndex = 4;
            this.LabelSalary.Text = "Укажите плату за работу";
            // 
            // ButtonScoring
            // 
            this.ButtonScoring.Location = new System.Drawing.Point(18, 226);
            this.ButtonScoring.Name = "ButtonScoring";
            this.ButtonScoring.Size = new System.Drawing.Size(132, 23);
            this.ButtonScoring.TabIndex = 5;
            this.ButtonScoring.Text = "Подсчитать";
            this.ButtonScoring.UseVisualStyleBackColor = true;
            this.ButtonScoring.Click += new System.EventHandler(this.ButtonScoring_Click);
            // 
            // LabelAdditionalPremium
            // 
            this.LabelAdditionalPremium.AutoSize = true;
            this.LabelAdditionalPremium.Location = new System.Drawing.Point(281, 168);
            this.LabelAdditionalPremium.Name = "LabelAdditionalPremium";
            this.LabelAdditionalPremium.Size = new System.Drawing.Size(304, 13);
            this.LabelAdditionalPremium.TabIndex = 7;
            this.LabelAdditionalPremium.Text = "Укажите Дополнительную премию за работу(по желанию)";
            // 
            // TextBoxAdditionalPremium
            // 
            this.TextBoxAdditionalPremium.Location = new System.Drawing.Point(284, 184);
            this.TextBoxAdditionalPremium.Name = "TextBoxAdditionalPremium";
            this.TextBoxAdditionalPremium.Size = new System.Drawing.Size(132, 20);
            this.TextBoxAdditionalPremium.TabIndex = 6;
            // 
            // LabelTotalPremium
            // 
            this.LabelTotalPremium.AutoSize = true;
            this.LabelTotalPremium.Location = new System.Drawing.Point(165, 231);
            this.LabelTotalPremium.Name = "LabelTotalPremium";
            this.LabelTotalPremium.Size = new System.Drawing.Size(166, 13);
            this.LabelTotalPremium.TabIndex = 9;
            this.LabelTotalPremium.Text = "Премия за работу составляет: ";
            // 
            // LabelСurrency
            // 
            this.LabelСurrency.AutoSize = true;
            this.LabelСurrency.Location = new System.Drawing.Point(170, 168);
            this.LabelСurrency.Name = "LabelСurrency";
            this.LabelСurrency.Size = new System.Drawing.Size(91, 13);
            this.LabelСurrency.TabIndex = 11;
            this.LabelСurrency.Text = "Укажите валюту";
            // 
            // TextBoxCurrency
            // 
            this.TextBoxCurrency.Location = new System.Drawing.Point(173, 184);
            this.TextBoxCurrency.Name = "TextBoxCurrency";
            this.TextBoxCurrency.Size = new System.Drawing.Size(88, 20);
            this.TextBoxCurrency.TabIndex = 10;
            // 
            // FormPremiumScoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelСurrency);
            this.Controls.Add(this.TextBoxCurrency);
            this.Controls.Add(this.LabelTotalPremium);
            this.Controls.Add(this.LabelAdditionalPremium);
            this.Controls.Add(this.TextBoxAdditionalPremium);
            this.Controls.Add(this.ButtonScoring);
            this.Controls.Add(this.LabelSalary);
            this.Controls.Add(this.TextBoxSalary);
            this.Controls.Add(this.GroupBoxQualityWork);
            this.Controls.Add(this.GroupBoxDecorWork);
            this.Controls.Add(this.GroupBoxSpeedWork);
            this.Name = "FormPremiumScoring";
            this.Text = "FormPremiumScoring";
            this.GroupBoxSpeedWork.ResumeLayout(false);
            this.GroupBoxSpeedWork.PerformLayout();
            this.GroupBoxDecorWork.ResumeLayout(false);
            this.GroupBoxDecorWork.PerformLayout();
            this.GroupBoxQualityWork.ResumeLayout(false);
            this.GroupBoxQualityWork.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxSpeedWork;
        private System.Windows.Forms.RadioButton RadioButtonSpeed1;
        private System.Windows.Forms.RadioButton RadioButtonSpeed2;
        private System.Windows.Forms.RadioButton RadioButtonSpeed3;
        private System.Windows.Forms.RadioButton RadioButtonSpeed4;
        private System.Windows.Forms.RadioButton RadioButtonSpeed5;
        private System.Windows.Forms.GroupBox GroupBoxDecorWork;
        private System.Windows.Forms.RadioButton RadioButtonDecor1;
        private System.Windows.Forms.RadioButton RadioButtonDecor5;
        private System.Windows.Forms.RadioButton RadioButtonDecor2;
        private System.Windows.Forms.RadioButton RadioButtonDecor4;
        private System.Windows.Forms.RadioButton RadioButtonDecor3;
        private System.Windows.Forms.GroupBox GroupBoxQualityWork;
        private System.Windows.Forms.RadioButton RadioButtonQuality1;
        private System.Windows.Forms.RadioButton RadioButtonQuality5;
        private System.Windows.Forms.RadioButton RadioButtonQuality3;
        private System.Windows.Forms.RadioButton RadioButtonQuality2;
        private System.Windows.Forms.RadioButton RadioButtonQuality4;
        private System.Windows.Forms.TextBox TextBoxSalary;
        private System.Windows.Forms.Label LabelSalary;
        private System.Windows.Forms.Button ButtonScoring;
        private System.Windows.Forms.Label LabelAdditionalPremium;
        private System.Windows.Forms.TextBox TextBoxAdditionalPremium;
        private System.Windows.Forms.RadioButton RadioButtonSpeed0;
        private System.Windows.Forms.RadioButton RadioButtonDecor0;
        private System.Windows.Forms.RadioButton RadioButtonQuality0;
        private System.Windows.Forms.Label LabelTotalPremium;
        private System.Windows.Forms.Label LabelСurrency;
        private System.Windows.Forms.TextBox TextBoxCurrency;
    }
}

