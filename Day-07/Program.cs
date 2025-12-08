Console.WriteLine("Enter the number of rows:");
int n  = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the number of seats in the first row:");
int k = Convert.ToInt32(Console.ReadLine());

int s = n * (2 * k + (n - 1) * 2) / 2;

Console.WriteLine($"The total number of seats: {s}");

Console.ReadLine();