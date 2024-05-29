// See https://aka.ms/new-console-template for more information
using DataAccessLayer;
using Domain;

bool IsTerminate = false;
DataRepositry datarepository = new DataRepositry();
Cart cart = new Cart();
do
{
    Console.WriteLine(" 1)Add Product 2) Display Product 3) Search 4)Update Product 5)Delete Product 6)add to cart 7) remove product from cart 8) update product from cart 9)bill");
    int input = Convert.ToInt32(Console.ReadLine());
    switch (input)
    {
        case 1:
            datarepository.Add();
            break;
        case 2:
            datarepository.Display();
            break;
        case 3:
            datarepository.Search();
            break;
        case 4:
            datarepository.update();
            break;
        case 5:
            datarepository.Delete();
            break;
        case 6:
            datarepository.Display();
            Console.WriteLine("Enter product id to add to cart");
            int id = Convert.ToInt32(Console.ReadLine());
            Product productToAdd = datarepository.GetProductById(id);
            if (productToAdd != null)
            {
                cart.AddToCart(productToAdd);
            }
            else
            {
                Console.WriteLine("No product found with this Id");
            }
            break;
        case 7:
            Console.WriteLine("Enter product id to remove from cart");
            int removeId = Convert.ToInt32(Console.ReadLine());
            Product productToRemove = cart.GetProductById(removeId);
            if (productToRemove != null)
            {
                cart.RemoveFromCart(productToRemove);
            }
            else
            {
                Console.WriteLine("No product found with this Id in cart");
            }
            break;
        case 8:
            Console.WriteLine("Enter product id to update in cart");
            int updateId = Convert.ToInt32(Console.ReadLine());
            Product productToUpdate = cart.GetProductById(updateId);
            if (productToUpdate != null)
            {
                Console.WriteLine("Enter new quantity");
                int quantity = Convert.ToInt32(Console.ReadLine());
                cart.UpdateProductInCart(productToUpdate, quantity);
            }
            else
            {
                Console.WriteLine("No product found with this Id in cart");
            }
            break;
        case 9:
            decimal totalBill = cart.Billing();
            Console.WriteLine($"Total bill: {totalBill}");
            break;
        default:
            Console.WriteLine("You Enter Wrong Choice");
            IsTerminate = true;
            break;
    }


} while (!IsTerminate);
