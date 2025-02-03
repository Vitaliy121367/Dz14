using System.Xml.Linq;

namespace Dz14
{
    public class Program
    {
        static void Main(string[] args)
        {
            DBContext dBContext = new DBContext();
            Service service = new Service(new DBContext());

            service.CreateProduct(new Product(4, new Order(4, "Order 5", new Buyer(2, "Jane Smith")), new Category(2, "Sedan"), new Manufacturer(1, "Toyota")));
            service.DeleteProductsById(4);
            service.UpdateUsers(3, new Product(4, new Order(4, "Order 5", new Buyer(2, "Jane Smith")), new Category(2, "Sedan"), new Manufacturer(1, "Toyota")));
            service.ReadFirstUsers();
        }
    }
}
