using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rppoon_Zad_1_Bank
{
    internal interface IBankovniRacun
    {
        public void Withdraw(decimal amount);

        public void Deposit(decimal amount);

        public void ShowAccountInfo();
    }
}
