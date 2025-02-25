using System;

class ex8
{
    static void Main()
    {
        Random rand = new Random();
        int[] array = new int[20];

    
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(1, 11);
        }

        Console.WriteLine("Array gerado:");
        for (int i = 0; i < array.Length; i++)
        {
            if (i < array.Length - 1)
            {
                Console.Write(array[i] + ", ");
            }
            else
            {
                Console.Write(array[i]);
            }
        }

        int totalDuplicates = 0;

        
        for (int i = 0; i < array.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    count++;
                }
            }
            if (count > 1)
            {
                totalDuplicates += count - 1;
                for (int k = 0; k < array.Length; k++)
                {
                    if (array[k] == array[i])
                    {
                        array[k] = -1; 
                    }
                }
            }
        }

        Console.WriteLine("\nTotal de elementos duplicados: " + totalDuplicates);
    }
}