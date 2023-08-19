using BankAccount;

internal class Program
{
    private static void Main(string[] args)
    {
        NormalAccount normalAccount = new();
        PayrollAccount payrollAccount = new();

        Calculator.CalculateInterest(normalAccount);
        Calculator.CalculateInterest(payrollAccount);
    }
}