// See https://aka.ms/new-console-template for more information

using CalculatorApp;

Console.WriteLine("Welcome to MyCalculator App");

#region objectInstances
Instruction instruction = new Instruction();

#endregion

#region performOperation
int result;
string operationType="";
int userOption;


bool userOperation = true;
while (userOperation) 
{
    //DisplayMessage();
    instruction.GetCoreInstruction();
    //method call for user input for selecting operation 
    userOption = ReadUserInputOperation();
    //condition for exit
    if (userOption == 6)
    {
        break;
    }
     string operation = ReturnOperationType(userOption);
    instruction.GetSubCoreInstruction(operation);


    //method call for arry input value
    int[] UserInput = ReadUserInput();
    //print n number of input
    for(int i = 0; i < UserInput.Length; i++)
    {
        Console.WriteLine(UserInput[i]);
    }

    //Two level of input 
    /*Console.WriteLine("Provide first input:");
    int first = int.Parse(Console.ReadLine());


    Console.WriteLine("Provide Second input:");
    int second = int.Parse(Console.ReadLine());*/

    //method call for calculation 
    /* CalculateOperation(userOption, first, second);*/

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

int ReadUserInputOperation()
{
    int operation = int.Parse(Console.ReadLine());
    return operation;
}
string ReturnOperationType(int userOption)
{
    //select operation and show instruction for level of input
    if (userOption == 1)
    {
        operationType = "Addition";
    }
    else if (userOption == 2)
    {
        operationType = "Subtraction";
    }
    else if (userOption == 3)
    {
        operationType = "Multiplication";
    }
    else if (userOption == 4)
    {
        operationType = "Division";
    }
    return operationType;
}
int[] ReadUserInput()
{
    //Read n number of input
    /*Console.WriteLine("how many input do you want? ");*/
    Console.WriteLine("Enter your inputs: ");

    string n = Console.ReadLine();

    string[] inputs = n.Split(",");
    int[] inputValue = new int[inputs.Length];
    for(int i = 0; i< inputs.Length; i++)
    {
        inputValue[i] = int.Parse(inputs[i]);

    }
    return inputValue;

}

#endregion