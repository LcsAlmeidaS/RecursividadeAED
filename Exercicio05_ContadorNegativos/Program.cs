using System;
internal class Program
{
    static int ContarNegativos(int[] array, int n)
    {
        if (n <= 0)
            return 0;

        int count = ContarNegativos(array, n - 1);

        if (array[n - 1] < 0)
            count++;

        return count;
    }

    static void Main(string[] args)
    {
        Console.Write("Tamanho do array: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        int quantidade = ContarNegativos(array, n);
        Console.WriteLine($"O array possui {quantidade} números negativos.");
        Console.ReadKey();
    }
}