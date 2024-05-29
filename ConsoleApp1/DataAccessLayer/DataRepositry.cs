using Domain;

namespace DataAccessLayer
{
    public class DataRepositry
    {
        List<Product> inventry = new List<Product>();
        List<Product> products = new List<Product>();
        public void Add()
        {
            Console.WriteLine("Enter Product Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter product Price : ");
            decimal price = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter product Quantity : ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Product Category :  ");
            string category = Console.ReadLine();
            var newProduct = new Product(name, price, quantity, category);
            inventry.Add(newProduct);
        }
        public void Display()
        {
            foreach (Product product in inventry)
            {
                Console.WriteLine($@"Product Id : {product.Id}");
                Console.WriteLine($@"Product Name : {product.Name}");
                Console.WriteLine($@"Product price : {product.Price}");
                Console.WriteLine($@"Product Category : {product.Category}");
            }
        }
        public void Search()
        {
            Console.WriteLine("Enter your Choice on which you want to Search");
            Console.WriteLine("1)ID 2) Name 3) Price 4) Category");
            int choiceInput = Convert.ToInt32(Console.ReadLine());
            switch (choiceInput)
            {
                case 1:
                    Console.WriteLine("Enter Product Id");
                    var id = Convert.ToInt32(Console.ReadLine());
                    foreach (Product item in inventry)
                    {
                        if (id == item.Id)
                        {
                            Console.WriteLine("Product Found");
                            Console.WriteLine($@"Id:{item.Id}, Name: {item.Name}, Price: {item.Price}, Category: {item.Category}");
                        }
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter Product Name");
                    var Name = (Console.ReadLine());
                    foreach (Product item in inventry)
                    {
                        if (Name == item.Name)
                        {
                            Console.WriteLine("Product Found");
                            Console.WriteLine($@"Id:{item.Id}, Name: {item.Name}, Price: {item.Price}, Category: {item.Category}");
                        }
                    }
                    break;
                case 3:
                    Console.WriteLine("Enter Product Price");
                    var Price = Convert.ToInt32(Console.ReadLine());
                    foreach (Product item in inventry)
                    {
                        if (Price == item.Price)
                        {
                            Console.WriteLine("Product Found");
                            Console.WriteLine($@"Id:{item.Id}, Name: {item.Name}, Price: {item.Price}, Category: {item.Category}");
                        }
                    }
                    break;
                case 4:
                    Console.WriteLine("Enter Product Category ");
                    var Category = (Console.ReadLine());
                    foreach (Product item in inventry)
                    {
                        if (Category == item.Category)
                        {
                            Console.WriteLine("Product Found");
                            Console.WriteLine($@"Id:{item.Id}, Name: {item.Name}, Price: {item.Price}, Category: {item.Category}");
                        }
                    }
                    break;
                default:
                    Console.WriteLine("You Entered Wrong Choice !");
                    break;
            }

        }
        public void update()
        {
            Display();
            Console.WriteLine(" Enter product Id to Update Product ");
            int UpdateId = Convert.ToInt32(Console.ReadLine());
            Product productUpdate = inventry.Find(p => p.Id == UpdateId);
            if (productUpdate != null)
            {
                Console.WriteLine("Enter product new Price : ");
                int price = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter product New Quanity");
                int quantity = Convert.ToInt32(Console.ReadLine());
                productUpdate.Price = price;
                productUpdate.Quantity = quantity;
                Console.WriteLine("Product Updated");
            }
            else
                Console.WriteLine("No product Found with this Id");
        }
        public void Delete()
        {
            Display();
            Console.WriteLine("Enter product id to delete");
            int id = Convert.ToInt32(Console.ReadLine());
            int deleteIndex = inventry.FindIndex(p => p.Id == id);
            if (deleteIndex == -1)
            {
                Console.WriteLine("No product found with this Id");
            }
            else
            {
                inventry.RemoveAt(deleteIndex);
                Console.WriteLine("Product deleted Successfully");
            }
        }
        public Product GetProductById(int id)
        {
            foreach (var product in products)
            {
                if (product.Id == id)
                {
                    return product;
                }
            }
            return null;
        }

    }
}
