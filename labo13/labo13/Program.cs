Random rnd = new Random();
int[,] optellingArray = new int[3, 5];

for (int i = 0; i < optellingArray.GetLength(1); i++)
{
    optellingArray[0, i] = rnd.Next(1, 10);
}

for (int i = 0; i < optellingArray.GetLength(1); i++)
{
    Console.Write($"Getal {i + 1}: ");
    int.TryParse(Console.ReadLine(), out  optellingArray[1, i]);
}

for (int i = 0; i < optellingArray.GetLength(1); i++)
{
    optellingArray[2, i] = optellingArray[1, i] + optellingArray[0, i];
}

for (int i = 0; i < optellingArray.GetLength(0); i++)
{
    Console.WriteLine($"Rij {i+1} ==> {optellingArray[i, 0]}, {optellingArray[i, 1]}, {optellingArray[i, 2]}, {optellingArray[i, 3]}, {optellingArray[i, 4]}");
}

Console.ReadLine();