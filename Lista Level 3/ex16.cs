using System;

class ex16
{
    static void Main()
    {
        Random rand = new Random();
        int[] array = new int[10];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(1, 101);
        }

        Console.WriteLine("Array original:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine("\nDigite a posição do elemento a ser deletado (0 a {0}):", array.Length - 1);
        int position = int.Parse(Console.ReadLine());

        if (position < 0 || position >= array.Length)
        {
            Console.WriteLine("Posição inválida.");
            return;
        }

        int[] newArray = new int[array.Length - 1];
        for (int i = 0, j = 0; i < array.Length; i++)
        {
            if (i == position) continue;
            newArray[j++] = array[i];
        }

        Console.WriteLine("Array após deletar o elemento na posição {0}:", position);
        foreach (int num in newArray)
        {
            Console.Write(num + " ");
        }
    }
}