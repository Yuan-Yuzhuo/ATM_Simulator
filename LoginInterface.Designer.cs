namespace ConsoleApplication3
{
    partial class Login
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
            accountText = new Label();
            label3 = new Label();
            passwordText = new Label();
            account = new TextBox();
            Password = new TextBox();
            bankTitle = new Label();
            LoginText = new Label();
            LoginBtn = new Button();
            SuspendLayout();
            // 
            // accountText
            // 
            accountText.AutoSize = true;
            accountText.Font = new Font("Swis721 Blk BT", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accountText.Location = new Point(585, 441);
            accountText.Name = "accountText";
            accountText.Size = new Size(321, 77);
            accountText.TabIndex = 0;
            accountText.Text = "Account";
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 323);
            label3.TabIndex = 0;
            // 
            // passwordText
            // 
            passwordText.AutoSize = true;
            passwordText.Font = new Font("Swis721 Blk BT", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordText.Location = new Point(585, 676);
            passwordText.Name = "passwordText";
            passwordText.Size = new Size(376, 77);
            passwordText.TabIndex = 1;
            passwordText.Text = "Password";
            // 
            // account
            // 
            account.Font = new Font("Swis721 Blk BT", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            account.Location = new Point(1397, 441);
            account.Name = "account";
            account.Size = new Size(520, 84);
            account.TabIndex = 2;
            account.TextChanged += textBox1_TextChanged;
            // 
            // Password
            // 
            Password.Font = new Font("Swis721 Blk BT", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password.Location = new Point(1397, 673);
            Password.Name = "Password";
            Password.Size = new Size(520, 84);
            Password.TabIndex = 3;
            // 
            // bankTitle
            // 
            bankTitle.BackColor = Color.IndianRed;
            bankTitle.Font = new Font("Swis721 Blk BT", 25.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bankTitle.Location = new Point(0, 0);
            bankTitle.Name = "bankTitle";
            bankTitle.Size = new Size(2473, 172);
            bankTitle.TabIndex = 4;
            bankTitle.Text = "Group4 \r\nBank";
            // 
            // LoginText
            // 
            LoginText.AutoSize = true;
            LoginText.Font = new Font("Swis721 Blk BT", 25.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginText.Location = new Point(1095, 172);
            LoginText.Name = "LoginText";
            LoginText.Size = new Size(274, 82);
            LoginText.TabIndex = 5;
            LoginText.Text = "LOGIN";
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = SystemColors.ScrollBar;
            LoginBtn.Font = new Font("Swis721 Blk BT", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginBtn.ForeColor = Color.Brown;
            LoginBtn.Location = new Point(1080, 839);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(352, 93);
            LoginBtn.TabIndex = 6;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            ClientSize = new Size(2474, 1236);
            Controls.Add(LoginBtn);
            Controls.Add(LoginText);
            Controls.Add(bankTitle);
            Controls.Add(Password);
            Controls.Add(account);
            Controls.Add(passwordText);
            Controls.Add(label3);
            Controls.Add(accountText);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGIN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label accountText;
        private Label label3;
        private Label passwordText;
        private TextBox account;
        private TextBox Password;
        private Label bankTitle;
        private Label LoginText;
        private Button LoginBtn;
    }
}
