using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegularExam_UASD
{
    public class CoffeeShop
    {
        private string name;
        private List<Coffee> coffees;

        public CoffeeShop(string name)
        {
            this.name = name;
            this.coffees = new List<Coffee>();
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<Coffee> Coffees
        {
            get { return coffees; }
            set { coffees = value; }
        }

        public void AddCoffee(string type, double price)
        {
            Coffee coffee = new Coffee(type,price);
            coffees.Add(coffee);
        }

        public double AveragePriceInRange(double start, double end)
        {
                List<Coffee> productsInRange = coffees.Where(x => x.Price >= start && x.Price <= end).ToList();

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

        public List<string> FilterCoffeesByPrice(double price)
        {
            List<string> matchingProducts = new List<string>();

            foreach (Coffee coffee in coffees)
            {
                if (coffee.Price < price)
                matchingProducts.Add(coffee.Type);
            }
        
            return matchingProducts;
        }

        public List<Coffee> SortAscendingByType()
        {
            this.coffees = this.coffees.OrderBy(x => x.Type).ToList();
            return coffees;
        }

        public List<Coffee> SortDescendingByPrice()
        {
                this.coffees = this.coffees.OrderByDescending(x => x.Price).ToList();
                return this.coffees;
        }

        public bool CheckCoffeeIsInCoffeeShop(string type)
        {
            foreach (Coffee coffee in coffees)
            {
                if (coffee.Type == type)
                return true;
            }
        
            return false;
        }

        public string[] ProvideInformationAboutAllCoffees()
        {
            string[] cofeInfo = new string[coffees.Count];
        
            for (int i = 0; i < coffees.Count; i++)
            {
                Coffee coffee = coffees[i];
                cofeInfo[i] = $"Coffee {coffee.Type} costs {coffee.Price:f2} lv.";
            }
        
            return cofeInfo;
        }
    }
}
