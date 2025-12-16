int[][] workshops =
{
    new int[] {5, 7, 3},    // Workshop 1: 3 elves
    new int[] {6, 4, 4, 5}, // Workshop 2: 4 elves
    new int[] {10, 2}       // Workshop 3: 2 elves
};

int total = 0;

for (int i = 0; i < workshops.Length; i++)
{
    int workshopTotal = 0;

    for (int j = 0; j < workshops[i].Length; j++)
    {
        workshopTotal += workshops[i][j];
    }

    total += workshopTotal;

    Console.WriteLine($"Workshop {i+1} made {workshopTotal} gifts");
}

Console.WriteLine($"Santa’s total gift count is {total}");


Console.ReadLine();