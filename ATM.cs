using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApplication3
{

    public class ATM(Account[] ac)
    {
        // 该ATM的账户数组
        private readonly Account[] ac = ac;

        // 当前账户
        private readonly Account activeAccount = null;

        /*
         *    输入一个账号，返回对应账号的账户对象
         * 
         */

        private Account FindAccount(string originalInput)
        {

            int input = Convert.ToInt32(originalInput);

            for (int i = 0; i < this.ac.Length; i++)
            {
                if (ac[i].GetAccountNum() == input)
                {
                    return ac[i];
                }
            }

            return null;
        }

        // 输入账户对象，密码，返回正确与否
        public bool CheckPin(Account account, string originalInput)
        {
            int input = Convert.ToInt32(originalInput);
            return account.CheckPin(input);
        }

        // 操作一：输入账户对象和取钱总额，执行操作，返回成功与否
        public bool TakeMoney(Account account, int amount)
        {
            return account.DecrementBalance(amount);
        }

        // 操作二：显式余额
        public int GetBalance(Account account)
        {
            return account.GetBalance();
        }

        

    }
}