using DataStructures.RedBlackTree;

namespace Test.DataStructure;

public class RedBlackTreeTest
{
    [Test]
    public void Test()
    {
        var rb = new RedBlackTree<int, int>();
        rb.Put(1,5);
        rb.Put(2,123);
        rb.Put(3,41);
        rb.Put(4,12);
        rb.Put(5,122);
        Console.WriteLine(rb.GetValueOrNull(4));
        Assert.That(rb.GetValueOrNull(4), Is.EqualTo(12), "FAILED");
        rb.Put(10,123);
        rb.Put(200,1);
        rb.Put(300,1);
        rb.Put(150,1);
        rb.Put(155,1);
        Console.Write(rb.DrawTree());
    }
}