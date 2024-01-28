using System;

public class Program
{
   public static void Main()
    {
        Console.WriteLine("Unesite niz znakova:");
        string niz = Console.ReadLine();

        char najcesciZnak = PronadiNajcesciZnak(niz);
        int brojPojavljivanja = IzracunajBrojPojavljivanja(niz, najcesciZnak);

        Console.WriteLine("Najčešći znak je: {najcesciZnak}");
        Console.WriteLine("Broj pojavljivanja: {brojPojavljivanja}");
    }

    static char PronadiNajcesciZnak(string niz)
    {
        int[] brojac = new int[256]; // Pretpostavljamo ASCII znakove

        foreach (char znak in niz)
        {
            brojac[znak]++;
        }

        char najcesciZnak = '\0';
        int najcescePojavljivanje = 0;

        for (int i = 0; i < brojac.Length; i++)
        {
            if (brojac[i] > najcescePojavljivanje)
            {
                najcescePojavljivanje = brojac[i];
                najcesciZnak = (char)i;
            }
        }

        return najcesciZnak;
    }

    static int IzracunajBrojPojavljivanja(string niz, char znak)
    {
        int brojPojavljivanja = 0;

        foreach (char c in niz)
        {
            if (c == znak)
            {
                brojPojavljivanja++;
            }
        }

        return brojPojavljivanja;
    }
}
