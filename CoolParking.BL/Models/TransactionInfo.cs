using System;

public struct TransactionInfo
{
    public DateTime TransactionTime { get; set; }
    public string Id { get; set; }
    private decimal Cost { get; set; }

    public decimal Sum()
    {
        return Cost;
    }
}


// TODO: implement struct TransactionInfo.
//       Necessarily implement the Sum property (decimal) - is used in tests.
//       Other implementation details are up to you, they just have to meet the requirements of the homework.
