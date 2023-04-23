namespace Ex1
{
    partial class OrderDetailForm
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
            orderDetailData = new DataGridView();
            txt1 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt3 = new Label();
            txt2 = new Label();
            addOrderDetail = new Button();
            orderDetailIDtxt = new TextBox();
            orderIDtxt = new TextBox();
            itemIDtxt = new TextBox();
            quanlitytxt = new TextBox();
            unitAmounttxt = new TextBox();
            printBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)orderDetailData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(246, 22);
            label1.Name = "label1";
            label1.Size = new Size(300, 38);
            label1.TabIndex = 0;
            label1.Text = "ORDER DETAIL FORM";
            // 
            // orderDetailData
            // 
            orderDetailData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderDetailData.Location = new Point(69, 78);
            orderDetailData.Name = "orderDetailData";
            orderDetailData.RowHeadersWidth = 51;
            orderDetailData.RowTemplate.Height = 29;
            orderDetailData.Size = new Size(663, 160);
            orderDetailData.TabIndex = 1;
            orderDetailData.CellContentClick += orderDetailData_CellContentClick;
            // 
            // txt1
            // 
            txt1.AutoSize = true;
            txt1.Location = new Point(69, 274);
            txt1.Name = "txt1";
            txt1.Size = new Size(31, 20);
            txt1.TabIndex = 2;
            txt1.Text = "iD: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(450, 332);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 3;
            label3.Text = "Unit Amount:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(450, 277);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 4;
            label4.Text = "Quanlity:";
            label4.Click += label4_Click;
            // 
            // txt3
            // 
            txt3.AutoSize = true;
            txt3.Location = new Point(69, 393);
            txt3.Name = "txt3";
            txt3.Size = new Size(61, 20);
            txt3.TabIndex = 5;
            txt3.Text = "Item ID:";
            // 
            // txt2
            // 
            txt2.AutoSize = true;
            txt2.Location = new Point(69, 332);
            txt2.Name = "txt2";
            txt2.Size = new Size(69, 20);
            txt2.TabIndex = 6;
            txt2.Text = "Order ID:";
            // 
            // addOrderDetail
            // 
            addOrderDetail.Location = new Point(450, 386);
            addOrderDetail.Name = "addOrderDetail";
            addOrderDetail.Size = new Size(169, 34);
            addOrderDetail.TabIndex = 7;
            addOrderDetail.Text = "Add New Order Detail";
            addOrderDetail.UseVisualStyleBackColor = true;
            addOrderDetail.Click += addOrderDetail_Click;
            // 
            // orderDetailIDtxt
            // 
            orderDetailIDtxt.Location = new Point(140, 274);
            orderDetailIDtxt.Name = "orderDetailIDtxt";
            orderDetailIDtxt.Size = new Size(172, 27);
            orderDetailIDtxt.TabIndex = 8;
            // 
            // orderIDtxt
            // 
            orderIDtxt.Location = new Point(140, 329);
            orderIDtxt.Name = "orderIDtxt";
            orderIDtxt.Size = new Size(172, 27);
            orderIDtxt.TabIndex = 9;
            // 
            // itemIDtxt
            // 
            itemIDtxt.Location = new Point(140, 390);
            itemIDtxt.Name = "itemIDtxt";
            itemIDtxt.Size = new Size(172, 27);
            itemIDtxt.TabIndex = 10;
            // 
            // quanlitytxt
            // 
            quanlitytxt.Location = new Point(552, 270);
            quanlitytxt.Name = "quanlitytxt";
            quanlitytxt.Size = new Size(180, 27);
            quanlitytxt.TabIndex = 11;
            // 
            // unitAmounttxt
            // 
            unitAmounttxt.Location = new Point(552, 329);
            unitAmounttxt.Name = "unitAmounttxt";
            unitAmounttxt.Size = new Size(180, 27);
            unitAmounttxt.TabIndex = 12;
            unitAmounttxt.TextChanged += textBox5_TextChanged;
            // 
            // printBtn
            // 
            printBtn.Location = new Point(629, 386);
            printBtn.Name = "printBtn";
            printBtn.Size = new Size(103, 34);
            printBtn.TabIndex = 14;
            printBtn.Text = "Print";
            printBtn.UseVisualStyleBackColor = true;
            // 
            // OrderDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(printBtn);
            Controls.Add(unitAmounttxt);
            Controls.Add(quanlitytxt);
            Controls.Add(itemIDtxt);
            Controls.Add(orderIDtxt);
            Controls.Add(orderDetailIDtxt);
            Controls.Add(addOrderDetail);
            Controls.Add(txt2);
            Controls.Add(txt3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txt1);
            Controls.Add(orderDetailData);
            Controls.Add(label1);
            Name = "OrderDetailForm";
            Text = "OrderDetail";
            Load += OrderDetailForm_Load;
            ((System.ComponentModel.ISupportInitialize)orderDetailData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView orderDetailData;
        private Label txt1;
        private Label label3;
        private Label label4;
        private Label txt3;
        private Label txt2;
        private Button addOrderDetail;
        private TextBox orderDetailIDtxt;
        private TextBox orderIDtxt;
        private TextBox itemIDtxt;
        private TextBox quanlitytxt;
        private TextBox unitAmounttxt;
        private Button printBtn;
    }
}