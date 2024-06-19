Console.WriteLine(1 != 2);

string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));

Console.WriteLine(pangram.Contains("fox") == false);
Console.WriteLine(!pangram.Contains("fox")); // Logical negation.

int saleAmount = 999;
int discount = saleAmount > 1000 ? 100 : 50; // Ternary conditional operator.
Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

// Coin flipp.
Random coin = new Random();
int result = coin.Next(1, 3);
Console.WriteLine($"Coin landed on {(result > 1 ? "heads." : "tails.")}");
Console.WriteLine($"Coin landed on {(coin.Next(1, 3) > 1 ? "heads." : "tails.")}"); // Compact version.

// Permission level.
string permission = "Admin|Manager";
int level = 57;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}