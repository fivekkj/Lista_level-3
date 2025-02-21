
//13. Escreva um programa em C# para separar inteiros impas e pares em dois arrays separados

Random rand = new Random();
Console.Write("Digite o valor do Array: ");
int sizeOrigin = int.Parse(Console.ReadLine());


int[] origin = new int[sizeOrigin];
int[] arraypar = new int[sizeOrigin];
int[] arrayimpar = new int[sizeOrigin];

int countPar = 0;
int countImpar = 0;

Console.WriteLine("Os numeros inteiros são:");
for (int i = 0; i < sizeOrigin; i++)
{
    origin[i] = rand.Next(1, 100);
    
    Console.Write("{0}  ", origin[i]);
 }

Console.WriteLine("");

for (int i = 0; i < sizeOrigin; i++)
{
    if (origin[i] % 2 == 0)
    {
        arraypar[countPar] = origin[i];
        countPar++;
    }
    else
    {
        arrayimpar[countImpar] = origin[i];
        countImpar++;
    }
}

Console.WriteLine("Array Par: ");
for (int i = 0; i < countPar; i++)
{
    Console.Write("{0} ",arraypar[i]);
}
Console.WriteLine("");
Console.WriteLine("Array Impar:");
for (int i = 0; i < countImpar; i++)
{
    Console.Write("{0} ", arrayimpar[i]);
}