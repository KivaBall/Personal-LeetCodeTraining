Console.WriteLine(new Solution().LengthOfLastWord("Hello World"));
Console.WriteLine(new Solution().LengthOfLastWord("a"));

public class Solution
{
    public int LengthOfLastWord(string s)
    {
        var idx = s.Length - 1;

        while (true)
        {
            if (s[idx] == ' ')
            {
                idx--;
            }
            else
            {
                break;
            }
        }

        var length = 0;

        while (true)
        {
            if (idx < 0 || s[idx] == ' ')
            {
                return length;
            }
            else
            {
                idx--;
                length++;
            }
        }
    }
}