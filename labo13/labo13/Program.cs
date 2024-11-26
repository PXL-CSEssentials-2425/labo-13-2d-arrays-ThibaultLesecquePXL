Random rnd = new Random();
int[,] sumArray = new int[3, 5];

// Random integers op rij 1
for (int i = 0; i < sumArray.GetLength(1); i++)
{
    sumArray[0, i] = rnd.Next(1, 11);
}

Console.WriteLine("==== 2-dimensionele array ====");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Geef 5 getallen voor opvullen van tweede rij");

// Input integers op rij 2
for (int i = 0; i < sumArray.GetLength(1); i++)
{
    Console.Write($"Getal {i + 1}: ");
    int.TryParse(Console.ReadLine(), out sumArray[1, i]);
}

Console.WriteLine();

// Optelling van rij 1 en rij 2 op rij 3
for (int i = 0; i < sumArray.GetLength(1); i++)
{
    sumArray[2, i] = sumArray[1, i] + sumArray[0, i];
}

// Uitprinten van de gehele 2D-array
for (int i = 0; i < sumArray.GetLength(0); i++)
{
    Console.WriteLine($"Rij {i+1} ==> {sumArray[i, 0]}, {sumArray[i, 1]}, {sumArray[i, 2]}, {sumArray[i, 3]}, {sumArray[i, 4]}");
}

Console.WriteLine();
Console.WriteLine("Druk op een toets om af te sluiten.");
Console.ReadKey();