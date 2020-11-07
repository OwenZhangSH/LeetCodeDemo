public class Solution
{
    public int FindMaxForm(string[] strs, int m, int n)
    {
        int l = strs.Length;
        int[,] dp = new int[m + 1, n + 1];
        for (int i = 0; i < l; i++)
        {
            int count0 = 0;
            int count1 = 0;
            for (int x = 0; x < strs[i].Length; x++)
            {
                if (strs[i][x] == '0') count0++;
                else count1++;
            }
            for (int x = m; x >= count0; x--)
            {
                for (int y = n; y >= count1; y--)
                {
                    dp[x, y] = Math.Max(dp[x, y], 1 + dp[x - count0, y - count1]);
                }
            }
        }
        return dp[m, n];

    }
}