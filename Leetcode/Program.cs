// See https://aka.ms/new-console-template for more information

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading;
using Leetcode;
using static Leetcode.MyExtensions;

List<List<int>> comb = null;
bool[] used;

static Func<int, int> X(Func<int, int, int> f)
{
    Console.WriteLine(f.Method.Name);
    return a => f(a, 4);

}


switch (1)
{
    case 1:
        string s = "aas bab";
        string t = "abb asa";

        var sr = s.Split(" ");
        var st = t.Split(" ");


        compareWords("bored", "robed");
        bool res = true;
        for (int i = 0; i < sr.Length; i++)
        {
            res &= compareWords(sr[i], st[sr.Length - 1 - i]);
                
        }

        Console.WriteLine(res);

        //// create and initialize new ArrayList
        //ArrayList str1 = new ArrayList();
        //str1.Add('t');
        //str1.Add('e');
        //str1.Add('s');
        //str1.Add('t');
        //// create and initialize new ArrayList
        //ArrayList str2 = new ArrayList();
        //str2.Add('t');
        //str2.Add('t');
        //str2.Add('e');
        //str2.Add('s');

        //// Function call
        //if (areAnagram(str1, str2))
        //{
        //    Console.WriteLine("The two strings are"
        //                      + " anagram of each other");
        //}
        //else
        //{
        //    Console.WriteLine("The two strings are not"
        //                      + " anagram of each other");
        //}

        //uint i = 0, a;
        //Console.WriteLine("i initial value: " + i);
        //a = i++;
        //Console.WriteLine("value returned by i++: " + a + ", i after: " + i);
        //i = 0;
        //Console.WriteLine("i initial value: " + i);
        //a = ++i;
        //Console.WriteLine(" value returned by ++i: " + a + ", i after: " + i);


        //for (int j = 0; j < 5; ++j)
        //{
        //    Console.WriteLine(j);
        //}
        // callFuntion(twoSum);
        // callFuntion(twoSumOptimized);

        // ContainsDuplicate();
        // PowerSet("abc");  
        // CallLinkedList();


        // Console.WriteLine(WeekDays.Friday); //output: Friday 
        // int day = (int) WeekDays.Friday; // enum to int conversion
        // Console.WriteLine(day); //output: 4 
        //
        // var wd = (WeekDays) 5; // int to enum conversion
        // Console.WriteLine(wd);

        // int x1 = Convert.ToInt32(Console.ReadLine());
        // int y1 = Convert.ToInt32(Console.ReadLine());
        // int z1 = Convert.ToInt32(Console.ReadLine());
        // int x2 = Convert.ToInt32(Console.ReadLine());
        // int y2 = Convert.ToInt32(Console.ReadLine());
        // int z2 = Convert.ToInt32(Console.ReadLine());
        //
        // Point3D p1 = new Point3D(x1, y1, z1);
        // Point3D p2 = new Point3D(x2, y2, z2);
        // double d2 = p1.dist2D(p2);
        // double d3 = p1.dist3D(p2);
        // //The code below uses runtime polymorphism to call the overridden printDistance method:
        // Point2D p = new Point2D(0, 0);
        // p.printDistance(d2);
        // p = p1;
        // p1.printDistance(d3);


        //int[] skills =
        //{
        //    12, 4, 6, 13, 5, 10
        //};

        //var newSkills = skills.Where(x => x is >= 4 and <= 10).ToArray();
        //// int[] arr = { 10, 50, 3, 1, 2 };
        //// used = new bool[arr.Length];
        //used = new bool[newSkills.Length];

        //comb = new List<List<int>>();
        //List<int> c = new List<int>();
        //GetComb(newSkills, 0, c);
        //foreach (var item in comb)
        //{
        //    foreach (var x in item)
        //    {
        //        Console.Write(x + ",");
        //    }
        //    Console.WriteLine("");
        //}

        //Node[] nrr = new Node[10];
        //nrr[0] = new Node(1);




        break;
    case 9:
        callFuntion(IsPalindrome);
        break;
    case 13:
        callFuntion(RomanToInt);
        break;
    default:
        Console.WriteLine("default");
        break;
};

bool compareWords(string s, string t)
{

    var rs = s.OrderBy(x =>x);
    var rt = t.OrderBy(x => x);
    
    if (s == t){
        return true;
    }

    return false;
}


static bool areAnagram(ArrayList str1,
                                 ArrayList str2)
{
    // Get lengths of both strings
    int n1 = str1.Count;
    int n2 = str2.Count;

    // If length of both strings is not
    // same, then they cannot be anagram
    if (n1 != n2)
    {
        return false;
    }

    // Sort both strings
    str1.Sort();
    str2.Sort();

    // Compare sorted strings
    for (int i = 0; i < n1; i++)
    {
        if (str1[i] != str2[i])
        {
            return false;
        }
    }

    return true;
}

