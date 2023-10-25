namespace OOPlb5_vitalik
{ 
public class Store
{
    private List<User> Users { get; set; }
    private List<Product> Products { get; set; }
    private List<Order> Orders { get; set; }

    public Store()
    {
        Users = new List<User>();
        Products = new List<Product>();
        Orders = new List<Order>();
    }

    public void AddUser(User user)
    {
        Users.Add(user);
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public void CreateOrder(User user)
    {
        Order order = new Order();
        Orders.Add(order);

        user.AddOrder(order);
    }

    public void AddProductToOrder(Order order, Product product, int quantity)
    {
        order.AddProduct(product, quantity);
    }

    public void SetOrderStatus(Order order, string status)
    {
        order.SetOrderStatus(status);
    }

    public List<Product> SearchProductsByPrice(decimal minPrice, decimal maxPrice)
    {
        return Products.Where(p => p.Price >= minPrice && p.Price <= maxPrice).ToList();
    }

    public List<Product> SearchProductsByCategory(string category)
    {
        return Products.Where(p => p.Category.Equals(category, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public List<Product> SearchProductsByRating(int minRating)
    {
        return Products.Where(p => p.Rating >= minRating).ToList();
    }

    public User AuthenticateUser(string login, string password)
    {
        return Users.FirstOrDefault(u => u.Login == login && u.Authenticate(password));
    }

}
}