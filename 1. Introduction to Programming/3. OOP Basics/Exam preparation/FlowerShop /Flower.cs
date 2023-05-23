using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RegularExam
{
    public class Flower
    {
        public Flower (string type, string color, double price)
        {
            if(price > 100) throw new ArgumentException ("Ivalid flower price!");
            this.Type = type;
            this.Color = color;
            this.Price = price;
        }        
        public string  Type
        {
            get; 
        }
        
        public string  Color
        {
            get;
        }
        
        
        public double Price
        {
            get;
        }
        
        public override string ToString()
        {
           return $"Flower {Type} with color {Color} costs {Price:f2}";
        }
    }
}
