using Domain;

namespace DataAccessLayer
{
    public class Cart
    {
        List<Product> cartItems = new List<Product>();
        List<Product> products = new List<Product>();

        public void AddToCart(Product product)
        {
            cartItems.Add(product);
            Console.WriteLine("Product added to cart");
        }

        public void RemoveFromCart(Product product)
        {
            cartItems.Remove(product);
            Console.WriteLine("Product removed from cart");
        }

        public void UpdateProductInCart(Product product, int quantity)
        {
            var item = cartItems.Find(p => p.Id == product.Id);
            if (item != null)
            {
                item.Quantity = quantity;
                Console.WriteLine("Product updated in cart");
            }
            else
                Console.WriteLine("Product not found in cart");
        }

        public decimal Billing()
        {
            decimal totalBill = 0;
            foreach (Product product in cartItems)
            {
                totalBill += product.Price * product.Quantity;
            }
            return totalBill;
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
