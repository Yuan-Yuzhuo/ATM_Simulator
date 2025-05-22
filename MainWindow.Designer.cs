namespace ConsoleApplication3
{
    partial class MainWindow
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
            bankTitle = new Label();
            InquiryBtn = new Button();
            WithdrawBtn = new Button();
            ExitBtn = new Button();
            ChangePinBtn = new Button();
            DisplayArea = new Panel();
            DefaultText = new Label();
            depositBtn = new Button();
            DisplayArea.SuspendLayout();
            SuspendLayout();
            // 
            // bankTitle
            // 
            bankTitle.BackColor = Color.IndianRed;
            bankTitle.Font = new Font("Swis721 Blk BT", 25.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bankTitle.Location = new Point(0, -2);
            bankTitle.Name = "bankTitle";
            bankTitle.Size = new Size(2474, 172);
            bankTitle.TabIndex = 5;
            bankTitle.Text = "Group4 \r\nBank";
            // 
            // InquiryBtn
            // 
            InquiryBtn.BackColor = SystemColors.ScrollBar;
            InquiryBtn.Font = new Font("Swis721 Blk BT", 22.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InquiryBtn.Location = new Point(13, 464);
            InquiryBtn.Name = "InquiryBtn";
            InquiryBtn.Size = new Size(480, 132);
            InquiryBtn.TabIndex = 7;
            InquiryBtn.Text = "Inquiry";
            InquiryBtn.UseVisualStyleBackColor = false;
            InquiryBtn.Click += Inquiry_Click;
            // 
            // WithdrawBtn
            // 
            WithdrawBtn.BackColor = SystemColors.ScrollBar;
            WithdrawBtn.Font = new Font("Swis721 Blk BT", 22.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WithdrawBtn.Location = new Point(13, 641);
            WithdrawBtn.Name = "WithdrawBtn";
            WithdrawBtn.Size = new Size(480, 132);
            WithdrawBtn.TabIndex = 8;
            WithdrawBtn.Text = "Withdraw";
            WithdrawBtn.UseVisualStyleBackColor = false;
            WithdrawBtn.Click += WithdrawBtn_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.BackColor = SystemColors.ScrollBar;
            ExitBtn.Font = new Font("Swis721 Blk BT", 22.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExitBtn.Location = new Point(13, 964);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(480, 132);
            ExitBtn.TabIndex = 9;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = false;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // ChangePinBtn
            // 
            ChangePinBtn.BackColor = SystemColors.ScrollBar;
            ChangePinBtn.Font = new Font("Swis721 Blk BT", 22.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ChangePinBtn.Location = new Point(1994, 464);
            ChangePinBtn.Name = "ChangePinBtn";
            ChangePinBtn.Size = new Size(480, 132);
            ChangePinBtn.TabIndex = 10;
            ChangePinBtn.Text = "Change Pin";
            ChangePinBtn.UseVisualStyleBackColor = false;
            // 
            // DisplayArea
            // 
            DisplayArea.BackColor = SystemColors.ButtonHighlight;
            DisplayArea.Controls.Add(DefaultText);
            DisplayArea.Location = new Point(644, 202);
            DisplayArea.Name = "DisplayArea";
            DisplayArea.Size = new Size(1238, 922);
            DisplayArea.TabIndex = 11;
            // 
            // DefaultText
            // 
            DefaultText.AutoSize = true;
            DefaultText.Font = new Font("Swis721 Blk BT", 25.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DefaultText.Location = new Point(212, 419);
            DefaultText.Name = "DefaultText";
            DefaultText.Size = new Size(843, 82);
            DefaultText.TabIndex = 0;
            DefaultText.Text = "Please select service";
            // 
            // depositBtn
            // 
            depositBtn.BackColor = SystemColors.ScrollBar;
            depositBtn.Font = new Font("Swis721 Blk BT", 22.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            depositBtn.Location = new Point(1994, 641);
            depositBtn.Name = "depositBtn";
            depositBtn.Size = new Size(480, 132);
            depositBtn.TabIndex = 12;
            depositBtn.Text = "Deposit";
            depositBtn.UseVisualStyleBackColor = false;
            depositBtn.Click += depositBtn_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2474, 1236);
            Controls.Add(depositBtn);
            Controls.Add(DisplayArea);
            Controls.Add(InquiryBtn);
            Controls.Add(ChangePinBtn);
            Controls.Add(ExitBtn);
            Controls.Add(WithdrawBtn);
            Controls.Add(bankTitle);
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainWindow";
            DisplayArea.ResumeLayout(false);
            DisplayArea.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label bankTitle;
        private Label label1;
        private Button button1;
        private Button WithdrawBtn;
        private Button ExitBtn;
        private Button button2;
        private Button InquiryBtn;
        private Button ChangePinBtn;
        private Panel DisplayArea;
        private Label DefaultText;
        private Button depositBtn;
    }
}