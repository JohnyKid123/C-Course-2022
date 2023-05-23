using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegularExam
{
    public class Perfumery
    {
        private List<Perfume> perfumes = new List<Perfume>();
        private string name;
        

        public Perfumery(string name)
        {
            this.perfumes = new List<Perfume>();
            this.Name = name;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if(value.Length < 6) throw new ArgumentException("Invalid perfumery name!");
                this.name = value;
            }
        }

        public void AddPerfume(Perfume perfume)
        {
                this.perfumes.Add(perfume);
        }

        public bool SellPerfume(Perfume perfume)
        {
            int perfumeindex = this.perfumes.FindIndex(f => f.Brand == perfume.Brand && f.Price == perfume.Price);
            if (perfumeindex == -1) return false;
            this.perfumes.RemoveAt(perfumeindex);
            return true;
        }

        public double CalculateTotalPrice()
        {
            return this.perfumes.Sum(perfume => perfume.Price);
        }

        public Perfume GetPerfumeWithHighestPrice()
        {
            int maxprice = 0;
            for(int i=1;  i<this.perfumes.Count; i++) 
                {
                    if(this.perfumes[i].Price > this.perfumes[maxprice].Price) maxprice = i;

                }   
            return this.perfumes[maxprice];
        }

        public Perfume GetPerfumeWithLowestPrice()
        {
            int minprice = 0;
            for(int i=1;  i<this.perfumes.Count; i++) 
                {
                    if(this.perfumes[i].Price < this.perfumes[minprice].Price) minprice = i;

                }   
            return this.perfumes[minprice];
        }

        public void RenamePerfumery(string newName)
        {
                this.Name = newName;
        }

        public void SellAllPerfumes()
        {
                 this.perfumes.Clear();
        }

        public override string ToString()
        {
            if(this.perfumes.Count == 0)
            {
                return $"Perfumery {this.Name} has no available perfumes.";
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Perfumery {this.Name} has {this.perfumes.Count} perfume/s");
            foreach(var perfume in this.perfumes)
            {
                sb.AppendLine(perfume.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}
