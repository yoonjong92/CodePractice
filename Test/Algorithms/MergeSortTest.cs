using Algorithms.Sort;

namespace Test.Algorithms;

public class MergeSortTest
{
    [Test]
    public void Test()
    {
        var list = new List<int>() { 1, 4, 2, 31, 152, 2, 55, 115 };
        var list2 = new List<int>(list);

        list.MergeSort(0, list.Count-1);
        list2.Sort();
        for (var i = 0; i < list.Count; i++)
        {
            Assert.That(list[i], Is.EqualTo(list2[i]), $"index : {i}");
        }
    }
}