
namespace CalculatorApp;

internal class Subtraction
{
    public int OperationForTwoLevelInput(int[] userInput,int result)
    {
        for (int i = 0; i < 2; i++)
        {
            result = userInput[0] - userInput[1];
        }
        Console.WriteLine($"The difference of given two number of inputs: {result}");
        return result;
    }
    public int OperationForThreeLevelInput(int[] userInput, int result)
    {
        for (int i = 0; i < 3; i++)
        {
            result = userInput[0] - userInput[1] - userInput[2];
        }
        Console.WriteLine($"The difference of given two number of inputs: {result}");
        return result;
    }
    public int OperationForNLevelInput(int[] userInput, int result)
    {
        int n = userInput.Length;
        int[] difference = new int[n-1];   
            for (int i = 0; i < n; i++)
            {
            difference[i] = userInput[i+1] - userInput[i];
            }
            result = difference[n - 1];
            
        
        Console.WriteLine($"The difference of given {n} number of inputs: {result}");
        return result;
    }
}
