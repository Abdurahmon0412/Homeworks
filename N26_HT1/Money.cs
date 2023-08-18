using N26_HT1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N26_HT1
{
    public class Money
    {
        public decimal Amount { get; set; }
        public MoneyType Type { get; set; }
        public Currency Currency { get; set; }

        public Money(decimal amount, MoneyType type, Currency currency = Currency.UZS)
        {
            Amount = amount;
            Type = type;
            Currency = currency;
        }
        public Money()
        {
        }

        //+ operatsiyasi uchun : 

        //-moneyA va moneyB bir xil tipda bo'lsa - qo'shiladi
        //- moneyA in balance va moneyB loan bo'lsa - moneyA - moneyB qilinadi
        //- moneyB loan va moneyB in balance bo'lsa - moneyB - moneyA qilinadi
        public static Money operator + (Money moneyA, Money moneyB)
        {
            if (moneyA.Type == moneyB.Type)
                return new Money(moneyA.Convert(moneyA) + moneyB.Convert(moneyB), moneyA.Type);
            if (moneyA.Type == MoneyType.InBalance && moneyB.Type == MoneyType.Loan)
                return new Money(moneyA.Convert(moneyA) - moneyB.Convert(moneyB), moneyA.Type);
            if (moneyA.Type == MoneyType.Loan && moneyB.Type == MoneyType.InBalance)
                return new Money( moneyB.Convert(moneyB) - moneyA.Convert(moneyA), moneyA.Type);
            return null;
        }

        public decimal Convert(Money money)
        {
            if (money.Currency.ToString() == "UZS")
                return money.Amount;
            if(money.Currency.ToString() == "USD")
                return money.Amount * 12000;
            if (money.Currency.ToString() == "RUB")
                return money.Amount * 129;
            else return 0;
        }
    }
}