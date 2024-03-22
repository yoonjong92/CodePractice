namespace DataStructures.HashTable;

public class Data<T>
{
    public string Key;
    public T Value;
} 
    
public class HashTable<T>
{
    private int _size;
    private LinkedList<Data<T>>[] _buckets;

    public HashTable(int size)
    {
        _size = size;
        _buckets = new LinkedList<Data<T>>[size];
        for (int i = 0; i < size; i++)
            _buckets[i] = new LinkedList<Data<T>>();
    }

    public void Put(string key, T value)
    {
        var index = GetIndex(key);
        foreach (var data in _buckets[index])
        {
            if (data.Key == key)
            {
                data.Value = value;
                return;
            }
        }

        _buckets[index].AddLast(new Data<T>() { Key = key, Value = value });
    }
    
    public T Get(string key) 
    {
        var index = GetIndex(key);
        foreach (var data in _buckets[index])
        {
            if (data.Key == key)
            {
                return data.Value;
            }
        }

        return default;
    }

    private int GetIndex(string key)
    {
        var sum = 0;
        foreach (var t in key)
        {
            sum += t;
        }

        return sum % _size;
    }
}