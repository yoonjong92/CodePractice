using System.Globalization;

namespace DataStructures.Tree;

public interface IBinaryTree<TKey, TValue> where TKey : IComparable<TKey>
{
    INode<TKey,TValue>? GetRoot();

}