using System;

class ex2
{
    static void Main()
    {
        Console.Write("Digite o número de elementos no array: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        Console.WriteLine("Digite os elementos do array:");
        for (int i = 0; i < n; i++)
        {
            Console.Write("Elemento {0}: ", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Array na ordem inversa:");
        for (int i = n - 1; i >= 0; i--)
        {
            Console.Write(array[i] + " ");
        }
    }
}