using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N21_Interface1.Interfaces
{
    public interface IPaymentProvider
    {
        public double TransferInterest { get; init; }
        public bool Transfer(IDebitCard sourcecard,  IDebitCard destinationcard, in double amount) { return false; }


    }
}
