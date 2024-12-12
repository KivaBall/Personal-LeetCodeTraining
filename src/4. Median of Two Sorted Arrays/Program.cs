Console.WriteLine(new Solution().FindMedianSortedArrays(new int[] { 1, 3, 5, 7, 9 }, new int[] { 2, 4, 6, 8, 10 }));
Console.WriteLine(
    new Solution().FindMedianSortedArrays(new int[] { -10, -5, 0, 5, 10 }, new int[] { -6, -4, 3, 6, 8, 11 }));
Console.WriteLine(new Solution().FindMedianSortedArrays(new int[] { }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));
Console.WriteLine(new Solution().FindMedianSortedArrays(new int[] { -100, -50, 0 }, new int[] { 1, 50, 100, 150 }));
Console.WriteLine(new Solution().FindMedianSortedArrays(new int[] { -106, -105, -104 }, new int[] { 104, 105, 106 }));

Console.WriteLine(new Solution().FindMedianSortedArrays(new int[] { 1, 2 }, new int[] { 3, 4, 5, 6, 7, 8, 9, 10 }));
Console.WriteLine(new Solution().FindMedianSortedArrays(new int[] { -3, -2, -1, 0, 1 }, new int[] { 2 }));
Console.WriteLine(new Solution().FindMedianSortedArrays(new int[] { 1000 }, new int[] { -1000, -999, -998, -997 }));

Console.WriteLine(new Solution().FindMedianSortedArrays(
    Enumerable.Range(-1000, 1000).ToArray(),
    Enumerable.Range(1001, 999).ToArray()
));

Console.WriteLine(new Solution().FindMedianSortedArrays(
    Enumerable.Repeat(-106, 1000).ToArray(),
    Enumerable.Repeat(106, 1000).ToArray()
));

public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        var firstLength = nums1.Length;
        var secondLength = nums2.Length;

        var firstIdx = 0;
        var secondIdx = 0;

        var unitedArr = new int[firstLength + secondLength];

        while (true)
        {
            if (firstIdx < firstLength && secondIdx < secondLength)
            {
                if (nums1[firstIdx] <= nums2[secondIdx])
                {
                    unitedArr[firstIdx + secondIdx] = nums1[firstIdx];
                    firstIdx++;
                }
                else
                {
                    unitedArr[firstIdx + secondIdx] = nums2[secondIdx];
                    secondIdx++;
                }
            }
            else if (firstIdx >= firstLength && secondIdx < secondLength)
            {
                while (secondIdx < secondLength)
                {
                    unitedArr[firstIdx + secondIdx] = nums2[secondIdx];
                    secondIdx++;
                }
            }
            else if (firstIdx < firstLength && secondIdx >= secondLength)
            {
                while (firstIdx < firstLength)
                {
                    unitedArr[firstIdx + secondIdx] = nums1[firstIdx];
                    firstIdx++;
                }
            }
            else
            {
                break;
            }
        }

        return unitedArr.Length % 2 == 0
            ? ((double)unitedArr[(unitedArr.Length - 1) / 2] + (double)unitedArr[unitedArr.Length / 2]) / 2
            : unitedArr[(unitedArr.Length - 1) / 2];
    }
}