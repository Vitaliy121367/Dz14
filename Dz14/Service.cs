namespace Dz14
{
    public class Service
    {
        private LinkedList<Product> Products { get; set; }
        public Service(DBContext dBContext) 
        {
            Products = new LinkedList<Product>(dBContext.Products);
        }
        public void CreateProduct(Product product)
        {
            if (product != null)
            {
                Products.AddLast(product);
                Console.WriteLine("Product created successfully");
                return;
            }
            throw new NullReferenceException("Product is null");
        }
        public void DeleteProductsById(int id)
        {
            foreach (Product product in Products)
            {
                if (product.Id == id)
                {
                    Products.Remove(product);
                    return;
                }
            }
            throw new NullReferenceException("User is null");
        }
        public Product GetUserById(int id)
        {
            foreach (Product product in Products)
            {
                if (product.Id == id)
                {
                    return product;
                }
            }
            throw new NullReferenceException("User is null");
        }

        public IEnumerable<Product> GetUsers()
        {
            return Products;
        }

        public void UpdateUsers(int id, Product newProduct)
        {
            foreach (Product product in Products)
            {
                if (product.Id == id)
                {
                    product.Id = newProduct.Id;
                    product.order = newProduct.order;
                    product.category = newProduct.category;
                    product.manufacturer = newProduct.manufacturer;
                    return;
                }
            }
            throw new NullReferenceException("User is null");
        }

        public void ReadFirstUsers()
        {
            LinkedListNode<Product> current = Products.First;
            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
        }
        public void ReadLastUsers()
        {
            LinkedListNode<Product> current = Products.Last;
            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Previous;
            }
        }
    }
}
