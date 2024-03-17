using Algorithms.GetPrimeNumber;

namespace Test.Algorithms;

public class GetPrimeNumberTest
{
    [Test]
    public void Process()
    {
        var gp = new GetPrimeNumber(10000000);
        var input = new List<int>()
        {
            2,3,5,7,9,13,17,21,24,29,12314231,3123123,24123143,123213,11111111,21412523
        };
        foreach (var num in input)
        {
            Console.WriteLine($"{num} : {gp.IsPrime(num)}");
            Assert.That(gp.IsPrime(num), Is.EqualTo(gp.IsPrimeCalcAll(num)), $"input : {num}");
        }
    }
}