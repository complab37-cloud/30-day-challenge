Console.WriteLine("Enter the toy prices separated by semicolons:");

string input = Console.ReadLine();

string[] prices = input.Split(';');
double totalPrice = 0;
int i = 0;

foreach (string part in prices)
{
    if (double.TryParse(part.Trim(), out double price))
    {
        if (price == 0)
            break;

        if (price > 10)
        {
            totalPrice += price;
            i++;
        }
    }
}

Console.WriteLine($"Total price of magical toys: {totalPrice} EUR");
Console.WriteLine($"Number of magical toys: {i}");

Console.ReadLine();