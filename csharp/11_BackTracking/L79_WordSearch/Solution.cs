using System.Data;

namespace _11_BackTracking.WordSearch;

public class Solution
{
    public int Iterations = 0;

    // time complexity:
    // O( r * c * 4^len(word) )
    public bool Exist(char[][] board, string word)
    {
        var nrRows = board.Length;
        var nrCols = board[0].Length;
        var path = new HashSet<(int, int)>();

        bool dfs(int r, int c, int wordIndex)
        {
            if (wordIndex == word.Length) return true;
            if (r < 0 || c < 0 || r >= nrRows || r >= nrCols // out of bounds
                || word[wordIndex] != board[r][c] // char does not match
                || path.Contains((r, c))) // cell already visited
            {
                Iterations += 1;
                return false;
            }

            path.Add((r, c));
            ++wordIndex;
            var result = dfs(r + 1, c, wordIndex)
                         || dfs(r - 1, c, wordIndex)
                         || dfs(r, c + 1, wordIndex)
                         || dfs(r, c - 1, wordIndex);
            path.Remove((r, c));

            return result;
        }

        for (int row = 0; row < nrRows; row++)
        {
            for (int col = 0; col < nrCols; col++)
            {
                if (dfs(row, col, 0))
                    return true;
            }
        }

        return false;
    }
}