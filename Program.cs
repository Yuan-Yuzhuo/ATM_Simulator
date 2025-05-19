using System;
using System.Threading;

// 这是一个简单的测试脚本，通过创建两个并行线程，成功模拟了在没有信号量介入的情况下，出现数据竞争状态的情形
// 也就是说，后端还需要完成的工作是：补充Semaphore，实现非竞争
namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 初始化账户：余额 1000，PIN: 1234，账号: 111111
            Account[] accounts = new Account[]
            {
                new Account(1000, 1234, 111111)
            };

            CentralSystem centralSystem = new CentralSystem(accounts);

            // 创建两个 ATM 操作同一个账户
            ATM atm1 = new ATM(centralSystem);
            ATM atm2 = new ATM(centralSystem);

            atm1.SetActiveAccount("111111");
            atm2.SetActiveAccount("111111");

            // 线程1：ATM1 取 700
            Thread t1 = new Thread(() =>
            {
                Console.WriteLine("ATM1 尝试取款 700...");
                bool success = atm1.TakeMoney(700);
                Console.WriteLine($"ATM1 取款结果: {(success ? "成功" : "失败")}");
            });

            // 线程2：ATM2 取 500
            Thread t2 = new Thread(() =>
            {
                Console.WriteLine("ATM2 尝试取款 500...");
                bool success = atm2.TakeMoney(500);
                Console.WriteLine($"ATM2 取款结果: {(success ? "成功" : "失败")}");
            });

            // 启动两个线程
            t1.Start();
            Thread.Sleep(500);
            t2.Start();

            // 等待两个线程执行完
            t1.Join();
            t2.Join();

            // 显示最终余额
            int finalBalance = centralSystem.CheckBalance(111111);
            Console.WriteLine($"最终账户余额：{finalBalance}");
        }
    }
}

// 这是一个简单的控制台程序，展示了这些函数应该以一个怎样的顺序调用以实现流程图
// 注意：GUI部分应该直接调用的仅有ATM部分，为保证代码的架构性，不宜直接操作账户类、系统类，如遇到问题，应优先提出issue，待co-workers解决

/*
using System;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 初始化账户
            Account[] accounts = new Account[]
            {
                new Account(1000, 1234, 111111),
                new Account(2000, 5678, 222222)
            };

            // 初始化中央系统和 ATM
            CentralSystem centralSystem = new CentralSystem(accounts);
            ATM atm = new ATM(centralSystem);

            Console.WriteLine("===== ATM Console Test =====");

            // 输入账号
            Console.Write("请输入账号: ");
            string inputAccount = Console.ReadLine();

            // 设置当前账户
            if (!atm.SetActiveAccount(inputAccount))
            {
                Console.WriteLine("账号不存在，退出程序。");
                return;
            }

            // 验证密码
            Console.Write("请输入密码: ");
            string inputPin = Console.ReadLine();
            if (!atm.CheckPin(inputAccount, inputPin))
            {
                Console.WriteLine("密码错误，退出程序。");
                return;
            }

            Console.WriteLine("\n登录成功！");

            // 查看余额
            int balance = atm.GetBalance(Convert.ToInt32(inputAccount));
            Console.WriteLine($"当前余额：{balance} 元");

            // 执行取钱操作
            Console.Write("请输入取款金额: ");
            int withdrawAmount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("正在取款（含延迟）...");
            bool withdrawSuccess = atm.TakeMoney(withdrawAmount);
            Console.WriteLine(withdrawSuccess ? "取款成功！" : "取款失败！");

            // 存钱操作
            Console.Write("请输入存款金额: ");
            int depositAmount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("正在存款（含延迟）...");
            atm.DepositMoney(depositAmount);
            Console.WriteLine("存款成功！");

            // 查看最终余额
            int newBalance = atm.GetBalance(Convert.ToInt32(inputAccount));
            Console.WriteLine($"最终余额：{newBalance} 元");

            Console.WriteLine("===== 测试结束 =====");
        }
    }
}
*/
