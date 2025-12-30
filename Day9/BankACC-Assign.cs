using System;
using System.IO;

namespace BankingSystem
{
    public class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message)
            : base(message)
        {
        }
    }
    public class BankOperationException : Exception
    {
        public BankOperationException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
    public class BankAccount
    {
        public string AccountNumber { get; private set; }
        public decimal Balance { get; private set; }
        public BankAccount(string accountNumber, decimal initialBalance)
        {
            if (string.IsNullOrWhiteSpace(accountNumber))
                throw new ArgumentException("Account number cannot be empty");

            if (initialBalance < 0)
                throw new ArgumentException("Initial balance cannot be negative");

            AccountNumber = accountNumber;
            Balance = initialBalance;
        }
        public void Withdraw(decimal amount)
        {
            try
            {
                if (amount <= 0)
                    throw new ArgumentException("Amount must be greater than zero");

                if (amount > Balance)
                    throw new InsufficientBalanceException("Insufficient balance");

                Balance -= amount;
                Console.WriteLine("Withdrawal successful.");
                Console.WriteLine("Remaining Balance: " + Balance);
            }
            catch (InsufficientBalanceException ex)
            {
                LogException(ex);
                throw;
            }
            catch (Exception ex)
            {
                LogException(ex);
                throw new BankOperationException("Bank operation failed", ex);
            }
        }
        private void LogException(Exception ex)
        {
            File.AppendAllText("error_log.txt",
                DateTime.Now + " | " +
                AccountNumber + " | " +
                ex.ToString() + Environment.NewLine);
        }
    }
class Program2
    {
        public static void calculate()
        {
            try
            {
                BankAccount acc = new BankAccount("ACC101", 5000);
                acc.Withdraw(7000); // exceeds balance
            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (BankOperationException ex)
            {
                Console.WriteLine("Bank Error: " + ex.Message);
                Console.WriteLine("Reason: " + ex.InnerException.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected Error: " + ex.Message);
            }
        }
    }
}
