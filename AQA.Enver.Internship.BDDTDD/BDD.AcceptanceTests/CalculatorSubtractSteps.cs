namespace AQA.Enver.Internship.BDDTDD.BDD.AcceptanceTests;

[Binding]
public class CalculatorSubtractTest
{
    private Calculator _calculator;

    [Given(@"I start the calculator")]
    public void GivenIStartTheCalculator()
    {
        _calculator = new Calculator();
    }

    [Given(@"the first  number is 70")]
    public void GivenTheFirstNumberIs()
    {
        _calculator.FirstNumber = 70;
    }

    [Given(@"the second number is 50")]
    public void GivenTheSecondNumberIs()
    {
        _calculator.SecondNumber = 50;
    }

    [When(@"the two numbers are deducted")]
    public void WhenTheTwoNumbersAreDeducted()
    {
        _calculator.Subtraction();
    }
    
    [Then(@"the result have to be 20")]
    public void ThenTheResultHaveToBe()
    {
        Assert.AreEqual(_calculator.Result,-20);
    }
}