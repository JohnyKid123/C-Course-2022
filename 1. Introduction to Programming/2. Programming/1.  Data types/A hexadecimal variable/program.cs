string hexNum = Console.ReadLine();
hexNum = hexNum.Replace("0x", "");
int decimalNum = int.Parse(hexNum, System.Globalization.NumberStyles.HexNumber);
Console.WriteLine(decimalNum);
