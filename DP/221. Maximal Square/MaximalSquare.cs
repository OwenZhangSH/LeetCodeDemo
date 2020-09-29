public class Solution
{
    public int MaximalSquare(char[][] matrix)
    {
        int n = matrix.Length;
        if (n == 0) return 0;
        int m = matrix[0].Length;
        if (m == 0) return 0;
        int[] dp = new int[m];
        int[] f = new int[3];
        int max = 0;
        for (int i = 0; i < n; i++)
        {
            f[0] = 0;
            f[1] = 0;
            for (int j = 0; j < m; j++)
            {
                f[2] = f[1];
                f[1] = dp[j];
                if (matrix[i][j] == '1')
                {
                    if (j == 0)
                    {
                        dp[j] = 1;
                    }
                    else
                    {

                        dp[j] = Math.Min(Math.Min(f[0], f[1]), f[2]) + 1;
                    }
                    max = Math.Max(dp[j], max);
                }
                else
                {
                    dp[j] = 0;
                }
                f[0] = dp[j];
            }
        }
        return max * max;

    }
}