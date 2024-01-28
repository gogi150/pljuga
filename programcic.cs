using System;

public class Program
{
    public static void Main()
    {
        for (int year = 1900; year <= 2100; year++)
        {
            if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
            {
                Console.WriteLine(year);
            }
        }
    }
}