namespace Uge_15_opgaver
{
    public class Controller
    {
        private ValuableRepository vR = new();
        public Controller()
        {

        }
        public void AddToList(IValuable valuable)
        {
            vR.AddValuable(valuable);
        }
    }
}