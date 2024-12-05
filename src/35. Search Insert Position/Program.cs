Console.WriteLine(new Solution().SearchInsert([1, 3, 5, 6], 4));
Console.WriteLine(new Solution().SearchInsert([1, 3, 5, 6], 2));
Console.WriteLine(new Solution().SearchInsert([1, 3], 4));
Console.WriteLine(new Solution().SearchInsert([1], 0));
Console.WriteLine(new Solution().SearchInsert([3, 4, 5, 6, 7, 8], 6));

public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        var minIdx = 0;
        var maxIdx = nums.Length - 1;

        while (true)
        {
            if (maxIdx - minIdx == 1)
            {
                if (nums[minIdx] >= target)
                {
                    return minIdx;
                }
                else if (nums[minIdx] < target && nums[maxIdx] >= target)
                {
                    return maxIdx;
                }
                else
                {
                    return maxIdx + 1;
                }
            }
            else if (maxIdx - minIdx == 0)
            {
                if (nums[minIdx] >= target)
                {
                    return minIdx;
                }
                else
                {
                    return minIdx + 1;
                }
            }

            var centralIdx = (maxIdx + minIdx) / 2;

            if (nums[centralIdx] == target)
            {
                return centralIdx;
            }
            else if (nums[centralIdx] < target)
            {
                minIdx = centralIdx + 1;
            }
            else
            {
                maxIdx = centralIdx;
            }
        }
    }
}