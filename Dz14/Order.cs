namespace Dz14
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Buyer buyer { get; set; }
        public Order(int id, string name, Buyer buyerr)
        {
            Id = id;
            Name = name;
            buyer = buyerr;
        }
        public override string ToString()
        {
            return $"Order\nId: {Id}\nOrder: {Name}\nBuyer: {buyer.Name}";
        }
    }
}
