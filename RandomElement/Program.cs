string[] snacks = { "sushi", "pizza", "chicken wings", "burger", "spicy noodles", "oily kebab" };

Random rnd =  new Random();
int randomIndex = rnd.Next(0, snacks.Length-1);

Console.WriteLine($"Tonight we eat {snacks[randomIndex]}.");