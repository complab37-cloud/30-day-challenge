int h = 14;
int m = 56;

h = (h + 1) % 24;

Console.WriteLine($"{h} {m}");

Console.ReadLine();