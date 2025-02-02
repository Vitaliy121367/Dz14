using System.Xml.Linq;

namespace Dz14
{
    public class Program
    {
        static void Main(string[] args)
        {
            DBContext dBContext = new DBContext();
            dBContext.AddBuyer(new Buyer(1, "John Doe"));
            dBContext.AddBuyer(new Buyer(2, "Jane Smith"));

            dBContext.AddOrder(new Order(1, "Order 1", dBContext.Buyers[1]));
            dBContext.AddOrder(new Order(3, "Order 2", dBContext.Buyers[2]));
            dBContext.AddOrder(new Order(5, "Order 3", dBContext.Buyers[1]));
            dBContext.AddOrder(new Order(2, "Order 4", dBContext.Buyers[2]));
            dBContext.AddOrder(new Order(4, "Order 5", dBContext.Buyers[1]));

            dBContext.AddManufacturer(new Manufacturer(2, "Honda"));
            dBContext.AddManufacturer(new Manufacturer(1, "Toyota"));

            dBContext.AddCategory(new Category(2, "Sedan"));
            dBContext.AddCategory(new Category(1, "SUV"));

            dBContext.AddProduct(new Product(1, dBContext.Orders[1], dBContext.Categorys[2], dBContext.Manufacturers[2]));
            dBContext.AddProduct(new Product(2, dBContext.Orders[2], dBContext.Categorys[1], dBContext.Manufacturers[1]));
            dBContext.AddProduct(new Product(3, dBContext.Orders[3], dBContext.Categorys[2], dBContext.Manufacturers[2]));
            dBContext.AddProduct(new Product(4, dBContext.Orders[4], dBContext.Categorys[1], dBContext.Manufacturers[1]));

            PrintCollection<Product>(dBContext.Products);
        }
        public static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }
        }
    }
}
