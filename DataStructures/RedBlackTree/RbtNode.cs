namespace DataStructures.Tree;

public enum NodeColor
{
    Red,
    Black
}

public class RbtNode<TKey, TValue> : BaseNode<TKey, TValue> where TKey : IComparable<TKey>
{
    public NodeColor Color;
}