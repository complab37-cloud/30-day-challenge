int x = 3, y = 5; //x - valandos, y - minutes

int m = (x * 60) + y; //valandas ir minutes verciam i minutes
int s = m * 60; //minutes verciam i sekundes

Console.WriteLine($"Minutes passed: {m}" );
Console.WriteLine($"Second passed: {s}" );

Console.ReadLine();