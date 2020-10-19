public class Solution
{
    public void GameOfLife(int[][] board)
    {
        int m = board.Length;
        if (m == 0) return;
        int n = board[0].Length;
        if (n == 0) return;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int liveNum = 0;
                if (i != 0)
                {
                    liveNum += board[i - 1][j] % 2;
                }
                if (j != 0)
                {
                    liveNum += board[i][j - 1] % 2;
                }
                if (i != 0 && j != 0)
                {
                    liveNum += board[i - 1][j - 1] % 2;
                }
                if (i != m - 1)
                {
                    liveNum += board[i + 1][j] % 2;
                }
                if (j != n - 1)
                {
                    liveNum += board[i][j + 1] % 2;
                }
                if (i != m - 1 && j != n - 1)
                {
                    liveNum += board[i + 1][j + 1] % 2;
                }
                if (i != m - 1 && j != 0)
                {
                    liveNum += board[i + 1][j - 1] % 2;
                }
                if (i != 0 && j != n - 1)
                {
                    liveNum += board[i - 1][j + 1] % 2;
                }
                if (board[i][j] == 0 && liveNum == 3)
                {
                    board[i][j] = 2;
                }
                else if (board[i][j] == 1 && (liveNum < 2 || liveNum > 3))
                {
                    board[i][j] = 3;
                }
            }
        }
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                board[i][j] = board[i][j] > 1 ? 1 - (board[i][j] % 2) : board[i][j];
            }
        }
        return;
    }
}