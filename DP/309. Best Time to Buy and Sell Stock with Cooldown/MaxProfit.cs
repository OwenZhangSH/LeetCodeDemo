public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int n = prices.Length;
        if (n == 0) return 0;
        int[] temp = new int[3];
        int f0 = -prices[0];
        int f1 = 0;
        int f2 = 0;
        for (int i = 1; i < n; i++)
        {
            temp[0] = Math.Max(f0, f2 - prices[i]);
            temp[1] = f0 + prices[i];
            temp[2] = Math.Max(f1, f2);
            f0 = temp[0];
            f1 = temp[1];
            f2 = temp[2];
        }
        return Math.Max(f1, f2);

    }
}