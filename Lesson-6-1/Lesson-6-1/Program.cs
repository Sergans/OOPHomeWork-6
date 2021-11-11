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
        public int Nomber { get; set; }// set для проверки
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
        public static bool operator ==(BankAccount bank1, BankAccount bank2)
        {
                return (bank1.Balance == bank2.Balance &&
                        bank1.Nomber == bank2.Nomber &&
                        bank1.Type == bank2.Type);
        }
        public static bool operator !=(BankAccount bank1, BankAccount bank2)
        {
                return (bank1.Balance != bank2.Balance &&
                        bank1.Nomber != bank2.Nomber &&
                        bank1.Type != bank2.Type);
        }
        public bool Equals(BankAccount obj)
        {
            return (this.Balance == obj.Balance &&
                    this.Nomber == obj.Nomber &&
                    this.Type == obj.Type);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();

        }

        public override string ToString()
        {
            return $"Номер счета - {this.Nomber}\r\nБаланс - {this.Balance}\r\nТип счета - {this.Type}";
        }

        
    }
    
    class Program
    {
        static void Main(string[] args)
        {   //проверка
            BankAccount bank1 = new BankAccount(4444, AccauntType.Credit);
            BankAccount bank2 = new BankAccount(4444, AccauntType.Credit);
            BankAccount bank3 = new BankAccount(2222, AccauntType.Credit);
            //bank2.Nomber = 1;// для проверки
            bool a = bank1 == bank2;
            Console.WriteLine(a);
            Console.WriteLine(bank1.ToString());
            Console.WriteLine(bank3.ToString());
            Console.WriteLine(bank1.GetHashCode()); //43495525;
            Console.WriteLine(bank2.GetHashCode()); //55915408;
            var c =bank1.Equals(bank2);
            Console.WriteLine(c);
        }
    }
}
