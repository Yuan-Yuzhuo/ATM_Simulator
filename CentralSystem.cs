
namespace ConsoleApplication3
{
    public class CentralSystem
    {
        public List<Account> AccountList;

        // 构造函数
        public CentralSystem(Account[] accounts)
        {
            AccountList = [.. accounts];
        }

        // 注册方法，依次传入余额，pin码，账号
        public void RegisterNewAccount(int balance, int pin, int accountNum)
        {
            Account NewAcc = new Account(balance, pin, accountNum);
            this.AccountList.Add(NewAcc);
        }

        // 查询余额方法，传入账号，传出余额，若未找到则传出-1
        public int CheckBalance(int accountNum)
        {
            foreach (Account acc in AccountList)
            {
                if (acc.GetAccountNum() == accountNum)
                {
                    return acc.GetBalance();
                }
            }
            return -1;
        }

        // 验证用户身份，传入账号，密码，依次比对，返回对应账户对象
        public Account CheckIdentity(int accountNum, int pinNum)
        {
            foreach (Account acc in AccountList)
            {
                if (acc.GetAccountNum() == accountNum && acc.GetPin() == pinNum)
                {
                    return acc;
                }
            }
            return null;
        }

        // 验证用户身份，传入账号，密码，依次比对，返回验证成功与否
        public bool Check(int accountNum, int pinNum)
        {
            if (CheckIdentity(accountNum, pinNum) != null) return true;
            else return false;
        }

        public bool ReduceBalance(int accountNum, int amount)
        {
            foreach (Account acc in AccountList)
            {
                if (acc.GetAccountNum() == accountNum && acc.GetBalance() >= amount)
                {
                    // 这里考虑设置人为延迟
                    acc.SetBalance(acc.GetBalance() - amount);
                    return true;
                }
            }
            return false;
        }

        public bool Deposit(int accountNum, int amount)
        {
            foreach (Account acc in AccountList)
            {
                if (acc.GetAccountNum() == accountNum)
                {
                    // 这里考虑设置人为延迟
                    acc.SetBalance(acc.GetBalance() + amount);
                    return true;
                }
            }
            return false;
        }
    }
}