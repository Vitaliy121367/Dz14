namespace Dz14
{
    public class DBContext
    {
        public List<Product> Products = new List<Product>
        {
            new Product(1, new Order(1, "Order1",new Buyer(1, "Alice")),new Category(1, "Electronics"),new Manufacturer(1, "Samsung")),
            new Product(2, new Order(2, "Order2",new Buyer(2, "Bob")),new Category(2, "Clothing"),new Manufacturer(2, "Nike")),
            new Product(3, new Order(3, "Order3", new Buyer(3, "Alice")),new Category(3, "Books"),new Manufacturer(3, "Penguin"))
        };
    }
}
