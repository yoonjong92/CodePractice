using System.Security.Cryptography;

namespace DataStructures.BinaryTree;

public interface INode<TKey, TValue> where TKey : IComparable<TKey>
{
    TKey Key { get; set; }
    TValue Value { get; set; }

    INode<TKey, TValue>? Parent { get; set; }
    INode<TKey, TValue>? Left { get; set; }
    INode<TKey, TValue>? Right { get; set; }

    string ToDrawString();
}