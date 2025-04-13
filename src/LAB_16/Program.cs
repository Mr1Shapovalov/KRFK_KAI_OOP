using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
class LAB_16
{
    class BankAccount
    {
        private int balance = 0;
        private readonly object balanceLock = new object();
        public async Task DepositAsync(int amount)
        {
            await Task.Delay(100);
            lock (balanceLock)
            {
                balance += amount;
                Console.WriteLine($"Deposited +{amount}");
            }
        }
        public async Task WithdrawAsync(int amount)
        {
            await Task.Delay(100);
            lock (balanceLock)
            {
                if (balance >= amount)
                {
                    balance -= amount;
                    Console.WriteLine($"Withdrew -{amount}");
                }
                else
                {
                    Console.WriteLine($"Insufficient funds to withdraw -{amount}");
                }
            }
        }
        public int GetBalance()
        {
            lock (balanceLock)
            {
                return balance;
            }
        }
    }
    class Program
    {
        static async Task Main(string[] args)
        {
            BankAccount account = new BankAccount();
            List<Task> tasks = new List<Task>
        {
            account.DepositAsync(200),
            account.WithdrawAsync(100),
            account.DepositAsync(300),
            account.WithdrawAsync(50)
        };
            await Task.WhenAll(tasks);
            Console.WriteLine($"Final balance: {account.GetBalance()}");
        }
    }
}
