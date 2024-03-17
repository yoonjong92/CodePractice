namespace DataStructures.Tree;

public abstract class BaseBinaryTree<TKey, TValue> : IBinaryTree<TKey, TValue> where TKey : IComparable<TKey>
{
    protected INode<TKey, TValue>? _root;
    
    public INode<TKey, TValue>? GetRoot()
    {
        return _root;
    }
    
    public TValue? GetValueOrNull(TKey key)
    {
        var cur = _root;
        while (cur != null)
        {
            if (key.CompareTo(cur.Key) == 0)
                return cur.Value;
            
            if (key.CompareTo(cur.Key) < 0)
            {
                if (cur.Left == null)
                    return default;

                cur = cur.Left;
                continue;
            }

            if (cur.Right == null)
                return default;
            
            cur = cur.Right;
        }

        return default;
    }
}