public class Solution
{
    public int MaxCoins(int[] nums)
    {
        int size = nums.Length;
        int[,] dp = new int[size + 2, size + 2];
        int[] newNums = new int[size + 2];
        newNums[0] = newNums[size + 1] = 1;
        for (int i = 1; i < size + 1; i++)
        {
            newNums[i] = nums[i - 1];
        }
        for (int i = size - 1; i >= 0; i--)
        {
            for (int j = i + 2; j <= size + 1; j++)
            {
                for (int k = i + 1; k < j; k++)
                {
                    int sum = newNums[k] * newNums[i] * newNums[j];
                    sum += dp[i, k] + dp[k, j];
                    dp[i, j] = dp[i, j] > sum ? dp[i, j] : sum;
                }
            }
        }
        return dp[0, size + 1];
    }
}