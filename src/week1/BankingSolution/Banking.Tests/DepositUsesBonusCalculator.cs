
using Banking.Domain;
using Banking.Tests.TestDoubles;

namespace Banking.Tests;

public class DepositUsesBonusCalculator
{
    [Fact]
    public void IntegratesProperly()
    {
        var stubbedBonucCalculator = new StubbedBonusCalculator();
        var account = new Account(stubbedBonucCalculator);
        var openingBalance = account.GetBalance();
        account.Deposit(420.69M);

        Assert.Equal(openingBalance + 420.69M + 19M, account.GetBalance());
    }
}