string reverseString(String s)
{
    var result = new StringBuilder();
    for (int i = s.Length - 1; i >= 0; i--)
    {
        result.Append(s[i]);
    }
    return result.ToString();
}



void GetComb(int[] arr, int colindex, List<int> c)
{

    if (colindex >= arr.Length)
    {
        comb.Add(new List<int>(c));
        return;
    }
    for (int i = 0; i < arr.Length; i++)
    {
        if (!used[i])
        {
            used[i] = true;
            c.Add(arr[i]);
            GetComb(arr, colindex + 1, c);
            c.RemoveAt(c.Count - 1);
            used[i] = false;
        }
    }
}

void callFuntion(Func<Object> functionToPass)
{
    var timer = new Stopwatch();
    timer.Start();
    var res = functionToPass();
    // Thread.Sleep(500);
    timer.Stop();
    Console.WriteLine("Time taken: " + timer.ElapsedMilliseconds);
}

int[] twoSum()
{
    int[] nums = { 2, 7, 11, 15 };

    int target = 9;
    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = 0; j < nums.Length; j++)
        {
            if (target == nums[i] + nums[j])
            {
                Console.WriteLine(nums[i] + "   " + nums[j]);
                return new int[2] { i, j };
            }
        }
    }

    return null;
}

static int[] twoSumOptimized()
{
    int[] nums = { 12, 2, 17, 11, 15, 7 };

    int target = 9;
    int[] result = new int[2];

    var dict = new Dictionary<int, int>();
    for (int i = 0; i < nums.Length; i++)
    {
        if (dict.ContainsKey(target - nums[i]))
        {
            result[0] = i;
            if (dict.TryGetValue(target - nums[i], out int index))
            {
                result[1] = index;
            }

            return result;
        }

        dict[nums[i]] = i;
    }


    return result;
}

object IsPalindrome()
{
    int x = 12121;

    if (x < 0)
    {
        return false;
    }

    if (x < 10)
    {
        return true;
    }

    var temp = x;
    var y = 0;
    var digit = 0;
    while (temp != 0)
    {
        digit = temp % 10;
        y = y * 10 + digit;
        temp /= 10;
    }

    Console.WriteLine(x == y);
    return x == y;
}

object RomanToInt()
{
    string s = "XXIV";

    var result = 0;
    for (int i = 0; i < s.Length; i++)
    {
        if (i > 0 && mapToInt(s[i]) > mapToInt(s[i - 1]))
        {
            result += mapToInt(s[i]) - mapToInt(s[i - 1]) * 2;
        }
        else
        {
            result += mapToInt(s[i]);
        }
    }

    Console.WriteLine(result);
    return result;
}


int mapToInt(char letter)
{
    switch (letter.ToString().ToUpper()[0])
    {
        case 'I': return 1;
        case 'V': return 5;
        case 'X': return 10;
        case 'L': return 50;
        case 'C': return 100;
        case 'D': return 500;
        case 'M': return 1000;
        default: return 0;
    }
}

int maxProfit()
{
    int[] prices = { 7, 8, 5, 7, 6, 4 };

    int minprice = int.MaxValue;
    int maxprice = 0;

    for (int i = 0; i < prices.Length; i++)
    {
        if (prices[i] < minprice)
        {
            minprice = prices[i];
        }

        if (prices[i] - minprice > maxprice)
        {
            maxprice = prices[i] - minprice;
        }
    }

    return maxprice;
}

bool ContainsDuplicate()
{
    int[] arr = { 1, 2, 3, 1, 5 };
    var set = new HashSet<int>();
    foreach (var val in arr)
    {
        if (!set.Add(val))
        {
            return true;
        }
    }

    return false;
}

List<string> PowerSet(string input)
{
    int n = input.Length;
    // Power set contains 2^N subsets.
    int powerSetCount = 1 << n;
    var ans = new List<string>();

    for (int setMask = 0; setMask < powerSetCount; setMask++)
    {
        var s = new StringBuilder();
        for (int i = 0; i < n; i++)
        {
            // Checking whether i'th element of input collection should go to the current subset.
            if ((setMask & (1 << i)) > 0)
            {
                s.Append(input[i]);
            }
        }

        ans.Add(s.ToString());
    }

    return ans;
}

void CallLinkedList()
{
    var obj = new LinkedList();
    obj.InsertAtFirst(2);
    obj.InsertAtFirst(1);
    obj.InsertAtLast(3);
    obj.InsertAtIndex(2, 4);
    // obj.RemoveAtIndex(1);
    // obj.ClearAll();
    obj.PrintAllNodes();
    Console.WriteLine("done");
}