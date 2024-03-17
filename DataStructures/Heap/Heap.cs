using DataStructures.BinaryTree;

namespace DataStructures.Heap;

public class Heap<TKey,TValue> : IBinaryTree<TKey, TValue> where TKey : IComparable<TKey>
{
    private List<(TKey, TValue)> _heap = [];
    private int _desc = 1;
    
    public Heap(bool desc = false)
    {
        if (desc)
            _desc = -1;
    }
    
    public int Count()
    {
        return _heap.Count;
    }

    public string DrawTree()
    {
        var str = "";
        var space = 2;
        for (int i = 0; i < _heap.Count; i++)
        {
            str += _heap[i].Item1 + ":" + _heap[i].Item2 + " ";
            
            if (i+2 == space)
            {
                str += "\n";
                space *= 2;
            }
        }

        return str;
    }
    public (TKey, TValue)? Peek()
    {
        return _heap.Count < 1 ? default((TKey, TValue)?) : (_heap[0].Item1, _heap[0].Item2);
    }

    public void Put(TKey key, TValue value)
    {
        _heap.Add((key,value));
        Arrange(_heap.Count-1);
    }

    public void Pop()
    {
        if (_heap.Count < 1)
            return;
        
        _heap[0] = _heap.Last();
        _heap.RemoveAt(_heap.Count-1);
        ArrangeBack(0);
    }

    private void Arrange(int index)
    {
        while (index > 0)
        {
            if (_heap[index].Item1.CompareTo(_heap[index / 2].Item1) * _desc >= 0)
                return;
            (_heap[index], _heap[index / 2]) = (_heap[index / 2], _heap[index]);
            index /= 2;
        }
    }

    private void ArrangeBack(int index)
    {
        while (index < _heap.Count)
        {
            if (_heap.Count <= index * 2)
                return;
            
            var minKey = _heap[index * 2].Item1;
            var minI = index * 2;
            if (_heap.Count > index * 2 + 1 && minKey.CompareTo(_heap[index * 2 + 1].Item1) * _desc > 0)
            {
                minKey = _heap[index * 2 + 1].Item1;
                minI = index * 2 + 1;
            }

            if (minKey.CompareTo(_heap[index].Item1) * _desc >= 0)
                return;
            
            (_heap[index], _heap[minI]) = (_heap[minI], _heap[index]);
            index = minI;
        }
    }
}