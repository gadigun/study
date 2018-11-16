using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System;

public class CodingTestKata : MonoBehaviour {

	// Use this for initialization
	void Start () {
    }

    bool CheckArray(int [] arr)
    {
        int check = arr.Length;

        List<int> checklist = arr.ToList<int>();

        checklist.Sort();

        for (int i = 0; i < arr.Length; ++i)
        {
            if (checklist[i] != i + 1)
            {
                return false;
            }
        }

        return true;
    }


    void FindMinLength(int[,] maps)
    {
        int moveLength = 0;
    }

    void TestCoding()
    {
        var value = new int[,] { { 1, 1, 0 }, { 1, 1, 0 }, { 0, 0, 1 } };

        Debug.Log("Result : " + solutionT(3, value));
    }

    void FindLinkdedComptuer(int count, int index, int[,] com)
    {
        for (int i = 0; i < count; ++i)
        {
            if (com[index, i] == 1)
            {
                linkedList.Add(i);
                FindLinkdedComptuer(count, index, com);
            }
        }
    }

    List<int> linkedList = new List<int>();

    int solutionT(int n, int[,] computers)
    {
        int answer = 0;

        for (int i = 0; i < n; ++i)
        {
            FindLinkdedComptuer(n, i, computers);
        }

        return answer;
    }


    public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
    {
        List<int> result = new List<int>();

        for (int i = 0; i < listOfItems.Count; ++i)
        {
            if (listOfItems[i] is string)
                continue;

            result.Add((int)listOfItems[i]);
        }

        return result;
    }

    public static IEnumerable<int> GetIntegersFromList2(List<object> listOfItems)
    {
        return listOfItems.OfType<int>().Cast<int>();
    }

    public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
    {
        List<T> result = new List<T>();

        int length = iterable.Count();

        int i = 0;
        while (i < length)
        {
            T it = iterable.ElementAt(i);
            while (it.Equals(iterable.ElementAt(i)))
            {
                if (++i >= length)
                    break;
            }

            result.Add(it);
        }

        return result;
    }

    public void Test1()
    {
        //Debug.Log(UniqueInOrder("AAAABBBCCDAABBB").ToString());
        //Debug.Log(Maskify2("4556364607935616"));
        //Debug.Log(Maskify2("64607935616"));
        //Debug.Log(Maskify2("1"));
        //Debug.Log(Maskify2("11111"));
        //Debug.Log(Solution(10).Equals(23));
        //Debug.Log(Solution2(10).Equals(23));

        var value = new[] { 3, 30, 34, 31, 9, 90, 91, 96 };
        //Debug.Log(solution(value));


        var value2 = new[] { 1, 5, 2, 6, 3, 7, 4 };
        var commands = new[,] { { 2, 5, 3 }, { 4, 4, 1 }, { 1, 7, 3 } };

        //Debug.Log(solution2(value2, commands));

        //var value3 = new[] {3,0,6,1,5};
        var value3 = new[] { 1, 5, 2, 5, 76, 0, 2, 315, 3, 12, 62, 2, 5, 7, 34 };
        //Debug.Log(solution3(value3));

        var value4 = new[] { 20, 30, 10 };
        Debug.Log(solution4(value4));

        var value5 = new[] { 30, 30, 10 };
        Debug.Log(solution4(value5));

        var value6 = new[] { 40, 40, 10 };
        Debug.Log(solution4(value6));

        var value7 = new[] { 20, 10, 10 };
        Debug.Log(solution4(value7));
    }

    public static string Maskify(string cc)
    {
        if (cc.Length <= 4)
        {
            return cc;
        }

        string result = "";

        for (int i = 0; i < cc.Length - 4; ++i)
        {
            result += "#";
        }

        result += cc.Substring(cc.Length - 4);

        return result;
    }

    public static string Maskify2(string cc)
    {
        //return cc.Substring(cc.Length < 4 ? 0 : cc.Length - 4).PadLeft(cc.Length, '#');
        return cc.Length > 4 ? cc.Substring(cc.Length - 4).PadLeft(cc.Length, '#') : cc;
    }


    public static int Solution(int value)
    {
        int result = 0;
        for (int i = 0; i < value; ++i)
        {
            if ((i % 3) == 0 || (i % 5) == 0)
            {
                result += i;
            }
        }

        return result;
        //return Enumerable.Range(0, value).Where(x => x % 3 == 0 || x % 5 == 0).Sum();
    }


    public static int Solution2(int value)
    {
        int max = value - 1;
        int count3 = max / 3;
        int count5 = max / 5;
        int count15 = max / 15;
        return 3 * Sum(count3) + 5 * Sum(count5) - 15 * Sum(count15);
    }

    private static int Sum(int value)
    {
        return (1 + value) * value / 2;
    }

    public string solution(int[] numbers)
    {
        Array.Sort(numbers, (x, y) =>
        {
            string XY = x.ToString() + y.ToString();
            string YX = y.ToString() + x.ToString();
            return YX.CompareTo(XY);
        });
        if (numbers.Where(x => x == 0).Count() == numbers.Length) return "0";
        else return string.Join("", numbers);
    }


    public int[] solution2(int[] array, int[,] commands)
    {
        List<int> answer = new List<int>();
        List<int> data = array.ToList<int>();

        int startIndex = 0;
        int endIndex = 0;
        int valueIndex = 0;

        for (int i = 0; i < commands.GetLength(0); ++i)
        {
            startIndex = commands[i, 0] - 1;
            endIndex = commands[i, 1] - 1;
            valueIndex = commands[i, 2] - 1;

            var calData = data.GetRange(startIndex, endIndex - startIndex + 1);
            calData.Sort();

            answer.Add(calData[valueIndex]);
        }

        for (int i = 0; i < answer.Count; ++i)
        {
            Debug.Log(answer[i]);
        }

        return answer.ToArray();
    }

    public int solution3(int[] citations)
    {
        int answer = 0;

        for (int i = citations.Max(); i > answer; i--)
        {
            int count = citations.Count<int>(x => x >= i);

            if (count >= answer)
            {
                answer = count;
            }
        }

        return answer;
    }

    public int solution4(int[] values)
    {
        Array.Sort(values);
        return values[1];
    }

}
