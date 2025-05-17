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

        public int GetAccountNum()
        {
            return accountNum;
        }

        /*
         *   输入转出总额，执行账户扣款，返回操作成功与否
         */
        public bool DecrementBalance(int amount)
        {
            if (this.balance > amount)
            {
                balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        /*
         *  输入一个pin码，返回验证成功/失败
         */
        public bool CheckPin(int pinEntered)
        {
            if (pinEntered == pin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}