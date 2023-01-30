using System;
using System.Linq;
public class Program {
    public static void Main(string[] args) 
    {
        int n = int.Parse(Console.ReadLine());

var letters = Enumerable.Range(97, n).Select(i => (char)i).ToArray();
var triples = from a in letters
              from b in letters
              from c in letters
              where a <= b || b <= c || c <= a
              select new string(new char[] { a, b, c });

foreach (var triple in triples)
{
    Console.WriteLine(triple);
}
    }
}
