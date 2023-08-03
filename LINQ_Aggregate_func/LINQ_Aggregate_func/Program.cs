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

    static void aggrAverageWithoutLinq(int[] Numbers)
    {
        double sum = 0.0;
        double result = 0;
        int total = 0;

        foreach (int i in Numbers)
        {
            if (i % 2 == 0)
            {
                sum += i;
                total += 1;
            }
        }

        result = sum / total;
        Console.WriteLine("aggrAverageWithoutLinq: {0}", result);


    }

    static void AggrCountriesMinMax(string[] countries)
    {
        int minCount = countries.Min(x => x.Length);
        int maxCount = countries.Max(x => x.Length);

        Console.WriteLine("The shortest country name has {0} characters in its name", minCount);
        Console.WriteLine("The largest country name has {0} characters in its name", maxCount);

    }

    static void AggrShortCountriesWithoutLinq(string[] countries)
    {
        int? result = null;

        foreach (string str in countries)
        {
            //Console.WriteLine("str.Length < result: {0} < {1} = {2}", str.Length, result, str.Length < result);
            if (!result.HasValue || str.Length < result)
            {
                result = str.Length;
            }
        }

        Console.WriteLine("AggrShortCountriesWithoutLinq The shortest country name has {0} characters in its name", result);
    }


    static void Main(string[] args)
    {
        int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        string[] Countries = { "India", "USA", "UK" };

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

        #region aggrAverageWithoutLinq 
        aggrAverageWithoutLinq(Numbers);
        #endregion

        #region aggrCountriesMinMax 
        AggrCountriesMinMax(Countries);
        #endregion

        #region aggrShortCountries
        AggrShortCountriesWithoutLinq(Countries);
        #endregion
    }
}

