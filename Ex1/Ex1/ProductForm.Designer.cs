namespace Ex1
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            productData = new DataGridView();
            addProduct = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            itemIDtxt = new TextBox();
            itemNametxt = new TextBox();
            itemSizetxt = new TextBox();
            filterSizeProduct = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)productData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(258, 21);
            label1.Name = "label1";
            label1.Size = new Size(236, 38);
            label1.TabIndex = 0;
            label1.Text = "PRODUCT FORM";
            label1.Click += label1_Click;
            // 
            // productData
            // 
            productData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productData.Location = new Point(56, 75);
            productData.Name = "productData";
            productData.RowHeadersWidth = 51;
            productData.RowTemplate.Height = 29;
            productData.Size = new Size(625, 183);
            productData.TabIndex = 1;
            productData.CellContentClick += productData_CellContentClick;
            // 
            // addProduct
            // 
            addProduct.Location = new Point(468, 312);
            addProduct.Name = "addProduct";
            addProduct.Size = new Size(151, 28);
            addProduct.TabIndex = 2;
            addProduct.Text = "Add New Product";
            addProduct.UseVisualStyleBackColor = true;
            addProduct.Click += addProduct_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 285);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 3;
            label2.Text = "Item ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 334);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 4;
            label3.Text = "Item Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 380);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 5;
            label4.Text = "Size:";
            label4.Click += label4_Click;
            // 
            // itemIDtxt
            // 
            itemIDtxt.Location = new Point(170, 285);
            itemIDtxt.Name = "itemIDtxt";
            itemIDtxt.Size = new Size(167, 27);
            itemIDtxt.TabIndex = 6;
            // 
            // itemNametxt
            // 
            itemNametxt.Location = new Point(170, 334);
            itemNametxt.Name = "itemNametxt";
            itemNametxt.Size = new Size(167, 27);
            itemNametxt.TabIndex = 7;
            // 
            // itemSizetxt
            // 
            itemSizetxt.Location = new Point(170, 380);
            itemSizetxt.Name = "itemSizetxt";
            itemSizetxt.Size = new Size(167, 27);
            itemSizetxt.TabIndex = 8;
            // 
            // filterSizeProduct
            // 
            filterSizeProduct.FormattingEnabled = true;
            filterSizeProduct.Location = new Point(468, 363);
            filterSizeProduct.Name = "filterSizeProduct";
            filterSizeProduct.Size = new Size(151, 28);
            filterSizeProduct.TabIndex = 9;
            filterSizeProduct.SelectedIndexChanged += filterSizeProduct_SelectedIndexChanged;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(filterSizeProduct);
            Controls.Add(itemSizetxt);
            Controls.Add(itemNametxt);
            Controls.Add(itemIDtxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(addProduct);
            Controls.Add(productData);
            Controls.Add(label1);
            Name = "ProductForm";
            Text = "ProductForm";
            Load += ProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)productData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView productData;
        private Button addProduct;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox itemIDtxt;
        private TextBox itemNametxt;
        private TextBox itemSizetxt;
        private ComboBox filterSizeProduct;
    }
}