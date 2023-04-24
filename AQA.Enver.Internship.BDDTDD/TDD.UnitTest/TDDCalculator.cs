namespace AQA.Enver.Internship.BDDTDD.TDD.UnitTest;

public class TDDCalculator
{
    public  int Addition(int input1, int input2)
    {
        int result = input1 + input2;
        Console.WriteLine(result);
        return result;
    }
        
    public  int Subtraction(int input1, int input2)
    {
        int result = input1 - input2;
        return result;
    }
        
    public  int Multiplication(int input1, int input2)
    {
        int result = input1 * input2;
        return result;
    }
        
    public  int Division(int input1, int input2)
    {
        int result = 0;
        try
        {
            result = input1 / input2;
        }
        catch (Exception e)
        {
            Console.WriteLine("Zero division denied!");
        }
        return result;
    }
}