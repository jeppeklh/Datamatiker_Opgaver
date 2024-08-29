namespace Uge_15_opgaver
{
    public class Amulet : Merchandise
    {
        public string Design { get; set; }
        public Level Quality { get; set; }
        public static double LowQualityValue { get; set; } = 12.5;
        public static double MediumQualityValue { get; set; } = 20;
        public static double HighQualityValue { get; set; } = 27.5;

        public Amulet(string itemId)
        {
            this.ItemId = itemId;
        }
        public Amulet(string itemId, Level quality) : this(itemId)
        {
            this.Quality = quality;
        }
        public Amulet(string itemId, Level quality, string design) : this(itemId, quality)
        {
            this.Design = design;
        }
        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }
        public override double GetValue()
        {
            switch (Quality)
            {
                case Level.low:
                    return Amulet.LowQualityValue;

                case Level.medium:
                    return Amulet.MediumQualityValue;

                case Level.high:
                    return Amulet.HighQualityValue;

                default:
                    throw new ArgumentException("Invalid quality");
            }
        }
    }
}
