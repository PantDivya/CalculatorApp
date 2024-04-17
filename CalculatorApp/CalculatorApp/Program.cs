// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to MyCalculator App");
Console.WriteLine("Please provide any operation");
Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Multiplication");
Console.WriteLine("4. Division");

#region performOperation

string operation = Console.ReadLine();

if (operation == "1")
{

}

#endregion

Console.WriteLine("Provide first input:");
int first = int.Parse( Console.ReadLine());

Console.WriteLine("Provide Second input:");
int second = int.Parse( Console.ReadLine());


int sum = first + second;

Console.WriteLine($"Your sum is: {sum}");