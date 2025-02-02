namespace Dz14
{
    public class DBContext
    {
        public List<Manufacturer> Manufacturers = new List<Manufacturer>
        {
            new Manufacturer(0,"BMW")
        };
        public List<Category> Categorys = new List<Category>
        {
            new Category(0,"M5")
        };
        public List<Buyer> Buyers = new List<Buyer>
        {
            new Buyer(0,"User")
        };
        public List<Order> Orders = new List<Order>
        {
            new Order(0,"Car",new Buyer(0,"User"))
        };
        public List<Product> Products = new List<Product>
        {
            new Product(0,new Order(0,"Car",new Buyer(0,"User")),new Category(0,"M5"),new Manufacturer(0,"BMW"))
        };
        public void AddManufacturer(Manufacturer manufacturer)
        {
            Manufacturers.Add(manufacturer);
        }
        public void AddCategory(Category category)
        {
            Categorys.Add(category);
        }
        public void AddBuyer(Buyer buyer)
        {
            Buyers.Add(buyer);
        }
        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }


        public void searchManufacturerById(int Id)
        {
            foreach (Manufacturer manufacturer in Manufacturers)
            {
                if (manufacturer.Id == Id)
                {
                    Console.WriteLine(manufacturer);
                    return;
                }
            }
            Console.WriteLine("Not found!!!");
        }
        public void searchCategory(int Id)
        {
            foreach (Category category in Categorys)
            {
                if (category.Id == Id)
                {
                    Console.WriteLine(category);
                    return;
                }
            }
            Console.WriteLine("Not found!!!");
        }
        public void searchBuyer(int Id)
        {
            foreach (Buyer buyer in Buyers)
            {
                if (buyer.Id == Id)
                {
                    Console.WriteLine(buyer);
                    return;
                }
            }
            Console.WriteLine("Not found!!!");
        }
        public void searchOrder(int Id)
        {
            foreach (Order order in Orders)
            {
                if (order.Id == Id)
                {
                    Console.WriteLine(order);
                    return;
                }
            }
            Console.WriteLine("Not found!!!");
        }
        public void searchProduct(int Id)
        {
            foreach (Product product in Products)
            {
                if (product.Id == Id)
                {
                    Console.WriteLine(product);
                    return;
                }
            }
            Console.WriteLine("Not found!!!");
        }

        public void sortAll()
        {
            Manufacturers.Sort();
            Categorys.Sort();
            Buyers.Sort();
            Orders.Sort();
            Products.Sort();
        }
    }
}
