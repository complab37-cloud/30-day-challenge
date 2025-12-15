Console.WriteLine("Input three numbers separated by spaces and press enter:");
double [] prices = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

double smallestPrice = prices.Min();

Console.WriteLine();
Console.WriteLine("Peter will spend {0:F2}",smallestPrice);

Console.ReadLine();