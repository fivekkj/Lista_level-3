using System;

class ex4
{
    static void Main()
    {
        //Escreva o programa C # para contar o número total de elementos  negativos no array. 

        Random random = new Random();
        int[] array = new int[10];
        int negativeCount = 0;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(-10, 11);
        }

        foreach (int number in array)
        {
            if (number < 0)
            {
                negativeCount++;
            }
        }

        Console.Write("Array: ");
        for (int i = 0; i < array.Length; i++)
        {
            if (i > 0)
            {
                Console.Write(", ");
            }
            Console.Write(array[i]);
        }
        Console.WriteLine();
        Console.WriteLine("Número total de elementos negativos no array: " + negativeCount);
    }
}
