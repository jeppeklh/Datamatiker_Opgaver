namespace Opgave4;

//public delegate void Notify();
public class Sparegris
{
    public event EventHandler<CustomEventArgs> SaldoBreakpointReached;

    private double balance = 0;

    public void InsertAmount(double amount)
    {
        this.balance += amount;
        OnSaldoBreakpointReached();
    }

    protected virtual void OnSaldoBreakpointReached()
    {
        SaldoBreakpointReached?.Invoke(this, new CustomEventArgs(balance));
    }

    public double GetBalance()
    {
        return balance;
    }
}
