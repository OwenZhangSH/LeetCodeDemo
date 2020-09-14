public class Solution
{
    public int LengthOfLIS(int[] nums)
    {
        int max = 0;
        int size = nums.Length;
        int[] currentMax = new int[size];
        int current = 0;
        if (size == 0)
        {
            return max;
        }
        max = 1;
        currentMax[size - 1] = 1;
        for (int i = size - 2; i >= 0; i--)
        {
            currentMax[i] = 1;
            for (int j = i + 1; j < size; j++)
            {
                if (nums[i] < nums[j])
                {
                    currentMax[i] = currentMax[i] > (currentMax[j] + 1) ? currentMax[i] : (currentMax[j] + 1);
                }
            }
            max = max > currentMax[i] ? max : currentMax[i];
        }
        return max;
    }
}