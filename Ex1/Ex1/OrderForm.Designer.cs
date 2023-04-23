namespace Ex1
{
    partial class OrderForm
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
            orderData = new DataGridView();
            addOrderButton = new Button();
            orderIDtxt = new TextBox();
            agentIDtxt = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            orderDatetxt = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)orderData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(314, 23);
            label1.Name = "label1";
            label1.Size = new Size(199, 38);
            label1.TabIndex = 0;
            label1.Text = "ORDER FORM";
            // 
            // orderData
            // 
            orderData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderData.Location = new Point(82, 83);
            orderData.Name = "orderData";
            orderData.RowHeadersWidth = 51;
            orderData.RowTemplate.Height = 29;
            orderData.Size = new Size(631, 163);
            orderData.TabIndex = 1;
            orderData.CellContentClick += orderData_CellContentClick;
            // 
            // addOrderButton
            // 
            addOrderButton.Location = new Point(582, 332);
            addOrderButton.Name = "addOrderButton";
            addOrderButton.Size = new Size(131, 29);
            addOrderButton.TabIndex = 2;
            addOrderButton.Text = "Add New Order";
            addOrderButton.UseVisualStyleBackColor = true;
            addOrderButton.Click += addOrderButton_Click;
            // 
            // orderIDtxt
            // 
            orderIDtxt.Location = new Point(245, 279);
            orderIDtxt.Name = "orderIDtxt";
            orderIDtxt.Size = new Size(210, 27);
            orderIDtxt.TabIndex = 3;
            orderIDtxt.TextChanged += textBox1_TextChanged;
            // 
            // agentIDtxt
            // 
            agentIDtxt.Location = new Point(245, 391);
            agentIDtxt.Name = "agentIDtxt";
            agentIDtxt.Size = new Size(210, 27);
            agentIDtxt.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 282);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 6;
            label2.Text = "Order ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 394);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 7;
            label3.Text = "Agent ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 332);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 8;
            label4.Text = "Order Date:";
            // 
            // orderDatetxt
            // 
            orderDatetxt.Format = DateTimePickerFormat.Short;
            orderDatetxt.Location = new Point(245, 334);
            orderDatetxt.Name = "orderDatetxt";
            orderDatetxt.Size = new Size(210, 27);
            orderDatetxt.TabIndex = 9;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(orderDatetxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(agentIDtxt);
            Controls.Add(orderIDtxt);
            Controls.Add(addOrderButton);
            Controls.Add(orderData);
            Controls.Add(label1);
            Name = "OrderForm";
            Text = "OrderForm";
            Load += OrderForm_Load;
            ((System.ComponentModel.ISupportInitialize)orderData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView orderData;
        private Button addOrderButton;
        private TextBox orderIDtxt;
        private TextBox agentIDtxt;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker orderDatetxt;
    }
}