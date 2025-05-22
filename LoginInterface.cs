using ConsoleApplication3;

namespace ConsoleApplication3
{
    public partial class Login : Form
    {
        //// Ԥ���˺����루ʵ����Ŀ������ܴ洢��
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

            // ��ȡ�������ݲ�ȥ���ո�
            string inputAccount = account.Text.Trim();
            string inputPassword = Password.Text.Trim();

            // ��֤�ǿ�����
            if (string.IsNullOrEmpty(inputAccount))
            {
                MessageBox.Show("Please enter account��");
                return;
            }

            if (string.IsNullOrEmpty(inputPassword))
            {
                MessageBox.Show("Please enter password��");
                return;
            }

            // ��֤�˺�����
            if (atm.CheckPin(inputAccount,inputPassword))
            {
                MainWindow mainForm = new MainWindow(atm);
                // ��֤ͨ������������
                if (atm.SetActiveAccount(inputAccount))
                {
                    mainForm.Show();
                }
             
                // ���ص�¼����
                this.Hide();

                // �����ڹر�ʱ�˳�����
                mainForm.FormClosed += (s, args) =>
                mainForm.FormClosed += (s, args) =>
                {
                    this.Close();
                    Application.Exit(); // ȷ����ȫ�˳�
                };
            }
            else
            {
                MessageBox.Show("Account or password incorrect!");
                Password.Text = ""; // ��������
                account.Focus();    // �۽����˺������
            }
        }
    }
}
