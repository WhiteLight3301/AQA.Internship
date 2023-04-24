namespace AQA.Enver.Internship.BDDTDD.TDD.UnitTest;

public class Calculator
{
    
    public  void Addition()
    {
        Result = FirstNumber + SecondNumber;
    }
        
    public  void Subtraction()
    {
        Result = FirstNumber - SecondNumber;
    }
        
    public  void Multiplication()
    {
        Result = FirstNumber - SecondNumber;
    }
        
    public  void Division()
    {
        Result = FirstNumber / SecondNumber;
    }
    
    public int Result { get; set; }
    public int FirstNumber { get; set; }
    public int SecondNumber { get; set; }
}