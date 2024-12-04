int[] y = [1, 1, 2, 2, 2, 2, 3, 4, 5, 5, 5, 6, 6, 7];
Console.WriteLine(new Solution().RemoveDuplicates(y));
Console.WriteLine("- - - - - -");
foreach (var i in y)
{
    Console.WriteLine(i);
}

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        var currentNum = -101;
        var putIdx = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] > currentNum)
            {
                currentNum = nums[i];
                nums[putIdx++] = currentNum;
            }
        }

        return putIdx;
    }
}