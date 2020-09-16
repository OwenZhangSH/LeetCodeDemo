public class Solution
{
    int size;
    public bool CanPartition(int[] nums)
    {
        size = nums.Length;
        int total = 0;
        for (int i = 0; i < size; i++)
        {
            total += nums[i];
        }
        if (total % 2 != 0) return false;
        Array.Sort(nums);
        Array.Reverse(nums);
        total >>= 1;
        if (nums[0] > total) return false;
        return DFS(nums, 0, total);
    }

    public bool DFS(int[] nums, int index, int target)
    {
        if (index >= size) return false;
        if (nums[index] == target) return true;
        if (nums[index] > target) return DFS(nums, index + 1, target);
        return DFS(nums, index + 1, target) || DFS(nums, index + 1, target - nums[index]);
    }
}