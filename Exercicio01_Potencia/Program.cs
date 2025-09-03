using System;
internal class Program
{
    static int Potencia(int a, int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            return a * Potencia(a, n - 1);
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Informe o valor de a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Informe o valor de n: ");
        int n = int.Parse(Console.ReadLine());
        int resultado = Potencia(a, n);
        Console.Write(resultado);
        Console.ReadKey();
    }
}