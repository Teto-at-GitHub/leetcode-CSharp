namespace Graphs.Main.NumberOfIslands
{
    public class Solution
    {
        public int NumIslands(char[][] grid)
        {
            if (grid is null)
                return 0;

            var nrRows = grid.Length;
            var nrCols = grid[0].Length;

            int nrIsland = 0;
            HashSet<(int, int)> visited = new();

            for (int r = 0; r <= nrRows; r++)
            {
                for (int c = 0; c <= nrCols; c++)
                {
                    if (grid[r][c] == '1' && !visited.Contains((r, c)))
                    {
                        bfs(r, c);
                        ++nrIsland;
                    }
                }
            }

            void bfs(int r, int c)
            {
                // TODO

                //     var q = new Queue<(int,int)>();
                //     visited.Add((r, c));
                //     q.Enqueue((r, c));
                //
                //     while (q.Count > 0)
                //     {
                //         r,c = q.;
                //     }
            }


            return 0;
        }
    }
}