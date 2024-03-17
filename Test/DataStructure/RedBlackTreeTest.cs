using DataStructures.RedBlackTree;

namespace Test.DataStructure;

public class RedBlackTreeTest
{
    [Test]
    public void Test()
    {
        var rb = new RedBlackTree<int, int>();
        rb.Enqueue(1,5);
        rb.Enqueue(2,123);
        rb.Enqueue(3,41);
        rb.Enqueue(4,12);
        rb.Enqueue(5,122);
        Console.WriteLine(rb.GetValueOrNull(4));
        Assert.That(rb.GetValueOrNull(4), Is.EqualTo(12), "FAILED");
    }
}