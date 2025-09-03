using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    static void Binario(int num)
    {
        if (num == 0)
            return;

        Binario(num / 2);

        Console.Write(num % 2);
    }

    static void Main(string[] args)
    {
        Console.Write("Digite um número inteiro: ");
        int num = int.Parse(Console.ReadLine());
        Binario(num);

        Console.ReadKey();
    }
}
