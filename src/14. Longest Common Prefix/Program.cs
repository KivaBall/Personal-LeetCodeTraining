var str = new Solution().LongestCommonPrefix(["flower", "flot", "flight"]);
var str2 = new Solution().LongestCommonPrefix(["dog", "racecar", "car"]);
Console.WriteLine(str);
Console.WriteLine(str2);

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        byte idx = 0;

        var maxIdx = byte.MaxValue;

        for (byte i = 0; i < strs.Length; i++)
        {
            if (strs[i].Length < maxIdx)
            {
                maxIdx = (byte)strs[i].Length;
            }
        }

        if (maxIdx == 0)
        {
            return string.Empty;
        }

        while (true)
        {
            for (byte index = 0; index < strs.Length; index++)
            {
                if (strs[index][idx] != strs[0][idx])
                {
                    return strs[0].AsSpan(0, idx).ToString();
                }
            }

            if (++idx == maxIdx)
            {
                break;
            }
        }

        return strs[0].AsSpan(0, idx).ToString();
    }
}