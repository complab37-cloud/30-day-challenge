using Day_05;

for (int i = 10; i >= 0; i--)
{
    Console.Clear();

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"TIMER: {i}");
    Console.WriteLine();
    Console.ResetColor();

    Ascii.PrintDigit(i);

    Console.WriteLine();


    int msgIndex = 10 - i;
    if (msgIndex >= 0 && msgIndex < Messages.CountDownMessages.Length)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(Messages.CountDownMessages[msgIndex]);
        Console.ResetColor();
    }

    Thread.Sleep(1000);
}

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine();
Console.WriteLine("==> SANTA’S SLEIGH IS LAUNCHING! <==");
Console.ResetColor();


Console.ReadLine();