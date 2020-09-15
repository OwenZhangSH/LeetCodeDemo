public class Solution
{
    public int[] MaxSlidingWindow(int[] nums, int k)
    {
        int size = nums.Length;
        int returnLength = size - k + 1;
        int[] result = new int[returnLength];

        int[] left = new int[size];
        int[] right = new int[size];

        for (int i = 0; i < size; i++)
        {
            if (i % k == 0) left[i] = nums[i];
            else left[i] = nums[i] > left[i - 1] ? nums[i] : left[i - 1];
        }

        for (int i = size - 1; i > -1; i--)
        {
            if ((i + 1) % k == 0 || i == size - 1) right[i] = nums[i];
            else right[i] = nums[i] > right[i + 1] ? nums[i] : right[i + 1];
        }

        for (int i = 0; i < size - k + 1; i++)
        {
            result[i] = left[i + k - 1] > right[i] ? left[i + k - 1] : right[i];
        }
        return result;
    }
}