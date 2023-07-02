using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program
{
    internal class Supermarket
    {
        private string name;
        private List<Product> products;

        public Supermarket(string name)
        {
            this.name = name;
            this.products = new List<Product>();
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<Product> Products
        {
            get { return products; }
            set { products = value; }
        }

        public void AddProduct(string name, double price)
        {
            Product product = new Product(name,price);
            products.Add(product);
        }

        public double AveragePriceInRange(double start, double end)
        {
                List<Product> productsInRange = products.Where(x => x.Price >= start && x.Price <= end).ToList();

                if (productsInRange.Count > 0)
                {
                    double totalPrice = productsInRange.Sum(x => x.Price);
                    return totalPrice / productsInRange.Count;
                }
                else
                {
                    return 0;
                }
        }

        public List<string> FilterProductsByPrice(double price)
        {
            List<string> matchingProducts = new List<string>();

            foreach (Product product in products)
            {
                if (product.Price < price)
                matchingProducts.Add(product.Name);
            } 
        
            return matchingProducts;
        }

        public List<Product> SortAscendingByName()
        {
            this.products = this.products.OrderBy(x => x.Name).ToList();
            return products;
        }

        public List<Product> SortDescendingByPrice()
        {
                this.products = this.products.OrderByDescending(x => x.Price).ToList();
                return this.products;
        }

        public bool CheckProductIsInSupermarket(string name)
        {
            foreach (Product product in products)
            {
                if (product.Name == name)
                return true;
            }
        
            return false;
        }

        public string[] ProvideInformationAboutAllProducts()
        {
            string[] productInfo = new string[products.Count];
        
            for (int i = 0; i < products.Count; i++)
            {
                Product product = products[i];
                productInfo[i] = $"Product {product.Name} costs {product.Price:f2} lv.";
            }
        
            return productInfo;
        }
    }
}
