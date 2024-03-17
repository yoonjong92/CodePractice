using DataStructures.Heap;

namespace Test.DataStructure;

public class HeapTest
{
    [Test]
    public void Test()
    {
        var heap = new Heap<int, int>();
        heap.Put(113,1);
        heap.Put(214,1);
        heap.Put(123,1);
        heap.Put(44,1);
        heap.Put(521,1);
        heap.Put(1,1);
        Console.Write(heap.DrawTree());
        Console.WriteLine();
        Console.WriteLine();
        Assert.That(heap.Peek()?.Item1, Is.EqualTo(1), "FAILED");
        heap.Pop();
        Console.Write(heap.DrawTree());
        Console.WriteLine();
        Console.WriteLine();
        Assert.That(heap.Peek()?.Item1, Is.EqualTo(44), "FAILED");
        heap.Put(1,1);
        Assert.That(heap.Peek()?.Item1, Is.EqualTo(1), "FAILED");
        heap.Put(6,1);
        heap.Put(8,1);
        heap.Put(1223,1);
        heap.Put(66,1);
        heap.Pop();
        heap.Pop();
        heap.Pop();
        Console.Write(heap.DrawTree());
        Console.WriteLine();
        Console.WriteLine();
        Assert.That(heap.Peek()?.Item1, Is.EqualTo(44), "FAILED");
    }
    
    [Test]
    public void DsecTest()
    {
        var heap = new Heap<int, int>(true);
        heap.Put(113,1);
        heap.Put(214,1);
        heap.Put(123,1);
        heap.Put(44,1);
        heap.Put(521,1);
        heap.Put(1,1);
        Console.Write(heap.DrawTree());
        Console.WriteLine();
        Console.WriteLine();
        Assert.That(heap.Peek()?.Item1, Is.EqualTo(521), "FAILED");
        heap.Pop();
        Console.Write(heap.DrawTree());
        Console.WriteLine();
        Console.WriteLine();
        Assert.That(heap.Peek()?.Item1, Is.EqualTo(214), "FAILED");
        heap.Put(1,1);
        Assert.That(heap.Peek()?.Item1, Is.EqualTo(214), "FAILED");
        heap.Put(6,1);
        heap.Put(8,1);
        heap.Put(1223,1);
        heap.Put(66,1);
        heap.Pop();
        heap.Pop();
        heap.Pop();
        Console.Write(heap.DrawTree());
        Console.WriteLine();
        Console.WriteLine();
        Assert.That(heap.Peek()?.Item1, Is.EqualTo(113), "FAILED");
    }
}