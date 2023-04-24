namespace AQA.Enver.Internship.BDDTDD.BDD.AcceptanceTests;

[Binding]
public class CalculatorDivideSteps
{
    private Calculator _calculator;
    
    [Given(@"I start calculator")]
    public void GivenIStartCalculator()
    {
        ScenarioContext.StepIsPending();
    }
    
    [Given(@"the first  digit is 45")]
    public void GivenTheFirstDigitIs()
    {
        ScenarioContext.StepIsPending();
    }

    [Given(@"the second digit is 5")]
    public void GivenTheSecondDigitIs()
    {
        _calculator.SecondNumber = 5;
    }

    [When(@"the two numbers are divided")]
    public void WhenTheTwoNumbersAreDivided()
    {
        _calculator.Division();
    }
    
    [Then(@"the result should be 9")]
    public void ThenTheResultShouldBe()
    {
        Assert.AreEqual(_calculator.Result,9);
    }

    [Then(@"the first  digit is -4")]
    public void ThenTheFirstDigitIs()
    {
        _calculator.FirstNumber = -4;
    }

    [Then(@"the second digit is -2")]
    public void ThenTheSecondDigitIs()
    {
        _calculator.SecondNumber = -2;
    }
    
    [Then(@"the result of that should be 2")]
    public void ThenTheResultOfThatShouldBe()
    {
        Assert.AreEqual(_calculator.Result,2);
    }
}