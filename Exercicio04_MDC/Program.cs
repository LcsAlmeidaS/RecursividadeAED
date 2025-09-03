using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{

    static int MDC(int x, int y)
    {
        if (y == 0)
            return x;
        return MDC(y, x % y);
    }

    static void Main(string[] args)
    {
        Console.Write("x: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("y: ");
        int y = int.Parse(Console.ReadLine());
        Console.WriteLine("MDC: " + MDC(x, y));
        Console.ReadKey();
    }
}