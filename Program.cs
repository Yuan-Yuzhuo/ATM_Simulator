using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ConsoleApplication3
{   
    
    class Program
    {
        private Account[] ac = new Account[3];
        private readonly ATM atm;

        public Program()
        {
            // 参数顺序为：余额 密码 账户
            ac[0] = new Account(300, 1111, 111111);
            ac[1] = new Account(750, 2222, 222222);
            ac[2] = new Account(3000, 3333, 333333);

            atm = new ATM(ac);

        }

        static void Main(string[] args)
        {
            _ = new Program();
        }
    }
}
