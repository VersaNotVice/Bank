using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rppoon_Zad_1_Bank
{
    internal class Korisnik : Osoba, IBankovniRacun 
    {
        
        public decimal Balance { get; set; }

        public int AccountNumber { get; set; }

        public void Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Console.WriteLine("Not enough money!");
            }
            else
            {
                Balance -= amount;
            }
        }
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
        public void ShowAccountInfo()
        {
            Console.WriteLine($"Account owner {FirstName} {LastName}");
            Console.WriteLine($"Account number {AccountNumber}");
            Console.WriteLine($"Account balance {Balance}");
        }
    }
}
