using DataStructures.BinaryTree;

namespace DataStructures.RedBlackTree;

public class RedBlackTree<TKey, TValue> : BaseBinaryTree<TKey, TValue> where TKey : IComparable<TKey>
{
    
    public void Enqueue(TKey key, TValue value)
    {
        var node = new RbtNode<TKey, TValue>()
        {
            Key = key,
            Value = value,
            Color = NodeColor.Red,
        };
        
        if (_root == null)
        {
            _root = node;
            node.Color = NodeColor.Black;
            return;
        }
        
        var cur = _root;
        while (cur != null)
        {
            if (key.CompareTo(cur.Key) == 0)
            {
                cur.Value = value;
                return;
            }
            
            if (key.CompareTo(cur.Key) < 0)
            {
                if (cur.Left == null)
                {
                    cur.Left = node;
                    break;
                }

                cur = cur.Left;
                continue;
            }

            if (cur.Right == null)
            {
                cur.Right = node;
                break;
            }
            
            cur = cur.Right;
        }

        node.Parent = cur;
        Rearrange(node);
    }

    private void Rearrange(RbtNode<TKey,TValue> node)
    {
        // 노드가 루트면 검으색으로만 바꾸고 끝낸다
        if (node.Parent is not RbtNode<TKey, TValue> parent)
        {
            node.Color = NodeColor.Black;
            return;
        }
        
        // 부모가 블랙 이면 그대로 둔다
        if (parent.Color == NodeColor.Black)
            return;

        // 조부모가 없음 = 부모(Root)가 블랙이라는 조건에 걸리므로 이런 일은 없지만, warning 제거를 위해 추가
        if (parent.Parent is not RbtNode<TKey, TValue> grandParent)
            return;
        
        var uncle = grandParent.Other(parent) as RbtNode<TKey,TValue>;
        // 삼촌이 없거나 블랙이면 회전시킨다 (나, 부모, 조부모를 정렬해서 중간값을 부모로 쓴다)
        if (uncle == null || uncle.Color == NodeColor.Black)
        {
            parent.Remove(node);
            grandParent.Remove(parent);
            
            var min = MinNode(node, parent, grandParent);
            var max = MaxNode(node, parent, grandParent);
            var mid = node;
            if (min != parent && max != parent)
                mid = parent;
            if (min != grandParent && max != grandParent)
                mid = grandParent;

            //
            if (grandParent.Parent?.Right == grandParent)
                grandParent.Parent.Right = mid;
            if (grandParent.Parent?.Left == grandParent)
                grandParent.Parent.Left = mid;
            if (grandParent == _root)
                _root = mid;
            
            //
            mid.Parent = grandParent.Parent;
            mid.Left = min;
            mid.Right = max;
            min.Color = NodeColor.Black;
            
            //
            min.Parent = mid;
            min.Color = NodeColor.Red;
            
            //
            max.Parent = mid;
            max.Color = NodeColor.Red;
            
            return;
        }
        
        // 삼촌이 레드면 삼촌과 부모를 블랙으로 바꾸고 조부모를 레드로 바꾼다
        uncle.Color = NodeColor.Black;
        parent.Color = NodeColor.Black;
        grandParent.Color = NodeColor.Red;
        Rearrange(grandParent);
    }
    
    public void Hello()
    {
        Console.WriteLine("Hello");
    }

    private static RbtNode<TKey, TValue> MinNode(RbtNode<TKey, TValue> a, RbtNode<TKey, TValue> b, RbtNode<TKey, TValue> c)
    {
        if (a.Key.CompareTo(b.Key) <= 0 && a.Key.CompareTo(c.Key) <= 0)
            return a;
        if (b.Key.CompareTo(a.Key) <= 0 && b.Key.CompareTo(c.Key) <= 0)
            return b;
        return c;
    }
    
    private static RbtNode<TKey, TValue> MaxNode(RbtNode<TKey, TValue> a, RbtNode<TKey, TValue> b, RbtNode<TKey, TValue> c)
    {
        if (a.Key.CompareTo(b.Key) > 0 && a.Key.CompareTo(c.Key) > 0)
            return a;
        if (b.Key.CompareTo(a.Key) > 0 && b.Key.CompareTo(c.Key) > 0)
            return b;
        return c;
    }
}