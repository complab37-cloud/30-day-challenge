using Day_14;

Cart giftCart = new Cart();

giftCart.Add("train", 30);
giftCart.Add("doll", 20);

giftCart.ApplyDiscount("PROMO10");
Console.WriteLine(giftCart.Total()); // 45.00

giftCart.Remove("train");
Console.WriteLine(giftCart.Total()); // 18.00


Console.ReadLine();