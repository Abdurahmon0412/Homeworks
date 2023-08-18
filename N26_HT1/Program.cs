//unda + va - operatorlarini overload qiling,
//bunda MoneyType dan kelib chiqib amal bajarilsin, masalan moneyA va moneyB bor deylik

//+ operatsiyasi uchun : 

//-moneyA va moneyB bir xil tipda bo'lsa - qo'shiladi
//- moneyA in balance va moneyB loan bo'lsa - moneyA - moneyB qilinadi
//- moneyB loan va moneyB in balance bo'lsa - moneyB - moneyA qilinadi

//- Money tipidagi kolleksiyaga bir nechta object qo'shing
//- ular orasida qarzlar ham bo'lsin
//- hammasini qo'shib ekranga chiqaring

//PS : bunda konversiyalarni o'g'irish uchun Convert methodidan foydalanish mumkin

//Fake data : 

using N26_HT1;
using N26_HT1.Enums;

List<Money> moneyList = new List<Money>
{
    new Money { Amount = 100.00m, Type = MoneyType.InBalance, Currency = Currency.UZS },
    new Money { Amount = 50.00m, Type = MoneyType.InBalance, Currency = Currency.USD },
    new Money { Amount = 200.00m, Type = MoneyType.Loan, Currency = Currency.RUB },
    new Money { Amount = 75.00m, Type = MoneyType.InBalance, Currency = Currency.UZS },
    new Money { Amount = 150.00m, Type = MoneyType.Loan, Currency = Currency.USD },
    new Money { Amount = 25.00m, Type = MoneyType.InBalance, Currency = Currency.RUB },
    new Money { Amount = 50.00m, Type = MoneyType.InBalance, Currency = Currency.USD},
    new Money { Amount = 10.00m, Type = MoneyType.Loan, Currency = Currency.UZS },
    new Money { Amount = 5.00m, Type = MoneyType.Loan, Currency = Currency.RUB },
    new Money { Amount = 100.00m, Type = MoneyType.InBalance, Currency = Currency.UZS }
};

var TotalMoney = new Money { Amount  = 0, Type = MoneyType.InBalance,Currency = Currency.UZS};

foreach (var money in moneyList)
{
    TotalMoney = TotalMoney + money;
}

Console.WriteLine($"Total amount = {TotalMoney.Amount} {TotalMoney.Currency}");
//Console.WriteLine(moneyList.Sum(sum => sum.Amount));