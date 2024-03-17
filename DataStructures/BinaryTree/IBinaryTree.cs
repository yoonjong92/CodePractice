namespace DataStructures.BinaryTree;

public interface IBinaryTree<TKey, TValue> where TKey : IComparable<TKey>
{
    int Count();
    string DrawTree();
    void Put(TKey key, TValue value);
}