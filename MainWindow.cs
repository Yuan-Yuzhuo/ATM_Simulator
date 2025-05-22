using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication3
{
    public partial class MainWindow : Form
    {
        ATM atm;

        // 添加输入相关控件
        private TextBox wd_amountInput;
        private TextBox dp_amountInput;
        private Button confirmWithdrawBtn;
        private Button confirmDepositBtn;
        private bool isWithdrawMode = false;

        public MainWindow(ATM atm)
        {
            InitializeComponent();
            this.atm = atm;
        }

        private void Inquiry_Click(object sender, EventArgs e)
        {

            DisplayArea.Controls.Clear();
            Label showBalance = new Label();

            showBalance.AutoSize = true;
            showBalance.Font = new Font("Swis721 Blk BT", 25.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showBalance.Location = new Point(212, 419);
            showBalance.Text = $"Current balance：{atm.GetBalance(111111)}";
            showBalance.Size = new Size(843, 82);

            DisplayArea.Controls.Add(showBalance);
        }

        private void WithdrawBtn_Click(object sender, EventArgs e)
        {
            DisplayArea.Controls.Clear(); // 清空原有内容

            //添加提示语
            Label promptText = new Label();
            promptText.AutoSize = true;
            promptText.Font = new Font("Swis721 Blk BT", 25.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            promptText.Location = new Point(150, 300);
            promptText.Text = "Please enter the amount:";

            // 添加金额输入框
            wd_amountInput = new TextBox
            {
                Width = 300,
                Font = new Font("Swis721 Blk BT", 24F, FontStyle.Regular, GraphicsUnit.Point, 0),
                Location = new Point(500, 400),
                AutoSize = true,
                MaxLength = 7
            };

            // 添加确认按钮
            confirmWithdrawBtn = new Button
            {
                BackColor = SystemColors.ScrollBar,
                Font = new Font("Swis721 Blk BT", 22.125F, FontStyle.Regular, GraphicsUnit.Point, 0),
                Text = "Confirm",
                Location = new Point(500, 750),
                AutoSize = true
            };

            confirmWithdrawBtn.Click += ConfirmWithdrawBtn_Click;

            // 将控件添加到 Panel
            DisplayArea.Controls.Add(promptText);
            DisplayArea.Controls.Add(wd_amountInput);
            DisplayArea.Controls.Add(confirmWithdrawBtn);


            //重置输入
            wd_amountInput.Clear();
            wd_amountInput.Focus();

        }


        private void ConfirmWithdrawBtn_Click(object sender, EventArgs e)
        {
            string inputAmount = wd_amountInput.Text.Trim();
            if (atm.TakeMoney(int.Parse(inputAmount)))
            {
                DisplayArea.Controls.Clear();
                Label withdrawResult = new Label();
                withdrawResult.AutoSize = true;
                withdrawResult.Font = new Font("Swis721 Blk BT", 25.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
                withdrawResult.Location = new Point(200, 300);
                withdrawResult.Text = "Withdrawal successful!";
                DisplayArea.Controls.Add(withdrawResult);
            }
            else
            {
                DisplayArea.Controls.Clear();
                Label withdrawResult = new Label();
                withdrawResult.AutoSize = true;
                withdrawResult.Font = new Font("Swis721 Blk BT", 25.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
                withdrawResult.Location = new Point(200, 300);
                //可以根据具体失败原因多几个判断
                withdrawResult.Text = "Withdrawal failed!";
                DisplayArea.Controls.Add(withdrawResult);
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void depositBtn_Click(object sender, EventArgs e)
        {
            DisplayArea.Controls.Clear(); // 清空原有内容

            //添加提示语
            Label promptText = new Label();
            promptText.AutoSize = true;
            promptText.Font = new Font("Swis721 Blk BT", 25.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            promptText.Location = new Point(150, 300);
            promptText.Text = "Please enter the amount:";

            // 添加金额输入框
            dp_amountInput = new TextBox
            {
                Width = 300,
                Font = new Font("Swis721 Blk BT", 24F, FontStyle.Regular, GraphicsUnit.Point, 0),
                Location = new Point(500, 400),
                AutoSize = true,
                MaxLength = 7
            };

            // 添加确认按钮
            confirmDepositBtn = new Button
            {
                BackColor = SystemColors.ScrollBar,
                Font = new Font("Swis721 Blk BT", 22.125F, FontStyle.Regular, GraphicsUnit.Point, 0),
                Text = "Confirm",
                Location = new Point(500, 750),
                AutoSize = true
            };

            confirmDepositBtn.Click += ConfirmDepositBtn_Click;

            // 将控件添加到 Panel
            DisplayArea.Controls.Add(promptText);
            DisplayArea.Controls.Add(dp_amountInput);
            DisplayArea.Controls.Add(confirmDepositBtn);


            //重置输入
            dp_amountInput.Clear();
            dp_amountInput.Focus();
        }


        private void ConfirmDepositBtn_Click(object sender, EventArgs e)
        {
            string inputAmount = dp_amountInput.Text.Trim();
            if (atm.DepositMoney(int.Parse(inputAmount)))
            {
                DisplayArea.Controls.Clear();
                Label withdrawResult = new Label();
                withdrawResult.AutoSize = true;
                withdrawResult.Font = new Font("Swis721 Blk BT", 25.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
                withdrawResult.Location = new Point(150, 300);
                withdrawResult.Text = $"Deposit successful! \nThe current balance:{atm.GetBalance(111111)}";
                DisplayArea.Controls.Add(withdrawResult);
            }
            else
            {
                DisplayArea.Controls.Clear();
                Label withdrawResult = new Label();
                withdrawResult.AutoSize = true;
                withdrawResult.Font = new Font("Swis721 Blk BT", 25.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
                withdrawResult.Location = new Point(200, 300);
                //可以根据具体失败原因多几个判断
                withdrawResult.Text = "Deposit failed!";
                DisplayArea.Controls.Add(withdrawResult);
            }
        }
    }
}
