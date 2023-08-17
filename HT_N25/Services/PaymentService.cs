using HT_N25.Models;

namespace HT_N25.Services;

public  class PaymentService
{
    public  bool CheckOut(double amount, DebitCard debitCard)
    {
        if (amount < debitCard.Balance) return true;
        else
        {
             return false;
        }
    }
}