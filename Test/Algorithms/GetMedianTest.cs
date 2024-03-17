using Algorithms.GetMedian;

namespace Test.Algorithms;

public class GetMedianTest
{
    [Test]
    public void Process()
    {
        var input = new List<int>()
        {
            1,1,1,1,1,1, 2,5,5,5,5,5, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12
        };
        var mh = new GetMedianWithHeap();
        var ml = new GetMedianWithList();
        foreach (var num in input)
        {
            mh.Put(num);
            ml.Put(num);
            Console.WriteLine(mh.Get());
            Assert.That(mh.Get(), Is.EqualTo(ml.Get()), $"input : {num}");
        }
    }
}