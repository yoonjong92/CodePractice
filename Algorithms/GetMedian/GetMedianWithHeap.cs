using DataStructures.Heap;

namespace Algorithms.GetMedian;

public class GetMedianWithHeap
{
    private Heap<int, int> _minHeap = new Heap<int, int>();
    private Heap<int, int> _maxHeap = new Heap<int, int>(true);
    private int _median = -1;

    public void Put(int x)
    {
        if (_median == -1)
        {
            _median = x;
            return;
        }

        if (_median < x)
        {
            _minHeap.Put(x,x);
        }
        else
        {
            _maxHeap.Put(x,x);
        }

        if (_minHeap.Count() > _maxHeap.Count() + 1)
        {
            _maxHeap.Put(_median,_median);
            _median = _minHeap.Peek()?.Item1 ?? -1;
            _minHeap.Pop();
        }

        if (_maxHeap.Count() > _minHeap.Count())
        {
            _minHeap.Put(_median,_median);
            _median = _maxHeap.Peek()?.Item1 ?? -1;
            _maxHeap.Pop();
        }
    }

    public int Get()
    {
        return _median;
    }
}