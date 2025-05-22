using ConsoleApplication3;

namespace ConsoleApplication3
{
    public partial class Login : Form
    {
        //// 预设账号密码（实际项目建议加密存储）
        //private const string presetAccount = "111111";
        //private const string presetPassword = "1234";


        Account[] accounts = new Account[]
        {
             new Account(1000, 1234, 111111)
        };

        ATM atm;
        CentralSystem centralSystem;

        public Login()
        {
            InitializeComponent();
            centralSystem = new CentralSystem(accounts);
            atm = new ATM(centralSystem);
            Password.PasswordChar = '*';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {

            // 获取输入内容并去除空格
            string inputAccount = account.Text.Trim();
            string inputPassword = Password.Text.Trim();

            // 验证非空输入
            if (string.IsNullOrEmpty(inputAccount))
            {
                MessageBox.Show("Please enter account！");
                return;
            }

            if (string.IsNullOrEmpty(inputPassword))
            {
                MessageBox.Show("Please enter password！");
                return;
            }

            // 验证账号密码
            if (atm.CheckPin(inputAccount,inputPassword))
            {
                MainWindow mainForm = new MainWindow(atm);
                // 验证通过，打开主界面
                if (atm.SetActiveAccount(inputAccount))
                {
                    mainForm.Show();
                }
             
                // 隐藏登录窗口
                this.Hide();

                // 主窗口关闭时退出程序
                mainForm.FormClosed += (s, args) =>
                mainForm.FormClosed += (s, args) =>
                {
                    this.Close();
                    Application.Exit(); // 确保完全退出
                };
            }
            else
            {
                MessageBox.Show("Account or password incorrect!");
                Password.Text = ""; // 清空密码框
                account.Focus();    // 聚焦到账号输入框
            }
        }
    }
}
