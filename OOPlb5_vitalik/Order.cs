using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlb5_vitalik
{
    public class Order
    {
        public List<Product> Products { get; private set; }
        public List<int> Quantities { get; private set; }
        public decimal TotalCost { get; private set; }
        public string OrderStatus { get; private set; }

        public Order()
        {
            Products = new List<Product>();
            Quantities = new List<int>();
            TotalCost = 0;
            OrderStatus = "Pending";
        }

        public void AddProduct(Product product, int quantity)
        {
            Products.Add(product);
            Quantities.Add(quantity);
            TotalCost += product.Price * quantity;
        }

        public void SetOrderStatus(string status)
        {
            OrderStatus = status;
        }
    }

}
