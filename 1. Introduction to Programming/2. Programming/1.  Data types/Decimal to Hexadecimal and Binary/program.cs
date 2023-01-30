using System;

public class Program {
    public static void Main(string[] args) 
    {
        int decimalNum = int.Parse(Console.ReadLine());
string hexNum = decimalNum.ToString("X");
string binaryNum = Convert.ToString(decimalNum, 2);
Console.WriteLine(hexNum);
Console.WriteLine(binaryNum);

    }
}
