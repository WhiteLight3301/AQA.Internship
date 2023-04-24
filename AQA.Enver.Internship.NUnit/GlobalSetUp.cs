namespace AQA.Enver.Internship.NUnit;

[SetUpFixture]
public class GlobalSetUp
{
    [OneTimeSetUp]
    public void GlobalOneTimeSetUp()
    {
        Console.WriteLine("I am GlobalOneTimeSetUp");
    }
}