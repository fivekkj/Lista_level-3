
using System;

class ex1
{
    static void Main()
    {
        //Escreva um programa em C# para armazenar elementos em um array e imprimi-lo.

        Console.WriteLine("Digite 5 números para armazenar no array:");
        int[] array = new int[5];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Número {0}: ", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.Clear();
        Console.WriteLine("Os números armazenados no array são:");

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}

