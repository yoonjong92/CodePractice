namespace Algorithms.GetMedian;

public class GetMedianWithList
{
    private readonly List<int> _list = new List<int>();
    private bool _sorted = false;
    
    public void Put(int x)
    {
        _list.Add(x);
        _sorted = false;
    }

    public int Get()
    {
        if (_list.Count < 1)
            return -1;
        
        if (_sorted == false)
        {
            _list.Sort();
            _sorted = true;
        }

        return _list[(_list.Count-1) / 2];
    }
}