namespace BankAccount;

public abstract class Account
{

    public double Balance { get; set; }

    public double Interest { get; set; }

    public abstract void CalculateInterest();

}