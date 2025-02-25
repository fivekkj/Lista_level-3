using System;

class ex5
{
    static void Main()
    {
        //Escreva o programa C # para inserir um elemento no array.

        Console.Write("Digite a quantidade de números no array: ");
        int arraySize = int.Parse(Console.ReadLine());

        int[] array = new int[arraySize];
        for (int i = 0; i < arraySize; i++)
        {
            Console.Write("Digite o elemento {0}: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.Clear();
        Console.WriteLine("Array antes da alteração:");
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        Console.Write("Digite o elemento a ser inserido: ");
        int element = int.Parse(Console.ReadLine());

        Console.Write("Digite a posição onde o elemento deve ser inserido: ");
        int position = int.Parse(Console.ReadLine());

        if (position >= 0 && position < array.Length)
        {
            array[position] = element;
        }
        else
        {
            Console.WriteLine("Posição inválida.");
        }

        Console.WriteLine("Array após o usuário inserir o elemento:");
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
    }
}
