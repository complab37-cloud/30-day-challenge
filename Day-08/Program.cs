Console.WriteLine("Input:");
int N = Convert.ToInt32(Console.ReadLine());


for (int i = 0; i < N + 2; i++)
{
    Console.Write("# ");
}
Console.WriteLine();

for (int row = 1; row <= N; row++)
{
    Console.Write("# "); 

    for (int col = 1; col <= N; col++)
    {
        int sum = row + col;

        if (sum % 3 == 0 && sum % 5 == 0)
        {
            Console.Write("G ");
        }
        else if (sum % 3 == 0)
        {
            Console.Write("T ");
        }
        else if (sum % 5 == 0)
        {
            Console.Write("S ");
        }
        else
        {
            Console.Write(". ");
        }
    }

    Console.WriteLine("#"); 
}

for (int i = 0; i < N + 2; i++)
{
    Console.Write("# ");
}

Console.ReadLine();   