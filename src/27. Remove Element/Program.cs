int[] y = [0, 1, 2, 2, 3, 0, 4, 2];
Console.WriteLine(new Solution().RemoveElement(y, 2));
Console.WriteLine("- - - - - -");
foreach (var i in y)
{
    Console.WriteLine(i);
}

public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        var putIdx = 0;
        var count = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[putIdx++] = nums[i];
                count++;
            }
        }

        return count;
    }
}