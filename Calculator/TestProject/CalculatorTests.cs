using static Calculator.Calculator;

namespace TestProject;

[TestFixture]
public class CalculatorTests
{
    // [SetUp]
    // public void Setup()
    // {
    // }
    //
    // [Test]
    // public void Test1()
    // {
    //     Assert.Pass();
    // }
    
    [Test]
    public void Add_int_and_return_correct_int()
    {
        const int expected = 3;
        var actual = Add(1, 2);
            
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Minus_int_and_return_correct_int()
    {
        const int expected = -1;
        var actual = Minus(1, 2);
        
        Assert.AreEqual(expected, actual);
    }
}
