using DataStructures;
using DataStructures.RedBlackTree;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello World");

        var rb = new RedBlackTree<int, int>();
        rb.Hello();
        rb.Enqueue(1,5);
        rb.Enqueue(2,123);
        rb.Enqueue(3,41);
        rb.Enqueue(4,12);
        rb.Enqueue(5,122);
        Console.WriteLine(rb.GetValueOrNull(4));
    }
}