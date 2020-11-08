public class Solution
{
    public int MaxTurbulenceSize(int[] A)
    {
        int n = A.Length;
        if (n < 2) return n;
        if (n == 2 && A[0] != A[1]) return 2;
        int[] maxEnd = new int[n + 1];
        maxEnd[1] = 1;
        maxEnd[2] = (A[0] != A[1]) ? 2 : 1;
        int max = maxEnd[2];
        for (int i = 3; i <= n; i++)
        {
            if (A[i - 1] > A[i - 2] && A[i - 3] > A[i - 2])
            {
                maxEnd[i] = 1 + maxEnd[i - 1];
            }
            else if (A[i - 1] < A[i - 2] && A[i - 3] < A[i - 2])
            {
                maxEnd[i] = 1 + maxEnd[i - 1];
            }
            else if (A[i - 1] != A[i - 2])
            {
                maxEnd[i] = 2;
            }
            else
            {
                maxEnd[i] = 1;
            }
            max = Math.Max(maxEnd[i], max);
        }
        return max;
    }
}