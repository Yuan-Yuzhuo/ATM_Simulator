using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public class Account(int balance, int pin, int accountNum)
    {
        private int balance = balance;
        private int pin = pin;
        private int accountNum = accountNum;

        public int GetBalance()
        {
            return balance;
        }

        public void SetBalance(int newBalance)
        {
            balance = newBalance;
        }

        // 由于该类的构造函数可以直接设置新账户的账号密码，
        // 故在不考虑做更改密码功能的情况下，不设计SetPin，SetAccounNum
        public int GetAccountNum()
        {
            return accountNum;
        }

        public int GetPin()
        {
            return pin;
        }

    }
}