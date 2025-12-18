decimal[][] stores =
{
    new decimal[] {1.07m, 2.92m, 3.45m, 1.09m, 0.89m},
    new decimal[] {1.08m, 2.35m, 3.75m, 1.12m, 0.69m},
    new decimal[] {0.98m, 2.48m, 3.62m, 1.10m, 0.72m}
};

decimal total = 0;

for (int i = 0; i < stores.Length; i++)
{
    decimal sum = 0;

    for (int j = 0; j < stores[i].Length;   j++)
    {
        sum += stores[i][j];
    }
    total += sum;

    Console.WriteLine($"{(i+1)} {stores[i].Length} {sum.ToString("F2")}");
}

Console.WriteLine(total.ToString("F2"));

Console.ReadLine();