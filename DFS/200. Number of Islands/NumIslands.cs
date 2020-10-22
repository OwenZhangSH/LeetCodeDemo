public class Solution
{
    public int NumIslands(char[][] grid)
    {
        int m = grid.Length;
        int n = grid[0].Length;
        int count = 0;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (grid[i][j] == '1')
                {
                    DFS(grid, i, j);
                    count++;
                }
            }
        }
        return count;
    }

    public void DFS(char[][] grid, int x, int y)
    {
        int m = grid.Length;
        int n = grid[0].Length;

        grid[x][y] = '0';
        if (x - 1 >= 0 && grid[x - 1][y] == '1') DFS(grid, x - 1, y);
        if (x + 1 < m && grid[x + 1][y] == '1') DFS(grid, x + 1, y);
        if (y - 1 >= 0 && grid[x][y - 1] == '1') DFS(grid, x, y - 1);
        if (y + 1 < n && grid[x][y + 1] == '1') DFS(grid, x, y + 1);
    }
}