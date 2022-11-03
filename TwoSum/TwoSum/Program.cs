using System;
using System.Linq;
public class Solution
{
    static void Main()
    {
        var numbers = new int[] { 2, 7, 11, 15 };
        var tar = 9;
        int[] SUM = TwoSum(numbers, tar);
    }
    public static int[] TwoSum(int[] nums, int target)
    {
        var sum = new int[2] { 0, 0 };
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    Console.WriteLine("nums[{0},{1}]", i, j);
                    sum = new int[2];
                    sum[0] = i;
                    sum[1] = j;
                    return sum;

                }

            }

        }
        return sum;
    }
}