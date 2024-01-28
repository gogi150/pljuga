using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Unesite pozitivan broj: ");
        int broj = int.Parse(Console.ReadLine());

        for (int i = 1; i <= broj; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}