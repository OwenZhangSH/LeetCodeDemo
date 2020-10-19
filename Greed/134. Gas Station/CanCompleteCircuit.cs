public class Solution
{
    public int CanCompleteCircuit(int[] gas, int[] cost)
    {
        int currentGas = 0;
        int totalGas = 0;
        int n = gas.Length;
        int start = 0;
        for (int i = 0; i < n; i++)
        {
            totalGas += gas[i] - cost[i];
            currentGas += gas[i] - cost[i];
            if (currentGas < 0)
            {
                currentGas = 0;
                start = i + 1;
            }
        }
        if (totalGas >= 0)
        {
            return start;
        }
        return -1;
    }
}