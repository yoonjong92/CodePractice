using System.Threading.Channels;

namespace Algorithms.Sort;

public static class MergeSortExtension
{
    public static void MergeSort(this List<int> list, int start, int end)
    {
        if (start == end)
            return;

        if (start + 1 == end)
        {
            if (list[start] > list[end])
                (list[start], list[end]) = (list[end], list[start]);
            return;
        }
        
        MergeSort(list,start,(start+end)/2);
        MergeSort(list,(start+end)/2 + 1, end);
        var clone = list.GetRange(start, end - start + 1);

        int ss = 0, ee = (end-start)/2 + 1;
        int idx = start;
        while (ss <= (end-start)/2 || ee <= end-start)
        {
            if (ee > end-start)
            {
                list[idx++] = clone[ss];
                ss++;
                continue;
            }

            if (ss > (end-start)/2)
            {
                list[idx++] = clone[ee];
                ee++;
                continue;
            }

            if (clone[ss] < clone[ee])
            {
                list[idx++] = clone[ss];
                ss++;
                continue;
            }
            
            list[idx++] = clone[ee];
            ee++;
        }
    }
}