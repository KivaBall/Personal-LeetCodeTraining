foreach (var num in new Solution().PlusOne([9, 9, 9, 9]))
{
    Console.WriteLine(num);
}

public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        static int[] Add(int[] digits, int neededIdx)
        {
            if (neededIdx == -1)
            {
                var newDigits = new int[digits.Length + 1];

                newDigits[0] = 1;

                return newDigits;
            }
            else if (digits[neededIdx] != 9)
            {
                digits[neededIdx]++;
            }
            else
            {
                digits[neededIdx] = 0;
                return Add(digits, neededIdx - 1);
            }

            return digits;
        }

        return Add(digits, digits.Length - 1);
    }
}