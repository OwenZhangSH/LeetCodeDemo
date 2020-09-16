public class Solution
{
    int size;
    public bool CanPartition(int[] nums)
    {
        size = nums.Length;
        if (size <= 1) return false;
        int total = 0;
        for (int i = 0; i < size; i++)
        {
            total += nums[i];
        }
        if (total % 2 != 0) return false;
        total >>= 1;

        bool[] dp = new bool[total + 1];
        dp[0] = true;
        for (int i = 1; i < size; i++)
        {
            for (int j = total; j > 0; j--)
            {
                if (j - nums[i] >= 0)
                    dp[j] = dp[j] | dp[j - nums[i]];
            }
            if (dp[total])
                return true;
        }
        return false;
    }
}