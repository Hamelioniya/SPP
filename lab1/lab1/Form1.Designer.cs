namespace lab1
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
            this.getNewsButton = new System.Windows.Forms.Button();
            this.Cur_IdLabel = new System.Windows.Forms.Label();
            this.Cur_IDBox = new System.Windows.Forms.TextBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.DateBox = new System.Windows.Forms.TextBox();
            this.Cur_AbbreviationLabel = new System.Windows.Forms.Label();
            this.Cur_ScaleLabel = new System.Windows.Forms.Label();
            this.Cur_ScaleBox = new System.Windows.Forms.TextBox();
            this.Cur_AbbreviationComboBox = new System.Windows.Forms.ComboBox();
            this.Cur_OfficialRateLabel = new System.Windows.Forms.Label();
            this.Cur_OfficialRateBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.Cur_NameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // getNewsButton
            // 
            this.getNewsButton.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getNewsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.getNewsButton.Location = new System.Drawing.Point(359, 120);
            this.getNewsButton.Name = "getNewsButton";
            this.getNewsButton.Size = new System.Drawing.Size(274, 27);
            this.getNewsButton.TabIndex = 1;
            this.getNewsButton.Text = "Получить курс валют";
            this.getNewsButton.UseVisualStyleBackColor = true;
            this.getNewsButton.Click += new System.EventHandler(this.getNewsButton_Click);
            // 
            // Cur_IdLabel
            // 
            this.Cur_IdLabel.AutoSize = true;
            this.Cur_IdLabel.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cur_IdLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Cur_IdLabel.Location = new System.Drawing.Point(14, 52);
            this.Cur_IdLabel.Name = "Cur_IdLabel";
            this.Cur_IdLabel.Size = new System.Drawing.Size(109, 17);
            this.Cur_IdLabel.TabIndex = 4;
            this.Cur_IdLabel.Text = "Внутренний код:";
            // 
            // Cur_IDBox
            // 
            this.Cur_IDBox.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cur_IDBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Cur_IDBox.Location = new System.Drawing.Point(126, 52);
            this.Cur_IDBox.Name = "Cur_IDBox";
            this.Cur_IDBox.Size = new System.Drawing.Size(49, 22);
            this.Cur_IDBox.TabIndex = 5;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.DateLabel.Location = new System.Drawing.Point(183, 52);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(38, 17);
            this.DateLabel.TabIndex = 6;
            this.DateLabel.Text = "Дата:";
            // 
            // DateBox
            // 
            this.DateBox.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.DateBox.Location = new System.Drawing.Point(232, 52);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(116, 22);
            this.DateBox.TabIndex = 7;
            // 
            // Cur_AbbreviationLabel
            // 
            this.Cur_AbbreviationLabel.AutoSize = true;
            this.Cur_AbbreviationLabel.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cur_AbbreviationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Cur_AbbreviationLabel.Location = new System.Drawing.Point(356, 52);
            this.Cur_AbbreviationLabel.Name = "Cur_AbbreviationLabel";
            this.Cur_AbbreviationLabel.Size = new System.Drawing.Size(104, 17);
            this.Cur_AbbreviationLabel.TabIndex = 8;
            this.Cur_AbbreviationLabel.Text = "Буквенный код:";
            // 
            // Cur_ScaleLabel
            // 
            this.Cur_ScaleLabel.AutoSize = true;
            this.Cur_ScaleLabel.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cur_ScaleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Cur_ScaleLabel.Location = new System.Drawing.Point(553, 52);
            this.Cur_ScaleLabel.Name = "Cur_ScaleLabel";
            this.Cur_ScaleLabel.Size = new System.Drawing.Size(258, 17);
            this.Cur_ScaleLabel.TabIndex = 10;
            this.Cur_ScaleLabel.Text = "Количество единиц иностранной валюты:";
            // 
            // Cur_ScaleBox
            // 
            this.Cur_ScaleBox.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cur_ScaleBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Cur_ScaleBox.Location = new System.Drawing.Point(814, 52);
            this.Cur_ScaleBox.Name = "Cur_ScaleBox";
            this.Cur_ScaleBox.Size = new System.Drawing.Size(46, 22);
            this.Cur_ScaleBox.TabIndex = 11;
            // 
            // Cur_AbbreviationComboBox
            // 
            this.Cur_AbbreviationComboBox.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cur_AbbreviationComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Cur_AbbreviationComboBox.FormattingEnabled = true;
            this.Cur_AbbreviationComboBox.Location = new System.Drawing.Point(464, 52);
            this.Cur_AbbreviationComboBox.Name = "Cur_AbbreviationComboBox";
            this.Cur_AbbreviationComboBox.Size = new System.Drawing.Size(81, 25);
            this.Cur_AbbreviationComboBox.TabIndex = 13;
            this.Cur_AbbreviationComboBox.SelectedIndexChanged += new System.EventHandler(this.Cur_AbbreviationComboBox_SelectedIndexChanged_1);
            // 
            // Cur_OfficialRateLabel
            // 
            this.Cur_OfficialRateLabel.AutoSize = true;
            this.Cur_OfficialRateLabel.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cur_OfficialRateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Cur_OfficialRateLabel.Location = new System.Drawing.Point(868, 52);
            this.Cur_OfficialRateLabel.Name = "Cur_OfficialRateLabel";
            this.Cur_OfficialRateLabel.Size = new System.Drawing.Size(39, 17);
            this.Cur_OfficialRateLabel.TabIndex = 14;
            this.Cur_OfficialRateLabel.Text = "Курс:";
            // 
            // Cur_OfficialRateBox
            // 
            this.Cur_OfficialRateBox.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cur_OfficialRateBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Cur_OfficialRateBox.Location = new System.Drawing.Point(915, 52);
            this.Cur_OfficialRateBox.Name = "Cur_OfficialRateBox";
            this.Cur_OfficialRateBox.Size = new System.Drawing.Size(84, 22);
            this.Cur_OfficialRateBox.TabIndex = 15;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(156, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(735, 17);
            this.TitleLabel.TabIndex = 16;
            this.TitleLabel.Text = "Официальный курс белорусского рубля по отношению к иностранным валютам, устанавли" +
    "ваемого ежедневно, на сегодня";
            // 
            // Cur_NameBox
            // 
            this.Cur_NameBox.Location = new System.Drawing.Point(359, 83);
            this.Cur_NameBox.Name = "Cur_NameBox";
            this.Cur_NameBox.Size = new System.Drawing.Size(186, 22);
            this.Cur_NameBox.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 161);
            this.Controls.Add(this.Cur_NameBox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.Cur_OfficialRateBox);
            this.Controls.Add(this.Cur_OfficialRateLabel);
            this.Controls.Add(this.Cur_AbbreviationComboBox);
            this.Controls.Add(this.Cur_ScaleBox);
            this.Controls.Add(this.Cur_ScaleLabel);
            this.Controls.Add(this.Cur_AbbreviationLabel);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.Cur_IDBox);
            this.Controls.Add(this.Cur_IdLabel);
            this.Controls.Add(this.getNewsButton);
            this.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button getNewsButton;
        private System.Windows.Forms.Label Cur_IdLabel;
        private System.Windows.Forms.TextBox Cur_IDBox;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.TextBox DateBox;
        private System.Windows.Forms.Label Cur_AbbreviationLabel;
        private System.Windows.Forms.Label Cur_ScaleLabel;
        private System.Windows.Forms.TextBox Cur_ScaleBox;
        private System.Windows.Forms.ComboBox Cur_AbbreviationComboBox;
        private System.Windows.Forms.Label Cur_OfficialRateLabel;
        private System.Windows.Forms.TextBox Cur_OfficialRateBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox Cur_NameBox;
    }
}

