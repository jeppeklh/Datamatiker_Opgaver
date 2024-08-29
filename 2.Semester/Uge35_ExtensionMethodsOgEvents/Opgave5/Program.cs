namespace Opgave5;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Metronome metronome = new Metronome();
        TickListener tickListener = new TickListener();

        tickListener.Subscribe(metronome);

        metronome.Start();
    }
}
