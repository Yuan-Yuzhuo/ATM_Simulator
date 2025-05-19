using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApplication3
{

    public class ATM(CentralSystem system)
    {
        //ATM链接的数据中心（CentralSystem）
        private CentralSystem system = system;

        // ATM操作的“当前账户”
        private Account activeAccount = null;

        private Account FindAccount(string originalInput)
        {

            int input = Convert.ToInt32(originalInput);

            foreach (Account acc in system.AccountList)
            {
                if (acc.GetAccountNum() == input) return acc;
            }

            return null;
        }

        // 输入账户对象，密码，返回正确与否
        public bool CheckPin(string originalInputAccountNum, string originalInputPin)
        {
            int inputAccountNum = Convert.ToInt32(originalInputAccountNum);
            int inputPin = Convert.ToInt32(originalInputPin);
            return system.Check(inputAccountNum, inputPin);
        }

        // 设置“当前账户”，传入账号，返回成功与否
        public bool SetActiveAccount(string accNum)
        {
            this.activeAccount = FindAccount(accNum);
            if (activeAccount == null) return false;
            else return true;
        }

        // 操作一：显式余额，注意：若未能找到对应账户，返回-1
        public int GetBalance(int accountNum)
        {
            return system.CheckBalance(accountNum);
        }

        // 操作二：对当前账户取钱，输入取钱总额，执行操作，返回成功与否
        public bool TakeMoney(int amount)
        {
            if (activeAccount.GetBalance() > amount)
            {
                int balance = activeAccount.GetBalance();
                Thread.Sleep(2000);
                activeAccount.SetBalance(balance - amount);
                return true;
            }
            else
                return false;
        }

        // 操作三：对当前账户存钱，输入存钱总额，返回成功与否
        // (这个不会失败)
        public bool DepositMoney(int amount)
        {
            int balance = activeAccount.GetBalance();
            Thread.Sleep(2000);
            activeAccount.SetBalance(balance - amount);
            return true;
        }
    }
}