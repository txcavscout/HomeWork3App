

string? firstName = null;

Console.Write("Enter your first name: ");
firstName = Console.ReadLine();

if (firstName.ToLower() == "tim" || firstName.ToLower() == "timothy")
{
    Console.WriteLine("Hello Professor.");
}
else if (String.IsNullOrEmpty(firstName))
{
    Console.WriteLine("You did not enter a name fool.");
}
else
{
    Console.WriteLine("Greetings fellow student.");
}

