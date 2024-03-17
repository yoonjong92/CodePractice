namespace DataStructures.BinaryTree;

public abstract class BaseBinaryTree<TKey, TValue> : IBinaryTree<TKey, TValue> where TKey : IComparable<TKey>
{
    protected INode<TKey, TValue>? _root;
    protected int _count = 0;
    
    public INode<TKey, TValue>? GetRoot()
    {
        return _root;
    }

    public int Count()
    {
        return _count;
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

    public string DrawTree()
    {
        if (_root == null)
            return "";
        return Dfs(_root, 0,"");
    }

    private string Dfs(INode<TKey, TValue> node, int depth, string str)
    {
        if (node.Left != null)
            str = Dfs(node.Left, depth + 1, str);
        str += new String(' ', 10 * depth) + node.ToDrawString() + "\n";
        if (node.Right != null)
            str = Dfs(node.Right, depth + 1, str);
        return str;
    }
}