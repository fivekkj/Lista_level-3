using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();
        int[] Arrayquit = new int[5];
        for (int i = 0; i < Arrayquit.Length; i++)
        {
            Arrayquit[i] = rand.Next(1, 101); 
        }

        int[] Arraydestiny = new int[Arrayquit.Length];

        for (int i = 0; i < Arrayquit.Length; i++)
        {
            Arraydestiny[i] = Arrayquit[i];
        }

        Console.WriteLine("Elements of the source array:");
        foreach (int element in Arrayquit)
        {
            Console.Write(element + " ");
        }

        Console.WriteLine("\nElements of the destination array:");
        foreach (int element in Arraydestiny)
        {
            Console.Write(element + " ");
        }
    }
}