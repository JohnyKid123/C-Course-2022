using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Product
    {
        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
        public string Name {get; set; }
        public double Price {get; set; }
        public override string ToString()
        {
            return $"Product {this.Name} costs {this.Price} lv.";
        }

    }
}
