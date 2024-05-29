namespace Domain
{
    public class Product
    {
        public Product(string _Name, decimal _Price, int _Quantity, string _Category)
        {
            Id = LastID++;
            Name = _Name;
            Price = _Price;
            Quantity = _Quantity;
            Category = _Category;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; }
        private static int LastID = 1;
    }
}
