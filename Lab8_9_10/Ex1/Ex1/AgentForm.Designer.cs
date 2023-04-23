namespace Ex1
{
    partial class AgentForm
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
            agentData = new DataGridView();
            addAgentButton = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            agentIDtxt = new TextBox();
            agentNametxt = new TextBox();
            agentAddresstxt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)agentData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(303, 22);
            label1.Name = "label1";
            label1.Size = new Size(199, 38);
            label1.TabIndex = 0;
            label1.Text = "AGENT FORM";
            // 
            // agentData
            // 
            agentData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            agentData.Location = new Point(100, 82);
            agentData.Name = "agentData";
            agentData.RowHeadersWidth = 51;
            agentData.RowTemplate.Height = 29;
            agentData.Size = new Size(587, 168);
            agentData.TabIndex = 1;
            agentData.CellContentClick += agentData_CellContentClick;
            // 
            // addAgentButton
            // 
            addAgentButton.Location = new Point(546, 337);
            addAgentButton.Name = "addAgentButton";
            addAgentButton.Size = new Size(141, 29);
            addAgentButton.TabIndex = 2;
            addAgentButton.Text = "Add New Agent";
            addAgentButton.UseVisualStyleBackColor = true;
            addAgentButton.Click += addAgentButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 298);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 3;
            label2.Text = "Agent ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 346);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 4;
            label3.Text = "Agent Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 390);
            label4.Name = "label4";
            label4.Size = new Size(109, 20);
            label4.TabIndex = 5;
            label4.Text = "Agent Address:";
            // 
            // agentIDtxt
            // 
            agentIDtxt.Location = new Point(246, 295);
            agentIDtxt.Name = "agentIDtxt";
            agentIDtxt.Size = new Size(213, 27);
            agentIDtxt.TabIndex = 6;
            // 
            // agentNametxt
            // 
            agentNametxt.Location = new Point(246, 343);
            agentNametxt.Name = "agentNametxt";
            agentNametxt.Size = new Size(213, 27);
            agentNametxt.TabIndex = 7;
            agentNametxt.TextChanged += textBox2_TextChanged;
            // 
            // agentAddresstxt
            // 
            agentAddresstxt.Location = new Point(246, 387);
            agentAddresstxt.Name = "agentAddresstxt";
            agentAddresstxt.Size = new Size(213, 27);
            agentAddresstxt.TabIndex = 8;
            // 
            // AgentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(agentAddresstxt);
            Controls.Add(agentNametxt);
            Controls.Add(agentIDtxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(addAgentButton);
            Controls.Add(agentData);
            Controls.Add(label1);
            Name = "AgentForm";
            Text = "AgentForm";
            Load += AgentForm_Load;
            ((System.ComponentModel.ISupportInitialize)agentData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView agentData;
        private Button addAgentButton;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox agentIDtxt;
        private TextBox agentNametxt;
        private TextBox agentAddresstxt;
    }
}