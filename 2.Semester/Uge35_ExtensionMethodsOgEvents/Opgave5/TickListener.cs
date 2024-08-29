namespace Opgave5;

public class TickListener
{

    public void OnTick()
    {
        Console.WriteLine("Heard you");
    }

    public void Subscribe(Metronome metronome)
    {
        metronome.Tick += this.OnTick;
    }


}
