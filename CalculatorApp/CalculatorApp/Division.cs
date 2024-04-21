
namespace CalculatorApp;

internal class Division
{
    public int OperationForTwoLevelInput(int[] userInput, int result)
    {
        for (int i = 0; i < 2; i++)
        {
            result = userInput[0] / userInput[1];
        }
        Console.WriteLine($"The division of given two number of inputs: {result}");
        return result;
    }
    public int OperationForThreeLevelInput(int[] userInput, int result)
    {
        for (int i = 0; i < 3; i++)
        {
            result = userInput[0] / userInput[1] / userInput[2];
        }
        Console.WriteLine($"The division of given three number of inputs: {result}");
        return result;
    }
    public int OperationForNLevelInput(int[] userInput, int result)
    {
        for (int i = 0; i < 3; i++)
        {
            result = userInput[0] / userInput[1] / userInput[2];
        }
        Console.WriteLine($"The division of given three number of inputs: {result}");
        return result;
    }
}
