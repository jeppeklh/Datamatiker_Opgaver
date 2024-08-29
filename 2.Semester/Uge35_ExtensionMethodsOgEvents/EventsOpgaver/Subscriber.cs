namespace Opgave4;

public class Subscriber
{

    public void Subscribe(Sparegris sparegris)
    {
        sparegris.SaldoBreakpointReached += HandleSaldoBrakpointReached;
    }


    public void HandleSaldoBrakpointReached(object sender, CustomEventArgs e)
    {
        if(e.Balance > 1197)
        {
            Console.WriteLine("Tillykke – du har nu penge nok til tre sæsonkort til OBs kampe");
        }
        else if (e.Balance > 799)
        {
            Console.WriteLine("Tillykke – du har nu penge nok til et premium sæsonkort til OBs kampe");
        }
        else if(e.Balance > 399)
        {
            Console.WriteLine("Tillykke – du har nu penge nok til et sæsonkort til OBs kampe");
        }
    }
}
