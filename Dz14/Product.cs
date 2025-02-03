namespace Dz14
{
    public class Product
    {
        public int Id { get; set; }
        public Order order { get; set; }
        public Category category { get; set; }
        public Manufacturer manufacturer { get; set; }
        public Product(int id, Order Order, Category Category, Manufacturer Manufacturer)
        {
            Id = id;
            order = Order;
            category = Category;
            manufacturer = Manufacturer;
        }
        public override string ToString()
        {
            return $"Product\nId: {Id}\n{order}\n{category}\n{manufacturer}";
        }
    }
}
