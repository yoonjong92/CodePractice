namespace DataStructures.BinaryTree;

public interface IBinaryTree<TKey, TValue> where TKey : IComparable<TKey>
{
    INode<TKey,TValue>? GetRoot();

}