using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rppoon_Zad_1_Bank
{
    internal abstract class Transakcija : ITransakcija
    {
        public decimal Amount { get; set; }

        public DateTime TimeStamp { get; set; }

        public abstract void ExecuteTransaction();
    }
}
