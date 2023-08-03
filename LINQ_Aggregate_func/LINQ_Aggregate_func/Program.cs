// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;

internal static class Program
{

    static void aggrMinWithoutLinq(int[] Numbers)
    {

        int? result = null;

        foreach (int i in Numbers)
        {
            if (i % 2 == 0)
            {
                if (!result.HasValue || i < result)
                {
                    result = i;
                }
            }
        }

        Console.WriteLine("aggrMinWithoutLinq: {0}", result);
    }

    static void aggrSumWithoutLinq(int[] Numbers)
    {
        int reuslt = 0;

        foreach (var i in Numbers)
        {
            reuslt += i;
        }

        Console.WriteLine("aggrSumWithoutLinq: {0}", reuslt);
    }

    static void aggrSum(int[] Numbers)
    {
        int result = Numbers.Where(x => x % 2 == 0).Sum();
        Console.WriteLine("aggrSum: {0}", result);
    }

    static void aggrMin2(int[] Numbers)
    {
        int result = Numbers.Where(x => x % 2 == 0).Min();
        Console.WriteLine("aggrMin2: {0}", result);
    }

    static void aggrMax(int[] Numbers)
    {
        int result = Numbers.Max();
        Console.WriteLine("aggrMax: {0}", result);

    }

    static void aggrCountWithoutLinq(int[] Numbers)
    {
        int? result = 0;

        foreach (int i in Numbers)
        {
            result += 1;
        }

        Console.WriteLine("aggrCountWithoutLinq: {0}", result);
    }

    static void aggrCount(int[] Numbers)
    {
        int result = Numbers.Count();
        Console.WriteLine("aggrCount: {0}", result);
    }

    static void aggrAverage(int[] Numbers)
    {
        double result = Numbers.Average();
        Console.WriteLine("aggrAverage: {0}", result);
    }

    static void Main(string[] args)
    {
        int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        #region aggrMinWithoutLinq
        aggrMinWithoutLinq(Numbers);
        #endregion

        #region aggrMin2
        aggrMin2(Numbers);
        #endregion

        #region aggrMax 
        aggrMax(Numbers);
        #endregion

        #region aggrSumWithoutLinq
        aggrSumWithoutLinq(Numbers);
        #endregion

        #region aggrSum
        aggrSum(Numbers);
        #endregion

        #region aggrCountWithOutLinq 
        aggrCountWithoutLinq(Numbers);
        #endregion

        #region aggrCount 
        aggrCount(Numbers);
        #endregion

        #region aggrAverage 
        aggrAverage(Numbers);
        #endregion

    }
}

