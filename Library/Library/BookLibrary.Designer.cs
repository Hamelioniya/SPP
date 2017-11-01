namespace Library
{
    partial class BookLibrary
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
            this.booksTextBox = new System.Windows.Forms.RichTextBox();
            this.ShowAllBooksBtn = new System.Windows.Forms.Button();
            this.ShowPageOfBooksBtn = new System.Windows.Forms.Button();
            this.NextPageBtn = new System.Windows.Forms.Button();
            this.BackPageBtn = new System.Windows.Forms.Button();
            this.changeTextStyleBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // booksTextBox
            // 
            this.booksTextBox.Location = new System.Drawing.Point(12, 12);
            this.booksTextBox.Name = "booksTextBox";
            this.booksTextBox.Size = new System.Drawing.Size(324, 327);
            this.booksTextBox.TabIndex = 0;
            this.booksTextBox.Text = "";
            // 
            // ShowAllBooksBtn
            // 
            this.ShowAllBooksBtn.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowAllBooksBtn.ForeColor = System.Drawing.Color.Teal;
            this.ShowAllBooksBtn.Location = new System.Drawing.Point(365, 104);
            this.ShowAllBooksBtn.Name = "ShowAllBooksBtn";
            this.ShowAllBooksBtn.Size = new System.Drawing.Size(174, 56);
            this.ShowAllBooksBtn.TabIndex = 1;
            this.ShowAllBooksBtn.Text = "Все книги";
            this.ShowAllBooksBtn.UseVisualStyleBackColor = true;
            this.ShowAllBooksBtn.Click += new System.EventHandler(this.ShowAllBooksBtn_Click);
            // 
            // ShowPageOfBooksBtn
            // 
            this.ShowPageOfBooksBtn.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowPageOfBooksBtn.ForeColor = System.Drawing.Color.Teal;
            this.ShowPageOfBooksBtn.Location = new System.Drawing.Point(365, 166);
            this.ShowPageOfBooksBtn.Name = "ShowPageOfBooksBtn";
            this.ShowPageOfBooksBtn.Size = new System.Drawing.Size(174, 52);
            this.ShowPageOfBooksBtn.TabIndex = 2;
            this.ShowPageOfBooksBtn.Text = "Постраничный просмотр";
            this.ShowPageOfBooksBtn.UseVisualStyleBackColor = true;
            this.ShowPageOfBooksBtn.Click += new System.EventHandler(this.ShowPageOfBooksBtn_Click);
            // 
            // NextPageBtn
            // 
            this.NextPageBtn.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextPageBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.NextPageBtn.Location = new System.Drawing.Point(197, 345);
            this.NextPageBtn.Name = "NextPageBtn";
            this.NextPageBtn.Size = new System.Drawing.Size(42, 33);
            this.NextPageBtn.TabIndex = 3;
            this.NextPageBtn.Text = "->";
            this.NextPageBtn.UseVisualStyleBackColor = true;
            this.NextPageBtn.Visible = false;
            this.NextPageBtn.Click += new System.EventHandler(this.NextPageBtn_Click);
            // 
            // BackPageBtn
            // 
            this.BackPageBtn.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackPageBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackPageBtn.Location = new System.Drawing.Point(93, 345);
            this.BackPageBtn.Name = "BackPageBtn";
            this.BackPageBtn.Size = new System.Drawing.Size(42, 33);
            this.BackPageBtn.TabIndex = 4;
            this.BackPageBtn.Text = "<-";
            this.BackPageBtn.UseVisualStyleBackColor = true;
            this.BackPageBtn.Visible = false;
            this.BackPageBtn.Click += new System.EventHandler(this.BackPageBtn_Click);
            // 
            // changeTextStyleBtn
            // 
            this.changeTextStyleBtn.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeTextStyleBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.changeTextStyleBtn.Location = new System.Drawing.Point(365, 351);
            this.changeTextStyleBtn.Name = "changeTextStyleBtn";
            this.changeTextStyleBtn.Size = new System.Drawing.Size(174, 27);
            this.changeTextStyleBtn.TabIndex = 5;
            this.changeTextStyleBtn.Text = "Изменить стиль текста";
            this.changeTextStyleBtn.UseVisualStyleBackColor = true;
            this.changeTextStyleBtn.Click += new System.EventHandler(this.changeTextStyleBtn_Click);
            // 
            // BookLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 382);
            this.Controls.Add(this.changeTextStyleBtn);
            this.Controls.Add(this.BackPageBtn);
            this.Controls.Add(this.NextPageBtn);
            this.Controls.Add(this.ShowPageOfBooksBtn);
            this.Controls.Add(this.ShowAllBooksBtn);
            this.Controls.Add(this.booksTextBox);
            this.Name = "BookLibrary";
            this.Text = "Просмотр книг";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox booksTextBox;
        private System.Windows.Forms.Button ShowAllBooksBtn;
        private System.Windows.Forms.Button ShowPageOfBooksBtn;
        private System.Windows.Forms.Button NextPageBtn;
        private System.Windows.Forms.Button BackPageBtn;
        private System.Windows.Forms.Button changeTextStyleBtn;
    }
}

