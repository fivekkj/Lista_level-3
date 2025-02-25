using System;

class ex3
{
    static void Main()
    {
        //Escreva o programa C # para contar o número total de elementos  negativos no array. 
        
        Console.Write("Insira o número de elementos no array: ");
        int arraySize = int.Parse(Console.ReadLine());

        Random random = new Random();
        int[] array = new int[arraySize];
        int negativeCount = 0;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(-20, 10);
            if (array[i] < 0)
            {
                negativeCount++;
            }
        }

        Console.WriteLine("Numeros negativos no array: " + negativeCount);
        Console.WriteLine("Os números negativos são:");

        foreach (int number in array)
        {
            if (number < 0)
            {
                Console.Write(number + " ");
            }
        }

        Console.ReadKey();
    }
}
