namespace ChainOfResp.Utilities
{
    public class Purchase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Purchase(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}
