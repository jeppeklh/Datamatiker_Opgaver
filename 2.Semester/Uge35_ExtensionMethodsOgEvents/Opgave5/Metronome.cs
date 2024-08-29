namespace Opgave5;

public delegate void Notify();
public class Metronome
{
    public event Notify Tick;

    public void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            Tick?.Invoke();
            Thread.Sleep(3000);
        }


    }
}

