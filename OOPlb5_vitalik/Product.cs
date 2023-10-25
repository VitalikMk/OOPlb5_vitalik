using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlb5_vitalik
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int Rating { get; set; } // Assuming Rating is a property

        public Product(string name, decimal price, string description, string category, int rating)
        {
            Name = name;
            Price = price;
            Description = description;
            Category = category;
            Rating = rating;
        }
    }

    public interface ISearchable
    {
        List<Product> SearchByPrice(decimal minPrice, decimal maxPrice);
        List<Product> SearchByCategory(string category);
        List<Product> SearchByRating(int minRating);
    }

    public class SearchableProduct : ISearchable
    {
        private List<Product> products; // Assuming you have a list of products

        public SearchableProduct(List<Product> productList)
        {
            products = productList;
        }

        public List<Product> SearchByPrice(decimal minPrice, decimal maxPrice)
        {
            return products.Where(p => p.Price >= minPrice && p.Price <= maxPrice).ToList();
        }

        public List<Product> SearchByCategory(string category)
        {
            return products.Where(p => p.Category.Equals(category, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Product> SearchByRating(int minRating)
        {
            return products.Where(p => p.Rating >= minRating).ToList();
        }
    }



}
