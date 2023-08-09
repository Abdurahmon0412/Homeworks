using N21_Interface1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N21_Interface1.Cards
{
    internal class MilliyHumo : IDebitCard
    {
        public  string CardNumber { get; set; }
        public string BankName { get; init; }
        public double Balance { get; set; }

        public MilliyHumo(string cardnumber, string bankname,double balance = 0) 
        {
            if (cardnumber.Length < 16 || string.IsNullOrWhiteSpace(cardnumber))
                throw new ArgumentException("Invalid card number");
            if (string.IsNullOrWhiteSpace(bankname))
                throw new ArgumentException("Invalid Bank name");
            if (balance < 0)
                throw new ArgumentException("Balanced not used ");
            CardNumber = cardnumber;
            BankName = bankname;
            Balance = balance;
        }
    }
}
