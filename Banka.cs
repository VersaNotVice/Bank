using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rppoon_Zad_1_Bank
{
    internal class Banka
    {
        private List<Korisnik> customers;

        private List<Transakcija> transactions;

        public Banka()
        {
            customers = new List<Korisnik>();
            transactions = new List<Transakcija>();
        }
        public void AddCustomer(Korisnik customer)
        {
            customers.Add(customer);
        }
        public void RemoveCustomer(Korisnik customer)
        {
            customers.Remove(customer);
        }
        public Korisnik FindCustomer(int accountNumber)
        {
            foreach(var customer in customers)
            {
                if(customer.AccountNumber == accountNumber)
                {
                    return customer;
                }
            }
            return null;
        }
        public void ExecuteTransaction(Transakcija transaction)
        {
            transaction.ExecuteTransaction();
            transactions.Add(transaction);
        }

    }
}
