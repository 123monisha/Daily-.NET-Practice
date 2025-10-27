//using System;

//namespace Daily_Practice
//{
//    public class Account
//    {
//        public decimal accNo;
//        public decimal Balance;

//        public Account(decimal accno,decimal balance)
//        {
//            accNo = accno;
//            Balance = balance;
//        }
//        public virtual void Deposit(decimal amount)
//        {
//            Balance += amount;
//            Console.WriteLine($"Congrdulation {amount} was credited your account");
//        }
//        public virtual void Withdraw(decimal amount)
//        {
//            if(Balance>amount)
//            {
//                Balance -= amount;
//                Console.WriteLine($"Hello {amount} was Debited from your account");
//            }
//            else
//            {
//                Console.WriteLine("Sosrry..Insufficint balance!");
//            }
//        }
//        public virtual void getBalance()
//        {
//            Console.WriteLine($" {Balance} You have. Thank You");
//        }
//    }
//    public class savingsAccount : Account
//    {
//        public double interestRate = 0.06;
//        public savingsAccount(decimal accno, decimal balance) : base(accno, balance)
//        { }
//        public void addInterest()
//        {
//            double interset = 1000 * interestRate;
//            Console.WriteLine("Interest added " + interset);
//        }
//        public override void Withdraw(decimal amount)
//        {
//            base.Withdraw(amount);
//            Console.WriteLine("withdrwal from your savings account");
//        }
//    }
//    public class currentAccount : Account
//    {
//        public currentAccount(decimal accno,decimal balance) : base(accno, balance) { }
//        public override void Withdraw(decimal amount)
//        {

//            base.Withdraw(amount);
//            Console.WriteLine("withdrawal from your current account");
//        }

//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Account a = new Account(111,1000000);
//            a.Deposit(300);
//            a.Withdraw(600);
//            a.getBalance();

//            savingsAccount s = new savingsAccount(111,700);
//            s.Withdraw(900);

//            currentAccount c = new currentAccount(111, 900);
//            c.Withdraw(500);

//        }
//    }
//}
