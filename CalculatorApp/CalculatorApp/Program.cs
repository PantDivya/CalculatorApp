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
string inputLevel;
int[] userInput ;
/*int[] UserInput;*/


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

    inputLevel = ReadUserInputlevel();

    userInput = UserInputForOperation(inputLevel);

        //print n number of input
    for(int i = 0; i < userInput.Length; i++)
    {
        Console.WriteLine(userInput[i]);
    }

    

    //method call for calculation 
    CalculateOperation(inputLevel, userInput);

}

#endregion



#region Methods
void CalculateOperation(string inputLevel, int[] userInput)
{
    if (inputLevel == "1.1")
    {
        int sum = 0;
        for (int i = 0; i < userInput.Length; i++)
        {
            sum = +userInput[i];
            Console.WriteLine($"The of {userInput.Length} number of inputs: {sum}");
        }
    }
    /*else if (userOption == 2)
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
        for (int i = 1; i <= second; i++)
        {
            Console.WriteLine($" {first} * {i} = {first * i} ");
        }

    }*/
    else
    {
        Console.WriteLine("Invalid Selection");
    }
}

int ReadUserInputOperation()
{
    int operation = int.Parse(Console.ReadLine());
    return operation;
}

string ReadUserInputlevel()
{
    string inputLevel = Console.ReadLine();
    return inputLevel;
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
int[] GetTwoLevelInput()
{
    //Two level of input 
    Console.WriteLine("Enter your inputs: ");

    string n = Console.ReadLine();

    string[] inputs = n.Split(",");
    int[] inputValue = new int[inputs.Length];
    for (int i = 0; i < 2; i++)
    {
        inputValue[i] = int.Parse(inputs[i]);

    }
    return inputValue;
}

int[] GetThreeLevelInput()
{
    //Three level of input
    Console.WriteLine("Enter your inputs: ");

    string n = Console.ReadLine();

    string[] inputs = n.Split(",");
    int[] inputValue = new int[inputs.Length];
    for (int i = 0; i < 3; i++)
    {
        inputValue[i] = int.Parse(inputs[i]);
    }
    return inputValue;
}
int[] GetNNumberOfInput()
{
    //Read n number of input
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


int[] UserInputForOperation(string inputLevel)
{
    int[] UserInput = new int[0];
    if (inputLevel == "1.1")
    {
        Console.WriteLine("get 2 level input");
        UserInput = GetTwoLevelInput();
    }
    else if (inputLevel == "1.2")
    {
        Console.WriteLine("get 3 level input");
        UserInput = GetThreeLevelInput();
    }
    else if (inputLevel == "1.3")
    {
        Console.WriteLine("get n level of input");
        UserInput = GetNNumberOfInput();
    }
    else
    {
        Console.WriteLine("Invalid Input");
    }
    return UserInput;
}
#endregion