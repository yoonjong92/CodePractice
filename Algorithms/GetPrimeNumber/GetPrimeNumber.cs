namespace Algorithms.GetPrimeNumber;

public class GetPrimeNumber
{
    private List<long> _primeNumberList = new List<long>();
    private int _preCalculate;
    public GetPrimeNumber(int preCalculate)
    {
        _preCalculate = preCalculate;
        
        var arr = new bool[preCalculate+1];
        for (long i = 2; i <= preCalculate; i++)
        {
            if(arr[i] == false)
                _primeNumberList.Add(i);

            for (long j = i; i * j <= preCalculate; j++)
            {
                arr[i * j] = true;
            }
        }
    }

    public bool IsPrime(long x)
    {
        if (x <= _preCalculate)
            return _primeNumberList.Contains(x);

        for (var i = 0; _primeNumberList[i] * _primeNumberList[i] <= x; i++)
        {
            if (x % _primeNumberList[i] == 0)
            {
                return false;
            }
        }

        for (var i = _preCalculate + 1; i * i <= x; i++)
        {
            if (x % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    public bool IsPrimeCalcAll(int x)
    {
        for (var i = 2; i * i <= x; i++)
        {
            if (x % i == 0)
                return false;
        }

        return true;
    }
}