namespace BankAccount;

public class PayrollAccount : Account {
    public override void CalculateInterest()
    {
        Interest = Balance * 0.5;
    }
}