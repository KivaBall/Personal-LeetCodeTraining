int[] nums1 = [1, 2, 3, 0, 0, 0];
int[] nums2 = [2, 5, 6];

new Solution().Merge(nums1, 3, nums2, 3);

foreach (var i in nums1)
{
    Console.WriteLine(i);
}

int[] nums3 = [0];
int[] nums4 = [1];

new Solution().Merge(nums3, 0, nums4, 1);

foreach (var i in nums3)
{
    Console.WriteLine(i);
}

public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        var mergedList = new int[m + n];
        byte idx = 0;

        byte idx1 = 0;
        byte idx2 = 0;

        while (true)
        {
            if (idx1 >= m)
            {
                while (idx2 < n)
                {
                    mergedList[idx++] = nums2[idx2++];
                }

                break;
            }

            if (idx2 >= n)
            {
                while (idx1 < m)
                {
                    mergedList[idx++] = nums1[idx1++];
                }

                break;
            }

            if (nums1[idx1] <= nums2[idx2])
            {
                mergedList[idx++] = nums1[idx1++];
            }
            else
            {
                mergedList[idx++] = nums2[idx2++];
            }
        }

        for (byte i = 0; i < mergedList.Length; i++)
        {
            nums1[i] = mergedList[i];
        }
    }
}