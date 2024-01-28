using System;

   public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Unesite prvi broj:");
            int prviBroj = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite drugi broj:");
            int drugiBroj = int.Parse(Console.ReadLine());

            int najveciDjeljiviBroj = PronadiNajveciDjeljiviBroj(prviBroj, drugiBroj);

            Console.WriteLine("Najveći broj koji je djeljiv s oba unesena broja je: " + najveciDjeljiviBroj);
        }

        static int PronadiNajveciDjeljiviBroj(int broj1, int broj2)
        {
            int manjiBroj = Math.Min(broj1, broj2);

            for (int i = manjiBroj; i >= 1; i--)
            {
                if (broj1 % i == 0 && broj2 % i == 0)
                {
                    return i;
                }
            }

            return 1;
        }
    }
