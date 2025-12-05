
namespace Day_05
{
    public static class Ascii
    {
        public static void PrintDigit(int number)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            if (number == 10)
            {
                var one = Digits.DIGIT[1];
                var zero = Digits.DIGIT[0];

                for (int i = 0; i < one.Length; i++)
                {
                    Console.WriteLine(one[i] + "   " + zero[i]);
                }
                return;
            }

            string[] lines = Digits.DIGIT[number];

            foreach (var line in lines)
            {
                
                Console.WriteLine(line);
            }
            Console.ResetColor();
        }
    }
}
