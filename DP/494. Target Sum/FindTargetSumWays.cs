public class Solution
{
    public int FindTargetSumWays(int[] nums, int S)
    {
        int size = nums.Length;
        int total = 0;
        for (int i = 0; i < size; i++)
        {
            total += nums[i];
        }
        if (S > total) return 0;
        int target = S + total;
        int[] dp = new int[S + total + 1];
        dp[0] = 1;
        for (int i = 0; i < size; i++)
        {
            for (int j = S + total; j >= 0; j--)
            {
                if (j - 2 * nums[i] >= 0)
                {
                    dp[j] = dp[j] + dp[j - 2 * nums[i]];
                }
            }
        }
        return dp[S + total];
    }
}