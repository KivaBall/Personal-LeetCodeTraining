Console.WriteLine(new Solution().IsValid("()"));
Console.WriteLine(new Solution().IsValid("()[]{}"));
Console.WriteLine(new Solution().IsValid("(]"));
Console.WriteLine(new Solution().IsValid("([])"));
Console.WriteLine(new Solution().IsValid("(){}}{"));
Console.WriteLine(new Solution().IsValid("({[)"));
Console.WriteLine(new Solution().IsValid("(])"));


public class Solution
{
    public bool IsValid(string s)
    {
        // 00 - X
        // 01 - [
        // 10 - {
        // 11 - (

        var braceTemp = new bool[s.Length * 2];
        var idx = 2;

        if (s[0] == '(')
        {
            braceTemp[0] = true;
            braceTemp[1] = true;
        }
        else if (s[0] == '[')
        {
            braceTemp[0] = false;
            braceTemp[1] = true;
        }
        else if (s[0] == '{')
        {
            braceTemp[0] = true;
            braceTemp[1] = false;
        }
        else
        {
            return false;
        }

        for (var i = 1; i < s.Length; i++)
        {
            if (s[i] == '(' || s[i] == '[' || s[i] == '{')
            {
                if (s[i] == '(')
                {
                    braceTemp[idx] = true;
                    braceTemp[idx + 1] = true;
                    idx += 2;
                }
                else if (s[i] == '[')
                {
                    braceTemp[idx] = false;
                    braceTemp[idx + 1] = true;
                    idx += 2;
                }
                else if (s[i] == '{')
                {
                    braceTemp[idx] = true;
                    braceTemp[idx + 1] = false;
                    idx += 2;
                }
            }
            else if (idx != 0)
            {
                if (s[i] == ')' && braceTemp[idx - 2] == true && braceTemp[idx - 1] == true)
                {
                    braceTemp[idx - 2] = false;
                    braceTemp[idx - 1] = false;
                    idx -= 2;
                }
                else if (s[i] == ']' && braceTemp[idx - 2] == false && braceTemp[idx - 1] == true)
                {
                    braceTemp[idx - 2] = false;
                    braceTemp[idx - 1] = false;
                    idx -= 2;
                }
                else if (s[i] == '}' && braceTemp[idx - 2] == true && braceTemp[idx - 1] == false)
                {
                    braceTemp[idx - 2] = false;
                    braceTemp[idx - 1] = false;
                    idx -= 2;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        return braceTemp[0] == false && braceTemp[1] == false;
    }
}