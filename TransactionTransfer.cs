using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rppoon_Zad_1_Bank
{
    internal class TransactionTransfer : Transakcija
    {
        public int SourceAccountNumber { get; set; }

        public int DestinationAccountNumber { get; set; }

        public override void ExecuteTransaction()
        {
            Console.WriteLine($"Transfered {Amount} from account {SourceAccountNumber} to account {DestinationAccountNumber}");
        }
    }
}
