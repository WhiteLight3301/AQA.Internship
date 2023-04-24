namespace AQA.Enver.Internship.NUnit;

[FixtureLifeCycle(LifeCycle.SingleInstance)]
[TestFixture]
public abstract class BaseTests
{
    [SetUp]
    public virtual void Setup()
    {
        Console.WriteLine("I am SetupFromBaseTests");
    }
}