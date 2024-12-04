Console.WriteLine(new Solution().StrStr("sadbutsad", "sad"));
Console.WriteLine(new Solution().StrStr("aaa", "aaaa"));

public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        for (var i = 0; i < haystack.Length; i++)
        {
            if (haystack[i] == needle[0])
            {
                var ths = true;

                for (var j = 1; j < needle.Length; j++)
                {
                    if (i + j > haystack.Length - 1 || haystack[i + j] != needle[j])
                    {
                        ths = false;
                        break;
                    }
                }

                if (ths)
                {
                    return i;
                }
            }
        }

        return -1;
    }
}