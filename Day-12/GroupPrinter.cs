
namespace Day_12
{
    public static class GroupPrinter
    {
        public static void Print(List<List<string>> groups)
        {
            Console.WriteLine("[");
            foreach (var g in groups)
            {
                var quoted = g.Select(s => $"\"{s}\"");
                Console.WriteLine("  [" + string.Join(", ", quoted) + "],");
            }
            Console.WriteLine("]");
        }
    }
}
