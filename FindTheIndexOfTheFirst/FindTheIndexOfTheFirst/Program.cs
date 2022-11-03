using System;
using System.Linq;
public class Solution
{
    static void Main()
    {
        string haystack = "sadbutsad";
        string needle = "sad";


        int x = StrStr(haystack, needle);

        Console.WriteLine(x);

    }

    public static int StrStr(string haystack, string needle)
    {
        int Ne_Size = needle.Length;
        int b = 0;
        int aa = 0;

        int index = 0;

        if (haystack.Contains(needle))
        {

            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[0])
                {

                    b = i;
                    for (int j = 0; j < Ne_Size; j++)
                    {
                        if (haystack[b] != needle[j])
                        {
                            aa = 0;
                            break;
                        }
                        if (haystack[b] == needle[j])
                        {
                            b++;
                        }

                        aa = 1;
                    }

                }
                if (aa == 1)
                {
                    index = (b - Ne_Size);
                    return index;
                }

            }
            return index;
        }
        else return -1;

    }
}
