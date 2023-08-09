using N21_Interface1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N21_Interface1.Providers
{
    public class UzumPaymentProvider : IPaymentProvider
    {
        public double TransferInterest { get; init; }


        public UzumPaymentProvider(double transferinterest = 0.5)
        {
            TransferInterest = transferinterest;
        }


        public bool Transfer(IDebitCard sourcecard,  IDebitCard destinationcard, in double amount) 
        {
            if(amount <= 0 || sourcecard.Balance < amount + (amount / 100 * TransferInterest) || sourcecard.Balance <= 0)
            {   
                return false;
            }
            else
            {
                sourcecard.Balance -= amount + (amount / 100 * TransferInterest);
                destinationcard.Balance += amount;
                return true;
            }
        }
    }
}
