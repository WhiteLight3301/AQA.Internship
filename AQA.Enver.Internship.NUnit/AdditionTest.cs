namespace AQA.Enver.Internship.NUnit;
[SingleThreaded]
[TestFixture]
public class AdditionTest
{
    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        Console.WriteLine("I am a onetime SetUp attribute");
    }

    [SetUp]
    public void SetUp()
    {
        Console.WriteLine("This is SetUp attribute");
    }

    [Test(Description = "First test on addition", Author = "Enver Seferov")]
    [TestCaseSource(typeof(TestData),nameof(TestData.TestDataArray))]
    [Category("Unit test")]
    [Order(2)]
    public void FirstTestCaseOnAddition(  int arg1,int arg2)
    {
        Calculator calculator = new Calculator();
        Assert.AreEqual(arg1+arg2,calculator.Addition(arg1,arg2));
    }

    [Test(Description = "Second test on addition", Author = "Enver Seferov")]
    [TestCase(456, 223)]
    [Category("Unit test")]
    [Order(1)]
    [NonParallelizable]
    public void SecondTestCaseOnAddition(int firstInput,int secondInput)
    {
        Calculator calculator = new Calculator();
        Assert.AreEqual(679,calculator.Addition(firstInput,secondInput));
    }

    [OneTimeTearDown]
    public void OneTimeTearDown()
    {
        Console.WriteLine("I am a onetime TearDown attribute");
    }

    [TearDown]
    public void TearDown()
    {
        Console.WriteLine("This is TearDown Attribute");
    }
}