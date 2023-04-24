namespace AQA.Enver.Internship.NUnit;
[Parallelizable(ParallelScope.Children)]
public class SubtractionTest
{
    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        Console.WriteLine("I am a onetime SetUp attribute from subtraction class");
    }

    [Test(Description = "First test on subtraction", Author = "Enver Seferov")]
    [TestCaseSource(typeof(TestData),nameof(TestData.TestDataArray))]
    [Category("Unit test")]
    [Order(3)]
    public void FirstSubtractionTestCase(int arg1,int arg2)
    {
        Calculator calculator = new Calculator();
        Assert.AreEqual(arg1-arg2,calculator.Subtraction(arg1,arg2));
    }
    
    [NonParallelizable]
    [Test(Description = "Second test on subtraction", Author = "Enver Seferov")]
    [TestCase(16,10)]
    [TestCase(4,21)]
    [Category("Unit test")]
    [Order(2)]
    public void SecondSubtractionTestCase(int arg1,int arg2)
    {
        Calculator calculator = new Calculator();
        Assert.AreEqual(arg1-arg2,calculator.Subtraction(arg1,arg2));
    }
    
    [Test(Description = "Third test on subtraction", Author = "Enver Seferov")]
    [TestCase(-6,10)]
    [TestCase(123547,214568)]
    [TestCase(1478,0)]
    [Category("Unit test")]
    [Order(1)]
    public void ThirdSubtractionTestCase(int arg1,int arg2)
    {
        Calculator calculator = new Calculator();
        Assert.AreEqual(arg1-arg2,calculator.Subtraction(arg1,arg2));
    }
    
    [Test(Description = "Forth test on subtraction especially for retry attribute", Author = "Enver Seferov")]
    [TestCase(-6,10)]
    [Category("Unit test")]
    [Retry(3)]
    public void ForthSubtractionTestCase(int arg1,int arg2)
    {
        Calculator calculator = new Calculator();
        Assert.AreEqual(4,calculator.Subtraction(arg1,arg2));
    }
  
    [OneTimeTearDown]
    public void OneTimeTearDown()
    {
        Console.WriteLine("I am a onetime TearDown attribute from subtraction class");
    }
}