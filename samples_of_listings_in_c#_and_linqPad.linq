<Query Kind="Program" />

void Main()
{
	
    string text = "Programming";
    int length = 0;

    Console.WriteLine($"Calculating length of \"{text}\":");

    foreach (char ch in text)
    {
        length++;
    }

    Console.WriteLine($"Length = {length}");
    Console.WriteLine("Length calculation completed successfully.");
	
	// LISTING without using DUMB
	Console.WriteLine("\n");
	Console.WriteLine("\n");
	Console.WriteLine("List title of food that can be eaten... \n");
	
	List<string> fruits = new List<string> { "Orange", "Vegetable", "Cherry", "Grapes", "Mango" };

    foreach (string fruit in fruits)
    {
        Console.WriteLine(fruit);
    }
}

// Define other methods and classes here
