public class Solution
{
    public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int K)
    {
        int max = 10000 * (K + 1) + 1;
        // 假设dp为src 到n点的最少消费
        int[] dp = new int[n];
        for (int i = 0; i < n; i++)
        {
            dp[i] = max;
        }
        dp[src] = 0;
        for (int i = 0; i <= K; i++)
        {
            int[] dp1 = (int[])dp.Clone();
            foreach (int[] e in flights)
            {
                dp1[e[1]] = Math.Min(dp1[e[1]], dp[e[0]] + e[2]);
            }
            dp = dp1;
        }
        return dp[dst] == max ? -1 : dp[dst];
    }
}