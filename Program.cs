using Rppoon_Zad_1_Bank;

internal class Program
{
    private static void Main(string[] args)
    {
        Banka bank = new Banka();

        Korisnik customer1 = new Korisnik();

        customer1.FirstName = "Dino";
        customer1.LastName = "Versic";
        customer1.AccountNumber = 123456;
        customer1.Balance = 2000;

        Korisnik customer2 = new Korisnik();

        customer2.FirstName = "Iva";
        customer2.LastName = "Versic";
        customer2.AccountNumber = 789101;
        customer2.Balance = 3000;

        bank.AddCustomer(customer1);
        bank.AddCustomer(customer2);

        customer1.ShowAccountInfo();
        customer2.ShowAccountInfo();

        TransactionTransfer transactionTransfer = new()
        {
            Amount = 500,
            SourceAccountNumber = customer1.AccountNumber,
            DestinationAccountNumber = customer2.AccountNumber,
        };
        
        bank.ExecuteTransaction(transactionTransfer);

        customer1.Balance -= transactionTransfer.Amount;
        customer2.Balance += transactionTransfer.Amount;

        customer1.ShowAccountInfo();
        customer2.ShowAccountInfo();
    }
}