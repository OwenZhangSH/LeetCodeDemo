public class Solution
{
    public int CoinChange(int[] coins, int amount)
    {
        int n = coins.Length;
        int[] dp = new int[amount + 1];
        for (int i = 1; i <= amount; i++)
        {
            dp[i] = -1;
        }
        for (int i = 0; i < amount + 1; i++)
        {
            int min = -1;
            for (int j = 0; j < n; j++)
            {
                if (i - coins[j] >= 0 && dp[i - coins[j]] != -1)
                {
                    if (min == -1) min = dp[i - coins[j]];
                    else
                        min = min < dp[i - coins[j]] ? min : dp[i - coins[j]];
                    dp[i] = min + 1;
                }
            }
        }
        if (amount == 0) return 0;
        return dp[amount];
    }
}