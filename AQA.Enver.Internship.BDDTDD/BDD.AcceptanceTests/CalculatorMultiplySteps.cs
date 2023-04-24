namespace AQA.Enver.Internship.BDDTDD.BDD.AcceptanceTests;

[Binding]
public class CalculatorMultiplySteps
{
    private Calculator _calculator;
    
    [Given(@"I start calculator")]
    public void GivenIStartCalculator()
    {
        ScenarioContext.StepIsPending();
    }
    
    [Given(@"the first number  is  10")]
    public void GivenTheFirstNumberIs()
    {
        _calculator.FirstNumber = 10;
    }

    [Given(@"the second number  is  15")]
    public void GivenTheSecondNumberIs()
    {
        _calculator.SecondNumber = 15;
    }

    [When(@"the two numbers are multiplied")]
    public void WhenTheTwoNumbersAreMultiplied()
    {
        _calculator.Multiplication();
    }
    
    [Then(@"the result should be  150")]
    public void ThenTheResultShouldBe()
    {
        Assert.AreEqual(_calculator.Result,150);
    }
}