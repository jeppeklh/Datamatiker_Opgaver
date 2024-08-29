namespace Uge_15_opgaver
{
    public class Book : Merchandise
    {
        public string Title { get; set; }
        public double Price { get; set; }

        public Book(string itemId)
        {
            this.ItemId = itemId;
        }
        public Book(string itemId, string title) : this(itemId)
        {
            this.Title = title;
        }
        public Book(string itemId, string title, double price) : this(itemId, title)
        {
            this.Price = price;
        }
        public override string ToString()
        {
            return $"ItemId: {ItemId}, Title: {Title}, Price: {Price}";
        }
        public override double GetValue()
        {
            return Price;
        }
    }
}
