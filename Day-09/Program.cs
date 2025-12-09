Console.WriteLine("Input the number of melons and press enter:");
int melons = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input the weights of each melon separated by spaces and press enter:");
double[] melonsWeights = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

double average = melonsWeights.Average();

int closestIndex = 0;
double minDifference = Math.Abs(melonsWeights[0] - average);

for (int i = 1; i < melons; i++)
{
    double diff = Math.Abs(melonsWeights[i] - average);
    if (diff < minDifference)
    {
        minDifference = diff;
        closestIndex = i;
    }
}
Console.WriteLine();
Console.WriteLine($"{closestIndex + 1} {melonsWeights[closestIndex]:F2}");

Console.ReadLine();    