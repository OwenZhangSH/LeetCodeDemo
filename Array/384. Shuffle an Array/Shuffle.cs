public class Solution
{

    int[] origin;
    int[] ret;
    int n;
    public Solution(int[] nums)
    {
        origin = (int[])nums.Clone();
        n = nums.Length;
    }

    /** Resets the array to its original configuration and return it. */
    public int[] Reset()
    {
        return origin;
    }

    /** Returns a random shuffling of the array. */
    public int[] Shuffle()
    {
        ret = (int[])origin.Clone();
        int index;
        int temp;
        Random ra = new Random();
        for (int i = n - 1; i >= 0; i--)
        {
            index = ra.Next(0, i);
            temp = ret[index];
            ret[index] = ret[i];
            ret[i] = temp;
        }
        return ret;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(nums);
 * int[] param_1 = obj.Reset();
 * int[] param_2 = obj.Shuffle();
 */
