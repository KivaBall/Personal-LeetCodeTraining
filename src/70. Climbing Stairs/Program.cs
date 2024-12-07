Console.WriteLine(new Solution().ClimbStairs(1));
Console.WriteLine(new Solution().ClimbStairs(2));
Console.WriteLine(new Solution().ClimbStairs(3));
Console.WriteLine(new Solution().ClimbStairs(4));
Console.WriteLine(new Solution().ClimbStairs(5));
Console.WriteLine(new Solution().ClimbStairs(6));
Console.WriteLine(new Solution().ClimbStairs(7));
Console.WriteLine(new Solution().ClimbStairs(8));
Console.WriteLine(new Solution().ClimbStairs(9));
Console.WriteLine(new Solution().ClimbStairs(10));
Console.WriteLine(new Solution().ClimbStairs(45));

public class Solution
{
    public int ClimbStairs(int n)
    {
        var fibCache = new int[n + 2];

        int Fibonacci(int num)
        {
            if (num <= 1)
            {
                fibCache[num] = num;
                return num;
            }

            var frst = fibCache[num - 1] != 0
                ? fibCache[num - 1]
                : Fibonacci(num - 1);

            var scnd = fibCache[num - 2] != 0
                ? fibCache[num - 2]
                : Fibonacci(num - 2);

            fibCache[num] = frst + scnd;

            return fibCache[num];
        }

        return Fibonacci(n + 1);
    }
}