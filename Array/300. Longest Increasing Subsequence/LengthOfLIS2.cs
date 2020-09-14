public class Solution
{
    public int LengthOfLIS(int[] nums)
    {
        int len = 1;
        int size = nums.Length;
        if (size == 0) return 0;
        int[] minLength = new int[size + 1];
        minLength[len] = nums[0];
        for (int i = 1; i < size; ++i)
        {
            if (nums[i] > minLength[len]) minLength[++len] = nums[i];
            else
            {
                int l = 1, r = len, pos = 0;
                while (l <= r)
                {
                    int mid = (l + r) >> 1;
                    if (minLength[mid] < nums[i])
                    {
                        pos = mid;
                        l = mid + 1;
                    }
                    else r = mid - 1;
                }
                minLength[pos + 1] = nums[i];
            }
        }
        return len;
    }
}