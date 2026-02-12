
using Backing.Domain;

namespace Banking.Tests.NewAccounts;

public class HaveCorrectBalance
{
    [Fact]
    public void BalanceIsCorrect()
    {
        // WTCYWYH - Write The Code You With You Had
        var myAccount = new Account();

        decimal openingBalance = myAccount.GetBalance();

        // Fails on the Asset - Meaningfully failing test. We want to create these kind of tests.
        Assert.Equal(5000M, openingBalance);
    }
}
