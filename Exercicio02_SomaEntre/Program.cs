using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    static int SomaEntre(int m, int n)
    {
        if (n == m)
            return n;

        int soma = m + SomaEntre(m + 1, n);
        return soma;
    }

    static void Main(string[] args)
    {
        Console.Write("Valor de m: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Valor de n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"Soma entre {m} e {n}: {SomaEntre(m, n)}");
        Console.ReadKey();
    }
}
