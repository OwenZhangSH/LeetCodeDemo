public class Solution
{
    public int SubarraySum(int[] nums, int k)
    {
        int size = nums.Length;
        Dictionary<int, int> kCount = new Dictionary<int, int>();
        int total = 0;
        int count = 0;
        kCount[0] = 1;
        for (int i = 0; i < size; i++)
        {
            total += nums[i];
            if (kCount.ContainsKey(total - k))
            {
                count += kCount[total - k];
            }
            if (kCount.ContainsKey(total))
            {
                kCount[total] += 1;
            }
            else
            {
                kCount[total] = 1;
            }

        }
        return count;
    }
}