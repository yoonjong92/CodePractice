namespace Algorithms.Sort;

public static class QuickSortExtension
{
    public static void QuickSort(this List<int> list, int start, int end)
    {
        if (end <= start)
            return;
        
        if (start + 1 == end)
        {
            if(list[start] > list[end])
                (list[start], list[end]) = (list[end], list[start]);
            return;
        }
        
        var pivot = start;
        var i = start + 1;
        var j = end;
        while (i <= j)
        {
            while (i <= end && list[i] < list[pivot])
                i++;
            while (j > pivot && list[j] > list[pivot])
                j--;
            if (i < j)
                (list[i], list[j]) = (list[j], list[i]);
        }
        (list[pivot], list[j]) = (list[j], list[pivot]);
        (pivot, j) = (j, pivot);
        QuickSort(list,start,pivot-1);
        QuickSort(list,pivot+1,end);
    }
}