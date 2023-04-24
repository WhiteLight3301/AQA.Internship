namespace AQA.Enver.Internship.BDDTDD.BDD.AcceptanceTests;

[Binding]
public class CalculatorSumSteps
{
    private Calculator _calculator;
    
    [Given(@"I start calculator")]
    public void GivenIStartCalculator()
    {
        _calculator = new Calculator();
    }

    [Given(@"the first  number is 14")]
    public void GivenTheFirstNumberIs()
    {
        _calculator.FirstNumber = 14;
    }

    [Given(@"the second number is 13247")]
    public void GivenTheSecondNumberIs()
    {
        _calculator.SecondNumber = 13247;
    }

    [When(@"this numbers are added")]
    public void WhenThisNumbersAreAdded()
    {
        _calculator.Addition();
    }

    [Then(@"the result should is 13261")]
    public void ThenTheResultShouldIs()
    {
        Assert.AreEqual(_calculator.Result,13261);
    }


    [Then(@"the first negative number is -44")]
    public void ThenTheFirstNegativeNumberIs()
    {
        ScenarioContext.StepIsPending();
    }

    [Then(@"the second positive number is 20")]
    public void ThenTheSecondPositiveNumberIs(int p0)
    {
        ScenarioContext.StepIsPending();
    }

    [When(@"this numbers are added together")]
    public void WhenThisNumbersAreAddedTogether()
    {
        _calculator.Addition();
    }

    [Then(@"the result of their sum should be -24")]
    public void ThenTheResultOfTheirSumShouldBe()
    {
        Assert.AreEqual(_calculator.Result,-24);
    }
}