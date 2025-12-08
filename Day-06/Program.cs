int a = 23, b = 55, c = 14;

int totalMinutes = a * 60 + b + c;

totalMinutes %= 1440;

int v = totalMinutes / 60;
int m = totalMinutes % 60;

Console.WriteLine($"Santa will land at: {v}:{m}");

Console.ReadLine();