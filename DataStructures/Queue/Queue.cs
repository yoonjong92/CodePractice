namespace DataStructures.Queue;

public class Queue<T>
{
    private T[] _queue;
    private int _head, _tail;
    private int _size;
    
    public Queue(int size)
    {
        _queue = new T[size+1];
        _size = size+1;
    }

    public void Push(T x)
    {
        if (NextIdx(_tail) == _head)
            throw new OverflowException();
        _queue[_tail] = x;
        _tail = NextIdx(_tail);
    }

    public void Pop()
    {
        if (_head == _tail)
            return;

        _head = NextIdx(_head);
    }

    public int Count()
    {
        return _tail - _head;
    }

    public bool IsEmpty()
    {
        return _tail == _head;
    }

    public T Front()
    {
        if (_head == _tail)
            return default;

        return _queue[_head];
    }

    private int NextIdx(int index)
    {
        if (index + 1 == _size)
            return 0;
        
        return index + 1;
    }
}