public class Solution
{
    public int EvalRPN(string[] tokens)
    {
        int n = tokens.Length;
        if (n == 0) return 0;
        int[] nums = new int[n];
        int top = 0;
        for (int i = 0; i < n; i++)
        {
            if (tokens[i] == "+")
            {
                nums[top - 2] = nums[top - 2] + nums[top - 1];
                top--;
            }
            else if (tokens[i] == "-")
            {
                nums[top - 2] = nums[top - 2] - nums[top - 1];
                top--;
            }
            else if (tokens[i] == "*")
            {
                nums[top - 2] = nums[top - 2] * nums[top - 1];
                top--;
            }
            else if (tokens[i] == "/")
            {
                nums[top - 2] = nums[top - 2] / nums[top - 1];
                top--;
            }
            else
            {
                nums[top] = int.Parse(tokens[i]);
                top++;
            }
        }
        return nums[0];
    }
}