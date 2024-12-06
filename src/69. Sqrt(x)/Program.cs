Console.WriteLine(new Solution().MySqrt(4));
Console.WriteLine(new Solution().MySqrt(8));
Console.WriteLine(new Solution().MySqrt(15));
Console.WriteLine(new Solution().MySqrt(2147395599));

public class Solution
{
    public int MySqrt(int x)
    {
        if (x == 1)
        {
            return 1;
        }

        uint minVal = 0;
        var maxVal = (uint)(x > 65535 ? 65535 : x);

        while (true)
        {
            var middle = (maxVal + minVal) / 2;

            if (middle * middle <= x && (middle + 1) * (middle + 1) > x)
            {
                return (int)middle;
            }
            else if (middle * middle < x)
            {
                minVal = middle;
            }
            else
            {
                maxVal = middle;
            }
        }
    }
}