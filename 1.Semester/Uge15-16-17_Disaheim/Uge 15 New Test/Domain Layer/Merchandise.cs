namespace Uge_15_opgaver
{
    public abstract class Merchandise : IValuable
    {
        public string ItemId { get; set; }

        public override string ToString()
        {
            return $"ItemId: {ItemId}";
        }

        public abstract double GetValue();
    }
}
