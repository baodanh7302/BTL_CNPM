namespace Ex1
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            UserNameInput = new TextBox();
            PasswordInput = new TextBox();
            LoginButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(303, 75);
            label1.Name = "label1";
            label1.Size = new Size(155, 31);
            label1.TabIndex = 0;
            label1.Text = "LOGIN FORM";

            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(210, 148);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 1;
            label2.Text = "Username:";

            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(210, 215);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // UserNameInput
            // 
            UserNameInput.Location = new Point(327, 145);
            UserNameInput.Name = "UserNameInput";
            UserNameInput.Size = new Size(178, 27);
            UserNameInput.TabIndex = 3;
            // 
            // PasswordInput
            // 
            PasswordInput.Location = new Point(327, 215);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.Size = new Size(178, 27);
            PasswordInput.TabIndex = 4;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(327, 295);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(94, 29);
            LoginButton.TabIndex = 5;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += loginButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(LoginButton);
            Controls.Add(PasswordInput);
            Controls.Add(UserNameInput);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox UserNameInput;
        private TextBox PasswordInput;
        private Button LoginButton;
    }
}