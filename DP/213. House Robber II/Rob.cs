public class Solution
{
    public int Rob(int[] nums)
    {
        int n = nums.Length;
        if (n == 0) return 0;
        if (n == 1) return nums[0];
        if (n == 2) return Math.Max(nums[0], nums[1]);
        return Math.Max(RobV1(nums.Skip(1).ToArray()), RobV1(nums.Take(n - 1).ToArray()));
    }

    public int RobV1(int[] nums)
    {
        int n = nums.Length;
        if (n == 0) return 0;
        if (n == 1) return nums[0];
        if (n == 2) return Math.Max(nums[0], nums[1]);
        int[] dp = new int[n];
        dp[0] = nums[0];
        dp[1] = Math.Max(nums[0], nums[1]);
        for (int i = 2; i < n; i++)
        {
            dp[i] = Math.Max(dp[i - 2] + nums[i], dp[i - 1]);
        }
        return dp[n - 1];
    }
}