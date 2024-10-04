using System;
namespace Banco{
public abstract class AccountFactory
{
    public abstract Account CreateAccount();
}

public class CurrentAccountFactory : AccountFactory
{
    public override Account CreateAccount()
    {
        return new CurrentAccount();
    }
}

public class SavingsAccountFactory : AccountFactory
{
    public override Account CreateAccount()
    {
        return new SavingsAccount();
    }
}

public class SalaryAccountFactory : AccountFactory
{
    public override Account CreateAccount()
    {
        return new SalaryAccount();
    }
}

}