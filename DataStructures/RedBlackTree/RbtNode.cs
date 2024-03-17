using DataStructures.BinaryTree;

namespace DataStructures.RedBlackTree;

public enum NodeColor
{
    Red,
    Black
}

public class RbtNode<TKey, TValue> : BaseNode<TKey, TValue> where TKey : IComparable<TKey>
{
    public NodeColor Color;

    public override string ToDrawString()
    {
        return Key + ":" + Value + ":" + Color;
    }
}