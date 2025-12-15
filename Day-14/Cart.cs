
namespace Day_14
{
    public class Cart
    {
        List<string> ids = new List<string>();
        List<decimal> prices = new List<decimal>();
        decimal discount = 0;

        public void Add(string id, decimal price)
        {
            if (price < 0)
            {
                return;
            }
            if (ids.Contains(id))
            {
                return;
            }

            ids.Add(id);
            prices.Add(price);
        }

        public void Remove(string id)
        {
            int index = ids.IndexOf(id);
            if (index >= 0)
            {
                ids.RemoveAt(index);
                prices.RemoveAt(index);
            }
        }

        public void ApplyDiscount(string code)
        {
            if (code == "PROMO10")
            {
                discount = 0.10m;
            }
            else if (code == "PROMO25")
            {
                discount = 0.25m;
            }
            else if (code == "SANTA50")
            {
                discount = 0.50m;
            }
        }

        public decimal Total()
        {
            decimal sum = 0;
            for (int i = 0; i < prices.Count; i++)
            {
                sum += prices[i];
            }

            return Math.Round(sum * (1 - discount), 2);
        }
    }
}
