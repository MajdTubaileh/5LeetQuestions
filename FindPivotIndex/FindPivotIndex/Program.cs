using System;
using System.Linq;
public class Solution
{
    static void Main()
    {
        var nums = new int[] { 1, 7, 3, 6, 5, 6 };




        Console.WriteLine(PivotIndex(nums));

    }

    public static int PivotIndex(int[] nums)
    {
        int sum = 0;
        for (int i = 0; i < nums.Length; i++)
            sum += nums[i];
        int left = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (left == sum - nums[i] - left)
                return i;
            left += nums[i];
        }
        return -1;

    }
}
