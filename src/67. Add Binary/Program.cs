public class Solution
{
    public string AddBinary(string a, string b)
    {
        Span<char> aSpan;
        Span<char> bSpan;

        if (a.Length < b.Length)
        {
            var str = new string('0', b.Length - a.Length) + a;
            aSpan = new Span<char>(str.ToCharArray());
            bSpan = new Span<char>(b.ToCharArray());
        }
        else
        {
            var str = new string('0', a.Length - b.Length) + b;
            aSpan = new Span<char>(a.ToCharArray());
            bSpan = new Span<char>(str.ToCharArray());
        }

        var isUpperDig = false;

        for (var i = aSpan.Length - 1; i >= 0; i--)
        {
            if (isUpperDig)
            {
                if (bSpan[i] == '0')
                {
                    if (aSpan[i] == '0')
                    {
                        aSpan[i] = '1';
                        isUpperDig = false;
                    }
                    else if (aSpan[i] == '1')
                    {
                        aSpan[i] = '0';
                    }
                }
            }
            else
            {
                if (bSpan[i] == '1')
                {
                    if (aSpan[i] == '1')
                    {
                        aSpan[i] = '0';
                        isUpperDig = true;
                    }
                    else if (aSpan[i] == '0')
                    {
                        aSpan[i] = '1';
                    }
                }
            }
        }

        return isUpperDig ? '1' + aSpan.ToString() : aSpan.ToString();
    }
}