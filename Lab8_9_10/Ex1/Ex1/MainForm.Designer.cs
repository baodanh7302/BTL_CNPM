namespace Ex1
{
    partial class MainForm
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
            Main_Form = new Label();
            ProductButton = new Button();
            AgentButton = new Button();
            OrderButton = new Button();
            closeButton = new Button();
            OrderDetailForm = new Button();
            SuspendLayout();
            // 
            // Main_Form
            // 
            Main_Form.AutoSize = true;
            Main_Form.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Main_Form.Location = new Point(309, 36);
            Main_Form.Name = "Main_Form";
            Main_Form.Size = new Size(184, 38);
            Main_Form.TabIndex = 0;
            Main_Form.Text = "MAIN FORM";
            // 
            // ProductButton
            // 
            ProductButton.Location = new Point(350, 122);
            ProductButton.Name = "ProductButton";
            ProductButton.Size = new Size(94, 34);
            ProductButton.TabIndex = 1;
            ProductButton.Text = "Products";
            ProductButton.UseVisualStyleBackColor = true;
            ProductButton.Click += ProductButton_Click;
            // 
            // AgentButton
            // 
            AgentButton.Location = new Point(197, 211);
            AgentButton.Name = "AgentButton";
            AgentButton.Size = new Size(94, 29);
            AgentButton.TabIndex = 2;
            AgentButton.Text = "Agents";
            AgentButton.UseVisualStyleBackColor = true;
            AgentButton.Click += AgentButton_Click;
            // 
            // OrderButton
            // 
            OrderButton.Location = new Point(504, 211);
            OrderButton.Name = "OrderButton";
            OrderButton.Size = new Size(94, 29);
            OrderButton.TabIndex = 3;
            OrderButton.Text = "Order";
            OrderButton.UseVisualStyleBackColor = true;
            OrderButton.Click += OrderButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(350, 211);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(94, 29);
            closeButton.TabIndex = 4;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // OrderDetailForm
            // 
            OrderDetailForm.Location = new Point(341, 305);
            OrderDetailForm.Name = "OrderDetailForm";
            OrderDetailForm.Size = new Size(116, 34);
            OrderDetailForm.TabIndex = 5;
            OrderDetailForm.Text = "Order Detail";
            OrderDetailForm.UseVisualStyleBackColor = true;
            OrderDetailForm.Click += OrderDetailForm_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(OrderDetailForm);
            Controls.Add(closeButton);
            Controls.Add(OrderButton);
            Controls.Add(AgentButton);
            Controls.Add(ProductButton);
            Controls.Add(Main_Form);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Main_Form;
        private Button ProductButton;
        private Button AgentButton;
        private Button OrderButton;
        private Button closeButton;
        private Button OrderDetailForm;
    }
}