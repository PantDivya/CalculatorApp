// See https://aka.ms/new-console-template for more information

Console.WriteLine("Welcome to MyCalculator App");

#region performOperation
int result;

bool userOperation = true;
while (userOperation) 
{
    DisplayMessage();

    int userOption = ReadUserInput();
    if (userOption == 6)
    {
        break;
    }

    Console.WriteLine("Provide first input:");
    int first = int.Parse(Console.ReadLine());


    Console.WriteLine("Provide Second input:");
    int second = int.Parse(Console.ReadLine());

    CalculateOperation(userOption, first, second);
   
}

#endregion



#region Methods
void CalculateOperation(int userOption, int first, int second)
{
    if (userOption == 1)
    {
        result = first + second;
        Console.WriteLine($"Sum : {result} ");
    }
    else if (userOption == 2)
    {
        result = first - second;
        Console.WriteLine($"Difference : {result} ");
    }
    else if (userOption == 3)
    {
        result = first * second;
        Console.WriteLine($"Product : {result} ");
    }
    else if (userOption == 4)
    {
        result = first / second;
        Console.WriteLine($"division : {result} ");
    }
    else if (userOption == 5)
    {
        for(int  i = 1; i <= second; i++)
        {
            Console.WriteLine($" {first} * {i} = {first*i} ");
        }
        
    }
    else
    {
        Console.WriteLine("Invalid Selection");
    }
}

void DisplayMessage()
{
    Console.WriteLine("Please provide any operation");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Product table");
    Console.WriteLine("6. Exit");
}

int ReadUserInput()
{
    int operation = int.Parse(Console.ReadLine());
   
    return operation ;
}

#endregion