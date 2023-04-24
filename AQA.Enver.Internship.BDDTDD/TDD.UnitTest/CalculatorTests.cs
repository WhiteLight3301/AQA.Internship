namespace AQA.Enver.Internship.BDDTDD.TDD.UnitTest;

public class CalculatorTests
{
    [Test]
    public void SumTest()
    {
        var calculator = new TDDCalculator();
        var result = calculator.Addition(4, 8);
        Assert.That(result,Is.EqualTo(12));
    }

    [Test]
    public void SubtractTest()
    {
        var calculator = new TDDCalculator();
        var result = calculator.Subtraction(45, 2);
        Assert.That(result,Is.EqualTo(43));
    }

    [Test]
    public void DivisionTest()
    {
        var calculator = new TDDCalculator();
        var result = calculator.Division(10, 2);
        Assert.That(result,Is.EqualTo(5));
    }
    
    [Test]
    public void MultiplicationTest()
    {
        var calculator = new TDDCalculator();
        var result = calculator.Multiplication(45, 4);
        Assert.That(result,Is.EqualTo(180));
    }
}