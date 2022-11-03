using System;
using System.Linq;
public class Solution
{
    static void Main()
    {
        var numb1 = new int[] { 1, 2 };
        var numb2 = new int[] { 3, 4 };
        double median = FindMedianSortedArrays(numb1, numb2);
        Console.WriteLine("ANS " + median);
    }

    public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int[] merged = nums1.Concat(nums2).ToArray();
        double median = 0;

        Array.Sort(merged);
        Console.WriteLine(merged.Length);
        if (merged.Length % 2 == 0)
        {

            int a = merged[merged.Length / 2];
            Console.WriteLine(a);
            int b = merged[(merged.Length / 2) - 1];
            Console.WriteLine(b);
            median = (a + b) / 2.0;
            Console.WriteLine("median" + median);
        }
        else median = merged[merged.Length / 2];

        return median;
    }
}
