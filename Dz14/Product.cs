namespace Dz14
{
    public class Product
    {
        public int Id { get; set; }
        public Order order;
        public Category category;
        public Manufacturer manufacturer;
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
