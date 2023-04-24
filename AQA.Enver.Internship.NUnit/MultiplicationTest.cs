[assembly:LevelOfParallelism(1)]
namespace AQA.Enver.Internship.NUnit;

public class MultiplicationTest : BaseTests
{
    [Test(Description = "First test on multiplication", Author = "Enver Seferov")]
    [TestCaseSource(typeof(TestData),nameof(TestData.TestDataArray))]
    [Category("Unit test")]
    [Order(3)]
    public void FirstMultiplicationTestCase(int arg1,int arg2)
    {
        Calculator calculator = new Calculator();
        Assert.AreEqual(arg1*arg2,calculator.Multiplication(arg1,arg2));
    }
    
    [Test(Description = "Second test on multiplication", Author = "Enver Seferov")]
    [TestCase(16,10)]
    [TestCase(4,21)]
    [Category("Unit test")]
    [Order(1)]
    public void SecondMultiplicationTestCase(int arg1,int arg2)
    {
        Calculator calculator = new Calculator();
        Assert.AreEqual(arg1*arg2,calculator.Multiplication(arg1,arg2));
    }
    
    [Ignore("Ignore attribute example")]
    [Test(Description = "Third test on multiplication", Author = "Enver Seferov")]
    [TestCase(-6,10)]
    [TestCase(123547,214568)]
    [TestCase(1478,0)]
    [Category("Unit test")]
    [Order(2)]
    public void ThirdSubtractionTest(int arg1,int arg2)
    {
        Calculator calculator = new Calculator();
        Assert.AreEqual(arg1*arg2,calculator.Multiplication(arg1,arg2));
    }
}