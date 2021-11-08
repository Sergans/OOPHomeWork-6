using System;
using System.Collections.Generic;

namespace Lesson_6_1
{
    public enum AccauntType { Credit, Debit }
    public class BankAccount
    {
        private decimal balance;
        public decimal Balance
        {
            get
            {
              return balance;
            }
        }
        public AccauntType Type { get; }
        private static int unicNomber;
        public int Nomber { get; }
        public BankAccount(decimal balance, AccauntType type)
        {
            this.balance = balance;
            this.Type = type;
            Nomber = ++unicNomber;
        }
        public void GetBalance(BankAccount accaunt, decimal summ)
        {
            this.balance = this.balance + summ;
            accaunt.balance = accaunt.balance - summ;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {   //проверка
            BankAccount bank1 = new BankAccount(4444, AccauntType.Credit);
            BankAccount bank2 = new BankAccount(3333, AccauntType.Debit);
            BankAccount bank3 = new BankAccount(2222, AccauntType.Credit);
            Console.WriteLine($"Номер счета - {bank1.Nomber}\r\nБаланс - {bank1.Balance}\r\nТип счета - {bank1.Type}");
            Console.WriteLine();
            Console.WriteLine($"Номер счета - {bank2.Nomber}\r\nБаланс - {bank2.Balance}\r\nТип счета - {bank2.Type}");
            Console.WriteLine();
            Console.WriteLine($"Номер счета - {bank3.Nomber}\r\nБаланс - {bank3.Balance}\r\nТип счета - {bank3.Type}");
            Console.WriteLine();
            bank1.GetBalance(bank2, 1111);
            Console.WriteLine($"Номер счета - {bank1.Nomber}\r\nБаланс - {bank1.Balance}\r\nТип счета - {bank1.Type}");
            Console.WriteLine();
            Console.WriteLine($"Номер счета - {bank2.Nomber}\r\nБаланс - {bank2.Balance}\r\nТип счета - {bank2.Type}");
            bank3.GetBalance(bank2, 2222);
            Console.WriteLine();
            Console.WriteLine($"Номер счета - {bank2.Nomber}\r\nБаланс - {bank2.Balance}\r\nТип счета - {bank2.Type}");
            Console.WriteLine();
            Console.WriteLine($"Номер счета - {bank3.Nomber}\r\nБаланс - {bank3.Balance}\r\nТип счета - {bank3.Type}");
        }
    }
}
