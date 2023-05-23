using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularExam
{
    internal class FlowerStore
    {
                       private List<Flower> flowers = new List<Flower>();
        private string name;

        public FlowerStore(string name)
        {
            
            this.flowers = new List<Flower>();
            this.Name = name;
        }
        
        public string Name
        {
            get => this.name;
            private set
            {
                if(value.Length < 6) throw new ArgumentException("Invalid flower store name!");
                this.name = value;
            }

            
        }
        public void AddFlower(Flower flower)
        {
            this.flowers.Add(flower);
        }
        public bool SellFlower(Flower flower)
        {
            // not shure
            int flowerIndex = this.flowers.FindIndex(f => f.Type == flower.Type && f.Price == flower.Price && f.Color == flower.Color);
            if (flowerIndex == -1) return false;
            this.flowers.RemoveAt(flowerIndex);
            return true;
        }     
        public double CalculateTotalPrice()
        {
            return this.flowers.Sum(flower => flower.Price);
        }
        
        public Flower GetFlowerWithHighestPrice()
        {
            int maxprice = 0;
            for(int i=1;  i<this.flowers.Count; i++) 
                {
                    if(this.flowers[i].Price > this.flowers[maxprice].Price) maxprice = i;

                }   
            return this.flowers[maxprice];
        }
        
        public Flower GetFlowerWithLowestPrice()
        {
            int minprice = 0;
            for(int i=1;  i<this.flowers.Count; i++) 
                {
                    if(this.flowers[i].Price < this.flowers[minprice].Price) minprice = i;

                }   
            return this.flowers[minprice];
        }
        
        public void RenameFlowerStore(string newName)
        {
           this.Name = newName;
        }
        
        public void SellAllFlowers()
        {
           this.flowers.Clear();
        }
        
        public override string ToString()
        {
            if(this.flowers.Count == 0)
            {
                return $"Flower store {this.Name} has no available flowers.";
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Flower store {this.Name} has {this.flowers.Count} flower/s:");
            foreach(var flower in this.flowers)
            {
                sb.AppendLine(flower.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}
