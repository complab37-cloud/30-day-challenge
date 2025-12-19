int n = int.Parse(Console.ReadLine());
string[] a  = Console.ReadLine().Split(' ');
int [] forTrade = new int[101];

for (int i = 0; i < n; i++)
{
    forTrade[int.Parse(a[i])]++;
}

for (int j = 1; j <= 100; j++)
{
    if(forTrade[j] > 1)
    {
        Console.Write(j + " ");
    }
}

Console.ReadLine();