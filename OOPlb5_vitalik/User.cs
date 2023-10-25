using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlb5_vitalik
{
    public class User
    {
        public string Login { get; private set; }
        private string Password { get; set; }
        public List<Product> PurchaseHistory { get; private set; }

        public User(string login, string password)
        {
            Login = login;
            Password = password;
            PurchaseHistory = new List<Product>();
        }

        public bool Authenticate(string password)
        {
            return Password == password;
        }

        public void AddToPurchaseHistory(Product product)
        {
            PurchaseHistory.Add(product);
        }

        internal void AddOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }

}
