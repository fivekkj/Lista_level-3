using System;

class ex6
{
    static void Main()
    {
        Console.WriteLine("Digite o tamanho do array:");
        int tamanho = int.Parse(Console.ReadLine());

        int[] array = new int[tamanho];
        Random random = new Random();

        for (int i = 0; i < tamanho; i++)
        {
            array[i] = random.Next(1, 225);
        }
        Console.clear();

        Console.WriteLine("Array gerado:");
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        int soma = 0;
        foreach (int item in array)
        {
            soma += item;
        }

        Console.WriteLine("Soma de todos os elementos do array: " + soma);
    }
}
