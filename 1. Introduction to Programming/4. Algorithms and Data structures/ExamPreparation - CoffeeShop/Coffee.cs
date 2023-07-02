using System;
using System.Collections.Generic;
using System.Text;

namespace RegularExam_UASD
{
    public class Coffee
    {
        public Coffee(string type, double price)
        {
            this.Type = type;
            this.Price = price;
        }
        public string Type { get; set;}
        
        public double Price { get; set;}

        public override string ToString()
        {
            return $"Coffee {this.Type} costs {this.Price} lv.";
        }

    }
}
