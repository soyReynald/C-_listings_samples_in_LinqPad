<Query Kind="Program" />

void Main()
{
	Console.WriteLine("\n The option is minifying operation; Please insert the first number and second to operate with...");		
	var first_parameter_rest = Convert.ToInt32(Console.ReadLine());
	
	Console.WriteLine("\n The option is sum; Please insert the first number and second to operate with...");
	var first_parameter_sum = Convert.ToInt32(Console.ReadLine());
	
	Console.WriteLine("\n The option is sum 2 number; Please insert the first number and second to operate with...");
	var first_parameter_g = Convert.ToInt32(Console.ReadLine());
	
	Console.WriteLine("\n The option is multiplication; Please insert the first number and second to operate with...");		
	var first_parameter_mult = Convert.ToInt32(Console.ReadLine());
	
	Console.WriteLine("\n The result in gradians to THIS formula (x-y+g(Δ)) " + (((first_parameter_rest - first_parameter_sum) + first_parameter_g) * first_parameter_mult) + "°");

	// 60, 120, 180, etc...
}

// Define other methods and classes here