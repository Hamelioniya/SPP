namespace Shop
{
    partial class ShopForm
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.магазинToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кассаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.акцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.складToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productManufacturerLabel = new System.Windows.Forms.Label();
            this.productManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.productIdLabel = new System.Windows.Forms.Label();
            this.productIdTextBox = new System.Windows.Forms.TextBox();
            this.productPriceLabel = new System.Windows.Forms.Label();
            this.productPriceTextBox = new System.Windows.Forms.TextBox();
            this.addProductButton = new System.Windows.Forms.Button();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.scanProductButton = new System.Windows.Forms.Button();
            this.scanProductsTextBox = new System.Windows.Forms.RichTextBox();
            this.getCheckButton = new System.Windows.Forms.Button();
            this.totalPriceTextBox = new System.Windows.Forms.TextBox();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.productsCountTextBox = new System.Windows.Forms.TextBox();
            this.productsCountLabel = new System.Windows.Forms.Label();
            this.addDiscountButton = new System.Windows.Forms.Button();
            this.deleteDiscountButton = new System.Windows.Forms.Button();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.магазинToolStripMenuItem,
            this.складToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(564, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // магазинToolStripMenuItem
            // 
            this.магазинToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.кассаToolStripMenuItem,
            this.акцииToolStripMenuItem});
            this.магазинToolStripMenuItem.Name = "магазинToolStripMenuItem";
            this.магазинToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.магазинToolStripMenuItem.Text = "Магазин";
            // 
            // кассаToolStripMenuItem
            // 
            this.кассаToolStripMenuItem.Name = "кассаToolStripMenuItem";
            this.кассаToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.кассаToolStripMenuItem.Text = "Касса";
            this.кассаToolStripMenuItem.Click += new System.EventHandler(this.кассаToolStripMenuItem_Click);
            // 
            // акцииToolStripMenuItem
            // 
            this.акцииToolStripMenuItem.Name = "акцииToolStripMenuItem";
            this.акцииToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.акцииToolStripMenuItem.Text = "Акции";
            this.акцииToolStripMenuItem.Click += new System.EventHandler(this.акцииToolStripMenuItem_Click);
            // 
            // складToolStripMenuItem
            // 
            this.складToolStripMenuItem.Name = "складToolStripMenuItem";
            this.складToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.складToolStripMenuItem.Text = "Склад";
            this.складToolStripMenuItem.Click += new System.EventHandler(this.складToolStripMenuItem_Click);
            // 
            // itemsListBox
            // 
            this.itemsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.itemsListBox.DisplayMember = "name";
            this.itemsListBox.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itemsListBox.ForeColor = System.Drawing.Color.Black;
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.ItemHeight = 17;
            this.itemsListBox.Location = new System.Drawing.Point(282, 38);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(272, 225);
            this.itemsListBox.TabIndex = 1;
            this.itemsListBox.Visible = false;
            this.itemsListBox.SelectedIndexChanged += new System.EventHandler(this.productsListBox_SelectedIndexChanged);
            this.itemsListBox.DoubleClick += new System.EventHandler(this.scanProductButton_Click);
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.productNameTextBox.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.productNameTextBox.Location = new System.Drawing.Point(112, 38);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(142, 22);
            this.productNameTextBox.TabIndex = 2;
            this.productNameTextBox.Visible = false;
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.productNameLabel.Location = new System.Drawing.Point(12, 38);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(78, 19);
            this.productNameLabel.TabIndex = 3;
            this.productNameLabel.Text = "Название:";
            this.productNameLabel.Visible = false;
            // 
            // productManufacturerLabel
            // 
            this.productManufacturerLabel.AutoSize = true;
            this.productManufacturerLabel.Font = new System.Drawing.Font("Book Antiqua", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productManufacturerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.productManufacturerLabel.Location = new System.Drawing.Point(12, 66);
            this.productManufacturerLabel.Name = "productManufacturerLabel";
            this.productManufacturerLabel.Size = new System.Drawing.Size(95, 16);
            this.productManufacturerLabel.TabIndex = 5;
            this.productManufacturerLabel.Text = "Производитель:";
            this.productManufacturerLabel.Visible = false;
            // 
            // productManufacturerTextBox
            // 
            this.productManufacturerTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.productManufacturerTextBox.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productManufacturerTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.productManufacturerTextBox.Location = new System.Drawing.Point(113, 66);
            this.productManufacturerTextBox.Name = "productManufacturerTextBox";
            this.productManufacturerTextBox.Size = new System.Drawing.Size(142, 22);
            this.productManufacturerTextBox.TabIndex = 4;
            this.productManufacturerTextBox.Visible = false;
            // 
            // productIdLabel
            // 
            this.productIdLabel.AutoSize = true;
            this.productIdLabel.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productIdLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.productIdLabel.Location = new System.Drawing.Point(12, 94);
            this.productIdLabel.Name = "productIdLabel";
            this.productIdLabel.Size = new System.Drawing.Size(30, 19);
            this.productIdLabel.TabIndex = 7;
            this.productIdLabel.Text = "ID:";
            this.productIdLabel.Visible = false;
            // 
            // productIdTextBox
            // 
            this.productIdTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.productIdTextBox.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productIdTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.productIdTextBox.Location = new System.Drawing.Point(112, 94);
            this.productIdTextBox.Name = "productIdTextBox";
            this.productIdTextBox.Size = new System.Drawing.Size(142, 22);
            this.productIdTextBox.TabIndex = 6;
            this.productIdTextBox.Visible = false;
            // 
            // productPriceLabel
            // 
            this.productPriceLabel.AutoSize = true;
            this.productPriceLabel.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productPriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.productPriceLabel.Location = new System.Drawing.Point(10, 122);
            this.productPriceLabel.Name = "productPriceLabel";
            this.productPriceLabel.Size = new System.Drawing.Size(48, 19);
            this.productPriceLabel.TabIndex = 9;
            this.productPriceLabel.Text = "Цена:";
            this.productPriceLabel.Visible = false;
            // 
            // productPriceTextBox
            // 
            this.productPriceTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.productPriceTextBox.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productPriceTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.productPriceTextBox.Location = new System.Drawing.Point(112, 122);
            this.productPriceTextBox.Name = "productPriceTextBox";
            this.productPriceTextBox.Size = new System.Drawing.Size(142, 22);
            this.productPriceTextBox.TabIndex = 8;
            this.productPriceTextBox.Visible = false;
            // 
            // addProductButton
            // 
            this.addProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.addProductButton.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addProductButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.addProductButton.Location = new System.Drawing.Point(57, 169);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(109, 30);
            this.addProductButton.TabIndex = 10;
            this.addProductButton.Text = "Добавить";
            this.addProductButton.UseVisualStyleBackColor = false;
            this.addProductButton.Visible = false;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.deleteProductButton.Enabled = false;
            this.deleteProductButton.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteProductButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.deleteProductButton.Location = new System.Drawing.Point(363, 273);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(109, 30);
            this.deleteProductButton.TabIndex = 11;
            this.deleteProductButton.Text = "Удалить";
            this.deleteProductButton.UseVisualStyleBackColor = false;
            this.deleteProductButton.Visible = false;
            this.deleteProductButton.Click += new System.EventHandler(this.deleteProductButton_Click);
            // 
            // scanProductButton
            // 
            this.scanProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.scanProductButton.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scanProductButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.scanProductButton.Location = new System.Drawing.Point(363, 273);
            this.scanProductButton.Name = "scanProductButton";
            this.scanProductButton.Size = new System.Drawing.Size(109, 30);
            this.scanProductButton.TabIndex = 12;
            this.scanProductButton.Text = "Сканировать";
            this.scanProductButton.UseVisualStyleBackColor = false;
            this.scanProductButton.Visible = false;
            this.scanProductButton.Click += new System.EventHandler(this.scanProductButton_Click);
            // 
            // scanProductsTextBox
            // 
            this.scanProductsTextBox.Location = new System.Drawing.Point(48, 38);
            this.scanProductsTextBox.Name = "scanProductsTextBox";
            this.scanProductsTextBox.Size = new System.Drawing.Size(179, 185);
            this.scanProductsTextBox.TabIndex = 13;
            this.scanProductsTextBox.Text = "";
            this.scanProductsTextBox.Visible = false;
            // 
            // getCheckButton
            // 
            this.getCheckButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.getCheckButton.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getCheckButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.getCheckButton.Location = new System.Drawing.Point(63, 229);
            this.getCheckButton.Name = "getCheckButton";
            this.getCheckButton.Size = new System.Drawing.Size(144, 30);
            this.getCheckButton.TabIndex = 14;
            this.getCheckButton.Text = "Получить чек";
            this.getCheckButton.UseVisualStyleBackColor = false;
            this.getCheckButton.Visible = false;
            this.getCheckButton.Click += new System.EventHandler(this.getCheckButton_Click);
            // 
            // totalPriceTextBox
            // 
            this.totalPriceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.totalPriceTextBox.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalPriceTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.totalPriceTextBox.Location = new System.Drawing.Point(155, 279);
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.ReadOnly = true;
            this.totalPriceTextBox.Size = new System.Drawing.Size(100, 24);
            this.totalPriceTextBox.TabIndex = 15;
            this.totalPriceTextBox.Visible = false;
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalPriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.totalPriceLabel.Location = new System.Drawing.Point(53, 282);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(58, 19);
            this.totalPriceLabel.TabIndex = 16;
            this.totalPriceLabel.Text = "Сумма:";
            this.totalPriceLabel.Visible = false;
            // 
            // productsCountTextBox
            // 
            this.productsCountTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.productsCountTextBox.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productsCountTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.productsCountTextBox.Location = new System.Drawing.Point(112, 150);
            this.productsCountTextBox.Name = "productsCountTextBox";
            this.productsCountTextBox.Size = new System.Drawing.Size(142, 22);
            this.productsCountTextBox.TabIndex = 17;
            this.productsCountTextBox.Visible = false;
            // 
            // productsCountLabel
            // 
            this.productsCountLabel.AutoSize = true;
            this.productsCountLabel.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productsCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.productsCountLabel.Location = new System.Drawing.Point(11, 152);
            this.productsCountLabel.Name = "productsCountLabel";
            this.productsCountLabel.Size = new System.Drawing.Size(95, 19);
            this.productsCountLabel.TabIndex = 18;
            this.productsCountLabel.Text = "Количество:";
            this.productsCountLabel.Visible = false;
            // 
            // addDiscountButton
            // 
            this.addDiscountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.addDiscountButton.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addDiscountButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.addDiscountButton.Location = new System.Drawing.Point(70, 185);
            this.addDiscountButton.Name = "addDiscountButton";
            this.addDiscountButton.Size = new System.Drawing.Size(109, 30);
            this.addDiscountButton.TabIndex = 19;
            this.addDiscountButton.Text = "Добавить";
            this.addDiscountButton.UseVisualStyleBackColor = false;
            this.addDiscountButton.Visible = false;
            this.addDiscountButton.Click += new System.EventHandler(this.addDiscountButton_Click);
            // 
            // deleteDiscountButton
            // 
            this.deleteDiscountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.deleteDiscountButton.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteDiscountButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.deleteDiscountButton.Location = new System.Drawing.Point(363, 273);
            this.deleteDiscountButton.Name = "deleteDiscountButton";
            this.deleteDiscountButton.Size = new System.Drawing.Size(109, 30);
            this.deleteDiscountButton.TabIndex = 20;
            this.deleteDiscountButton.Text = "Удалить";
            this.deleteDiscountButton.UseVisualStyleBackColor = false;
            this.deleteDiscountButton.Visible = false;
            this.deleteDiscountButton.Click += new System.EventHandler(this.deleteDiscountButton_Click);
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 315);
            this.Controls.Add(this.deleteDiscountButton);
            this.Controls.Add(this.addDiscountButton);
            this.Controls.Add(this.productsCountLabel);
            this.Controls.Add(this.productsCountTextBox);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.totalPriceTextBox);
            this.Controls.Add(this.getCheckButton);
            this.Controls.Add(this.scanProductsTextBox);
            this.Controls.Add(this.scanProductButton);
            this.Controls.Add(this.deleteProductButton);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.productPriceLabel);
            this.Controls.Add(this.productPriceTextBox);
            this.Controls.Add(this.productIdLabel);
            this.Controls.Add(this.productIdTextBox);
            this.Controls.Add(this.productManufacturerLabel);
            this.Controls.Add(this.productManufacturerTextBox);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(this.itemsListBox);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "ShopForm";
            this.Text = "Магазин";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem магазинToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кассаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem акцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem складToolStripMenuItem;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label productManufacturerLabel;
        private System.Windows.Forms.TextBox productManufacturerTextBox;
        private System.Windows.Forms.Label productIdLabel;
        private System.Windows.Forms.TextBox productIdTextBox;
        private System.Windows.Forms.Label productPriceLabel;
        private System.Windows.Forms.TextBox productPriceTextBox;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.Button scanProductButton;
        private System.Windows.Forms.RichTextBox scanProductsTextBox;
        private System.Windows.Forms.Button getCheckButton;
        private System.Windows.Forms.TextBox totalPriceTextBox;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.TextBox productsCountTextBox;
        private System.Windows.Forms.Label productsCountLabel;
        private System.Windows.Forms.Button addDiscountButton;
        private System.Windows.Forms.Button deleteDiscountButton;
    }
}

