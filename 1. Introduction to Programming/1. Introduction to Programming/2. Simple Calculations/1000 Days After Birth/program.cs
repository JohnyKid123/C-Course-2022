using System;

class ThousandDayAfter
{
    static void Main()
    {
        string ftm = "dd-MM-yyyy";
        string value = Console.ReadLine();
        DateTime userBirthday = DateTime.ParseExact(value, ftm, null);
        Console.WriteLine(userBirthday.AddDays(999).ToString("dd-MM-yyyy"));
    }
}
