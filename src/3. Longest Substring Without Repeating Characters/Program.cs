Console.WriteLine(new Solution().LengthOfLongestSubstring(
    "aabb"));

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        var maxLength = 0;

        var span = new Span<char>(s.ToCharArray(), 0, s.Length);

        var usedChar = new Dictionary<char, int>(s.Length);

        var currentLength = 0;

        for (var i = 0; i < span.Length; i++)
        {
            if (usedChar.ContainsKey(span[i]))
            {
                var j = usedChar[span[i]];

                usedChar[span[i]] = i;

                while (usedChar.Values.Contains(--j))
                {
                    usedChar.Remove(span[j]);
                    currentLength--;
                }
            }
            else
            {
                usedChar[span[i]] = i;
                currentLength++;
            }

            if (maxLength < currentLength)
            {
                maxLength = currentLength;
            }
        }

        return maxLength;
    }
}