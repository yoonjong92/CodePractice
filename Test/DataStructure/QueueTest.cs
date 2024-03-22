namespace Test.DataStructure;

public class QueueTest
{
    [Test]
    public void Test()
    {
        var queue = new Queue<int>();
        var myQueue = new DataStructures.Queue.Queue<int>(5);
        
        myQueue.Push(1);
        queue.Enqueue(1);
        Assert.That(myQueue.Front(), Is.EqualTo(queue.Peek()), "FAILED");
        myQueue.Push(2);
        queue.Enqueue(2);
        Assert.That(myQueue.Front(), Is.EqualTo(queue.Peek()), "FAILED");
        myQueue.Push(3);
        queue.Enqueue(3);
        Assert.That(myQueue.Front(), Is.EqualTo(queue.Peek()), "FAILED");
        myQueue.Push(4);
        queue.Enqueue(4);
        Assert.That(myQueue.Front(), Is.EqualTo(queue.Peek()), "FAILED");
        myQueue.Pop();
        queue.Dequeue();
        Assert.That(myQueue.Front(), Is.EqualTo(queue.Peek()), "FAILED");
        myQueue.Pop();
        queue.Dequeue();
        Assert.That(myQueue.Front(), Is.EqualTo(queue.Peek()), "FAILED");
        myQueue.Push(5);
        queue.Enqueue(5);
        Assert.That(myQueue.Front(), Is.EqualTo(queue.Peek()), "FAILED");
        myQueue.Push(6);
        queue.Enqueue(6);
        Assert.That(myQueue.Front(), Is.EqualTo(queue.Peek()), "FAILED");
        myQueue.Push(6);
        queue.Enqueue(6);
        Assert.That(myQueue.Front(), Is.EqualTo(queue.Peek()), "FAILED");
    }
}