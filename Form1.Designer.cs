namespace OOP3
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.CreateProduct = new System.Windows.Forms.Button();
            this.CreateMilkProduct = new System.Windows.Forms.Button();
            this.CreateToy = new System.Windows.Forms.Button();
            this.productTable = new System.Windows.Forms.TableLayoutPanel();
            this.ageText = new System.Windows.Forms.TextBox();
            this.expirationDateText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputProduct = new System.Windows.Forms.Button();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textOut = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.deleteMilkProduct = new System.Windows.Forms.Button();
            this.deleteProduct = new System.Windows.Forms.Button();
            this.deleteProductTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.deleteMilkProductTextBox = new System.Windows.Forms.TextBox();
            this.deleteToyTextBox = new System.Windows.Forms.TextBox();
            this.deleteToy = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.productTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(3, 32);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(94, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // CreateProduct
            // 
            this.CreateProduct.Location = new System.Drawing.Point(21, 12);
            this.CreateProduct.Name = "CreateProduct";
            this.CreateProduct.Size = new System.Drawing.Size(100, 36);
            this.CreateProduct.TabIndex = 3;
            this.CreateProduct.Text = "Создать продукт";
            this.CreateProduct.UseVisualStyleBackColor = true;
            this.CreateProduct.Click += new System.EventHandler(this.CreateProduct_Click);
            // 
            // CreateMilkProduct
            // 
            this.CreateMilkProduct.Location = new System.Drawing.Point(146, 12);
            this.CreateMilkProduct.Name = "CreateMilkProduct";
            this.CreateMilkProduct.Size = new System.Drawing.Size(122, 36);
            this.CreateMilkProduct.TabIndex = 4;
            this.CreateMilkProduct.Text = "Создать молочный продукт";
            this.CreateMilkProduct.UseVisualStyleBackColor = true;
            this.CreateMilkProduct.Click += new System.EventHandler(this.CreateMilkProduct_Click);
            // 
            // CreateToy
            // 
            this.CreateToy.Location = new System.Drawing.Point(299, 12);
            this.CreateToy.Name = "CreateToy";
            this.CreateToy.Size = new System.Drawing.Size(103, 36);
            this.CreateToy.TabIndex = 5;
            this.CreateToy.Text = "Создать игрушку";
            this.CreateToy.UseVisualStyleBackColor = true;
            this.CreateToy.Click += new System.EventHandler(this.CreateToy_Click);
            // 
            // productTable
            // 
            this.productTable.ColumnCount = 5;
            this.productTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.productTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.productTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.productTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.productTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.productTable.Controls.Add(this.ageText, 4, 1);
            this.productTable.Controls.Add(this.expirationDateText, 3, 1);
            this.productTable.Controls.Add(this.label4, 3, 0);
            this.productTable.Controls.Add(this.inputProduct, 0, 2);
            this.productTable.Controls.Add(this.nameTextBox, 0, 1);
            this.productTable.Controls.Add(this.priceTextBox, 1, 1);
            this.productTable.Controls.Add(this.label1, 0, 0);
            this.productTable.Controls.Add(this.label2, 1, 0);
            this.productTable.Controls.Add(this.label3, 2, 0);
            this.productTable.Controls.Add(this.dateTextBox, 2, 1);
            this.productTable.Controls.Add(this.label5, 4, 0);
            this.productTable.Location = new System.Drawing.Point(21, 63);
            this.productTable.Name = "productTable";
            this.productTable.RowCount = 3;
            this.productTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.productTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.productTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.productTable.Size = new System.Drawing.Size(572, 87);
            this.productTable.TabIndex = 6;
            this.productTable.Visible = false;
            // 
            // ageText
            // 
            this.ageText.Location = new System.Drawing.Point(420, 32);
            this.ageText.Name = "ageText";
            this.ageText.Size = new System.Drawing.Size(96, 20);
            this.ageText.TabIndex = 12;
            // 
            // expirationDateText
            // 
            this.expirationDateText.Location = new System.Drawing.Point(318, 32);
            this.expirationDateText.Name = "expirationDateText";
            this.expirationDateText.Size = new System.Drawing.Size(96, 20);
            this.expirationDateText.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Location = new System.Drawing.Point(318, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Срок годности";
            // 
            // inputProduct
            // 
            this.inputProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputProduct.Location = new System.Drawing.Point(3, 61);
            this.inputProduct.Name = "inputProduct";
            this.inputProduct.Size = new System.Drawing.Size(94, 23);
            this.inputProduct.TabIndex = 5;
            this.inputProduct.Text = "Ввод";
            this.inputProduct.UseVisualStyleBackColor = true;
            this.inputProduct.Click += new System.EventHandler(this.inputProduct_Click_1);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(103, 32);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(94, 20);
            this.priceTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(103, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Location = new System.Drawing.Point(203, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = " Дата изготовления";
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(203, 32);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(96, 20);
            this.dateTextBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label5.Location = new System.Drawing.Point(420, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Возрастное ограничение";
            // 
            // textOut
            // 
            this.textOut.Location = new System.Drawing.Point(21, 266);
            this.textOut.Multiline = true;
            this.textOut.Name = "textOut";
            this.textOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textOut.Size = new System.Drawing.Size(719, 162);
            this.textOut.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(168, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Введите номер молочного продукта";
            // 
            // deleteMilkProduct
            // 
            this.deleteMilkProduct.Location = new System.Drawing.Point(171, 219);
            this.deleteMilkProduct.Name = "deleteMilkProduct";
            this.deleteMilkProduct.Size = new System.Drawing.Size(185, 23);
            this.deleteMilkProduct.TabIndex = 10;
            this.deleteMilkProduct.Text = "Удалить молочный продукт";
            this.deleteMilkProduct.UseVisualStyleBackColor = true;
            this.deleteMilkProduct.Click += new System.EventHandler(this.deleteMilkProduct_Click);
            // 
            // deleteProduct
            // 
            this.deleteProduct.Location = new System.Drawing.Point(21, 219);
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Size = new System.Drawing.Size(129, 23);
            this.deleteProduct.TabIndex = 8;
            this.deleteProduct.Text = "Удалить продукт";
            this.deleteProduct.UseVisualStyleBackColor = true;
            this.deleteProduct.Click += new System.EventHandler(this.deleteObject_Click);
            // 
            // deleteProductTextBox
            // 
            this.deleteProductTextBox.Location = new System.Drawing.Point(21, 193);
            this.deleteProductTextBox.Name = "deleteProductTextBox";
            this.deleteProductTextBox.Size = new System.Drawing.Size(129, 20);
            this.deleteProductTextBox.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Введите номер продукта";
            // 
            // deleteMilkProductTextBox
            // 
            this.deleteMilkProductTextBox.Location = new System.Drawing.Point(171, 193);
            this.deleteMilkProductTextBox.Name = "deleteMilkProductTextBox";
            this.deleteMilkProductTextBox.Size = new System.Drawing.Size(187, 20);
            this.deleteMilkProductTextBox.TabIndex = 12;
            // 
            // deleteToyTextBox
            // 
            this.deleteToyTextBox.Location = new System.Drawing.Point(376, 193);
            this.deleteToyTextBox.Name = "deleteToyTextBox";
            this.deleteToyTextBox.Size = new System.Drawing.Size(187, 20);
            this.deleteToyTextBox.TabIndex = 13;
            // 
            // deleteToy
            // 
            this.deleteToy.Location = new System.Drawing.Point(376, 219);
            this.deleteToy.Name = "deleteToy";
            this.deleteToy.Size = new System.Drawing.Size(187, 23);
            this.deleteToy.TabIndex = 14;
            this.deleteToy.Text = "Удалить игрушку";
            this.deleteToy.UseVisualStyleBackColor = true;
            this.deleteToy.Click += new System.EventHandler(this.deleteToy_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(373, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Введите номер игрушки";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.deleteToy);
            this.Controls.Add(this.deleteToyTextBox);
            this.Controls.Add(this.deleteMilkProductTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.deleteProductTextBox);
            this.Controls.Add(this.deleteMilkProduct);
            this.Controls.Add(this.deleteProduct);
            this.Controls.Add(this.textOut);
            this.Controls.Add(this.productTable);
            this.Controls.Add(this.CreateToy);
            this.Controls.Add(this.CreateMilkProduct);
            this.Controls.Add(this.CreateProduct);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "OOP3";
            this.productTable.ResumeLayout(false);
            this.productTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button CreateProduct;
        private System.Windows.Forms.Button CreateMilkProduct;
        private System.Windows.Forms.Button CreateToy;
        private System.Windows.Forms.TableLayoutPanel productTable;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        public System.Windows.Forms.TextBox textOut;
        private System.Windows.Forms.Button inputProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox expirationDateText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ageText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button deleteMilkProduct;
        private System.Windows.Forms.Button deleteProduct;
        private System.Windows.Forms.TextBox deleteProductTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox deleteMilkProductTextBox;
        private System.Windows.Forms.TextBox deleteToyTextBox;
        private System.Windows.Forms.Button deleteToy;
        private System.Windows.Forms.Label label6;
    }
}

