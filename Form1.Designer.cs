
namespace _2
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
            this.textBoxStoncs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateProductBtn = new System.Windows.Forms.Button();
            this.PanelCreateProduct = new System.Windows.Forms.Panel();
            this.StartCreateProductBtn = new System.Windows.Forms.Button();
            this.CreateProductCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CreateProductPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CreateProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.SellProductPanel = new System.Windows.Forms.Panel();
            this.StartSellProductBtn = new System.Windows.Forms.Button();
            this.SellProductCount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SellProductName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SellProductBtn = new System.Windows.Forms.Button();
            this.AddProductPanel = new System.Windows.Forms.Panel();
            this.StartAddProductBtn = new System.Windows.Forms.Button();
            this.AddProductCount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AddProductName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AddProductBtn = new System.Windows.Forms.Button();
            this.PanelCreateProduct.SuspendLayout();
            this.SellProductPanel.SuspendLayout();
            this.AddProductPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxStoncs
            // 
            this.textBoxStoncs.AutoCompleteCustomSource.AddRange(new string[] {
            "0"});
            this.textBoxStoncs.Location = new System.Drawing.Point(4, 469);
            this.textBoxStoncs.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStoncs.Name = "textBoxStoncs";
            this.textBoxStoncs.ReadOnly = true;
            this.textBoxStoncs.Size = new System.Drawing.Size(133, 22);
            this.textBoxStoncs.TabIndex = 0;
            this.textBoxStoncs.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 449);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Прибыль";
            // 
            // CreateProductBtn
            // 
            this.CreateProductBtn.Location = new System.Drawing.Point(13, 33);
            this.CreateProductBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CreateProductBtn.Name = "CreateProductBtn";
            this.CreateProductBtn.Size = new System.Drawing.Size(136, 28);
            this.CreateProductBtn.TabIndex = 3;
            this.CreateProductBtn.Text = "Создать товар";
            this.CreateProductBtn.UseVisualStyleBackColor = true;
            this.CreateProductBtn.Click += new System.EventHandler(this.CreateProductBtn_Click);
            // 
            // PanelCreateProduct
            // 
            this.PanelCreateProduct.Controls.Add(this.StartCreateProductBtn);
            this.PanelCreateProduct.Controls.Add(this.CreateProductCount);
            this.PanelCreateProduct.Controls.Add(this.label4);
            this.PanelCreateProduct.Controls.Add(this.CreateProductPrice);
            this.PanelCreateProduct.Controls.Add(this.label3);
            this.PanelCreateProduct.Controls.Add(this.CreateProductName);
            this.PanelCreateProduct.Controls.Add(this.label2);
            this.PanelCreateProduct.Location = new System.Drawing.Point(16, 70);
            this.PanelCreateProduct.Margin = new System.Windows.Forms.Padding(4);
            this.PanelCreateProduct.Name = "PanelCreateProduct";
            this.PanelCreateProduct.Size = new System.Drawing.Size(215, 233);
            this.PanelCreateProduct.TabIndex = 4;
            this.PanelCreateProduct.Visible = false;
            // 
            // StartCreateProductBtn
            // 
            this.StartCreateProductBtn.Location = new System.Drawing.Point(4, 171);
            this.StartCreateProductBtn.Margin = new System.Windows.Forms.Padding(4);
            this.StartCreateProductBtn.Name = "StartCreateProductBtn";
            this.StartCreateProductBtn.Size = new System.Drawing.Size(207, 58);
            this.StartCreateProductBtn.TabIndex = 6;
            this.StartCreateProductBtn.Text = "Создать товары\\товары\r\n";
            this.StartCreateProductBtn.UseVisualStyleBackColor = true;
            this.StartCreateProductBtn.Click += new System.EventHandler(this.StartCreateProductBtn_Click);
            // 
            // CreateProductCount
            // 
            this.CreateProductCount.Location = new System.Drawing.Point(40, 139);
            this.CreateProductCount.Margin = new System.Windows.Forms.Padding(4);
            this.CreateProductCount.Name = "CreateProductCount";
            this.CreateProductCount.Size = new System.Drawing.Size(132, 22);
            this.CreateProductCount.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Количество";
            // 
            // CreateProductPrice
            // 
            this.CreateProductPrice.Location = new System.Drawing.Point(40, 81);
            this.CreateProductPrice.Margin = new System.Windows.Forms.Padding(4);
            this.CreateProductPrice.Name = "CreateProductPrice";
            this.CreateProductPrice.Size = new System.Drawing.Size(132, 22);
            this.CreateProductPrice.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Цена";
            // 
            // CreateProductName
            // 
            this.CreateProductName.Location = new System.Drawing.Point(40, 25);
            this.CreateProductName.Margin = new System.Windows.Forms.Padding(4);
            this.CreateProductName.Name = "CreateProductName";
            this.CreateProductName.Size = new System.Drawing.Size(132, 22);
            this.CreateProductName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Название";
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.ItemHeight = 16;
            this.listBoxProducts.Location = new System.Drawing.Point(477, 22);
            this.listBoxProducts.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(572, 516);
            this.listBoxProducts.TabIndex = 6;
            // 
            // SellProductPanel
            // 
            this.SellProductPanel.Controls.Add(this.StartSellProductBtn);
            this.SellProductPanel.Controls.Add(this.SellProductCount);
            this.SellProductPanel.Controls.Add(this.label5);
            this.SellProductPanel.Controls.Add(this.SellProductName);
            this.SellProductPanel.Controls.Add(this.label7);
            this.SellProductPanel.Location = new System.Drawing.Point(4, 104);
            this.SellProductPanel.Margin = new System.Windows.Forms.Padding(4);
            this.SellProductPanel.Name = "SellProductPanel";
            this.SellProductPanel.Size = new System.Drawing.Size(243, 233);
            this.SellProductPanel.TabIndex = 8;
            this.SellProductPanel.Visible = false;
            // 
            // StartSellProductBtn
            // 
            this.StartSellProductBtn.Location = new System.Drawing.Point(4, 142);
            this.StartSellProductBtn.Margin = new System.Windows.Forms.Padding(4);
            this.StartSellProductBtn.Name = "StartSellProductBtn";
            this.StartSellProductBtn.Size = new System.Drawing.Size(207, 58);
            this.StartSellProductBtn.TabIndex = 6;
            this.StartSellProductBtn.Text = "Продать товары\\товары\r\n";
            this.StartSellProductBtn.UseVisualStyleBackColor = true;
            this.StartSellProductBtn.Click += new System.EventHandler(this.StartSellProductBtn_Click);
            // 
            // SellProductCount
            // 
            this.SellProductCount.Location = new System.Drawing.Point(40, 110);
            this.SellProductCount.Margin = new System.Windows.Forms.Padding(4);
            this.SellProductCount.Name = "SellProductCount";
            this.SellProductCount.Size = new System.Drawing.Size(132, 22);
            this.SellProductCount.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Количество";
            // 
            // SellProductName
            // 
            this.SellProductName.Location = new System.Drawing.Point(40, 53);
            this.SellProductName.Margin = new System.Windows.Forms.Padding(4);
            this.SellProductName.Name = "SellProductName";
            this.SellProductName.Size = new System.Drawing.Size(132, 22);
            this.SellProductName.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 32);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Название";
            // 
            // SellProductBtn
            // 
            this.SellProductBtn.Location = new System.Drawing.Point(157, 34);
            this.SellProductBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SellProductBtn.Name = "SellProductBtn";
            this.SellProductBtn.Size = new System.Drawing.Size(136, 28);
            this.SellProductBtn.TabIndex = 7;
            this.SellProductBtn.Text = "Продать товар";
            this.SellProductBtn.UseVisualStyleBackColor = true;
            this.SellProductBtn.Click += new System.EventHandler(this.SellProductBtn_Click);
            // 
            // AddProductPanel
            // 
            this.AddProductPanel.Controls.Add(this.StartAddProductBtn);
            this.AddProductPanel.Controls.Add(this.AddProductCount);
            this.AddProductPanel.Controls.Add(this.label6);
            this.AddProductPanel.Controls.Add(this.AddProductName);
            this.AddProductPanel.Controls.Add(this.label8);
            this.AddProductPanel.Location = new System.Drawing.Point(255, 93);
            this.AddProductPanel.Margin = new System.Windows.Forms.Padding(4);
            this.AddProductPanel.Name = "AddProductPanel";
            this.AddProductPanel.Size = new System.Drawing.Size(220, 206);
            this.AddProductPanel.TabIndex = 10;
            this.AddProductPanel.Visible = false;
            // 
            // StartAddProductBtn
            // 
            this.StartAddProductBtn.Location = new System.Drawing.Point(4, 142);
            this.StartAddProductBtn.Margin = new System.Windows.Forms.Padding(4);
            this.StartAddProductBtn.Name = "StartAddProductBtn";
            this.StartAddProductBtn.Size = new System.Drawing.Size(207, 58);
            this.StartAddProductBtn.TabIndex = 6;
            this.StartAddProductBtn.Text = "Добавить товары\\товары\r\n";
            this.StartAddProductBtn.UseVisualStyleBackColor = true;
            this.StartAddProductBtn.Click += new System.EventHandler(this.StartAddProductBtn_Click);
            // 
            // AddProductCount
            // 
            this.AddProductCount.Location = new System.Drawing.Point(40, 110);
            this.AddProductCount.Margin = new System.Windows.Forms.Padding(4);
            this.AddProductCount.Name = "AddProductCount";
            this.AddProductCount.Size = new System.Drawing.Size(132, 22);
            this.AddProductCount.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 89);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Количество";
            // 
            // AddProductName
            // 
            this.AddProductName.Location = new System.Drawing.Point(40, 53);
            this.AddProductName.Margin = new System.Windows.Forms.Padding(4);
            this.AddProductName.Name = "AddProductName";
            this.AddProductName.Size = new System.Drawing.Size(132, 22);
            this.AddProductName.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 32);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Название";
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.Location = new System.Drawing.Point(301, 33);
            this.AddProductBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(136, 28);
            this.AddProductBtn.TabIndex = 9;
            this.AddProductBtn.Text = "Добавить товар";
            this.AddProductBtn.UseVisualStyleBackColor = true;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.AddProductPanel);
            this.Controls.Add(this.AddProductBtn);
            this.Controls.Add(this.SellProductPanel);
            this.Controls.Add(this.SellProductBtn);
            this.Controls.Add(this.listBoxProducts);
            this.Controls.Add(this.PanelCreateProduct);
            this.Controls.Add(this.CreateProductBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxStoncs);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelCreateProduct.ResumeLayout(false);
            this.PanelCreateProduct.PerformLayout();
            this.SellProductPanel.ResumeLayout(false);
            this.SellProductPanel.PerformLayout();
            this.AddProductPanel.ResumeLayout(false);
            this.AddProductPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStoncs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreateProductBtn;
        private System.Windows.Forms.Panel PanelCreateProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StartCreateProductBtn;
        private System.Windows.Forms.TextBox CreateProductCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CreateProductPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CreateProductName;
        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.Panel SellProductPanel;
        private System.Windows.Forms.Button StartSellProductBtn;
        private System.Windows.Forms.TextBox SellProductCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SellProductName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SellProductBtn;
        private System.Windows.Forms.Panel AddProductPanel;
        private System.Windows.Forms.Button StartAddProductBtn;
        private System.Windows.Forms.TextBox AddProductCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AddProductName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button AddProductBtn;
    }
}

