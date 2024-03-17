namespace DataStructures.BinaryTree;

public class BaseNode<TKey, TValue> : INode<TKey, TValue> where TKey : IComparable<TKey>
{
    public TKey Key { get; set; }
    public TValue Value { get; set; }
    public INode<TKey, TValue>? Parent { get; set; }
    public INode<TKey, TValue>? Left { get; set; }
    public INode<TKey, TValue>? Right { get; set; }

    public INode<TKey, TValue>? Other(BaseNode<TKey, TValue> child)
    {
        if (child == Left)
            return Right;
        return Left;
    }

    public void Remove(INode<TKey, TValue> child)
    {
        if (Left == child)
            Left = null;
        if (Right == child)
            Right = null;
    }

    public virtual string ToDrawString()
    {
        return Key + ":" + Value;
    }
}