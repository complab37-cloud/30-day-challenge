
Dictionary<string, decimal> priceList = new Dictionary<string, decimal>
        {
            { "London", 0.50m },
            { "Paris", 0.40m },
            { "NewYork", 0.70m }
        };

var elves = new List<(string first, string last, List<(string city, int min)> calls)>
        {
            ("Jingle", "Sparkfoot", new List<(string, int)>
            {
                ("London", 12),
                ("Paris", 7)
            }),
            ("Twinkle", "Icicletoes", new List<(string, int)>
            {
                ("NewYork", 20),
                ("London", 5)
            }),
            ("Pudding", "Gumdrops", new List<(string, int)>
            {
                ("Paris", 15)
            })
        };

elves.Sort((a, b) => a.last.CompareTo(b.last));

decimal totalAll = 0;

foreach (var elf in elves)
{
    decimal sum = 0;

    foreach (var call in elf.calls)
    {
        sum += priceList[call.city] * call.min;
    }

    totalAll += sum;

    Console.WriteLine($"{elf.last} {elf.first} {sum.ToString("F2")}");
}

Console.WriteLine("Total: " + totalAll.ToString("F2"));

Console.ReadLine();