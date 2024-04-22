namespace CalculatorApp;

internal class ReadWrite
{
    public void WriteFile()
    {
        using (StreamWriter sw = new StreamWriter("E:\\dotNetTraining\\Calculator_App\\CalculatorApp\\LogFile\\log.txt"))
        {
            sw.Write("Hello World");
            Console.WriteLine("Data saved in log file");
        }
    }
    public void ReadFile()
    {
        using(StreamReader sr = new StreamReader("E:\\dotNetTraining\\Calculator_App\\CalculatorApp\\LogFile\\log.txt"))
        {
            sr.ReadToEnd();
        }
    }
}
