using System.Net.Http.Headers;

namespace Graphs.Main.NumberOfIslands
{
    public struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    // Time complexity: O(r*c)
    // - bc of the nested for loops
    // - while on the queue doesn't scale, depends only on how many 1s and 0s and their disposition 
    public class Solution
    {
        private readonly Dictionary<char, Point> _gridMovementVectors = new()
        {
            { 'R', new Point(0, 1) },
            { 'L', new Point(0, -1) },
            { 'D', new Point(1, 0) },
            { 'U', new Point(-1, 0) }
        };

        public int NumIslands(char[][] grid)
        {
            if (grid is null)
                return 0;

            var nrRows = grid.Length;
            var nrCols = grid[0].Length;

            int nrIsland = 0;
            HashSet<Point> visited = new();

            for (int r = 0; r < nrRows; r++)
            {
                for (int c = 0; c < nrCols; c++)
                {
                    var point = new Point(r, c);
                    if (grid[r][c] == '1' && !visited.Contains(point))
                    {
                        bfs(point);
                        ++nrIsland;
                    }
                }
            }

            void bfs(Point point)
            {
                var q = new Queue<Point>();
                visited.Add(point);
                q.Enqueue(point);

                while (q.Count > 0)
                {
                    point = q.Dequeue();
                    foreach (var direction in _gridMovementVectors)
                    {
                        var neighbourPointX = point.X + direction.Value.X;
                        var neighbourPointY = point.Y + direction.Value.Y;
                        var neighbourPoint = new Point(neighbourPointX, neighbourPointY);
                        if (isNodeInGrid(neighbourPoint)
                            && grid[neighbourPointX][neighbourPointY] == '1'
                            && !visited.Contains(neighbourPoint))
                        {
                            q.Enqueue(neighbourPoint);
                            visited.Add(neighbourPoint);
                        }

                        bool isNodeInGrid(Point point)
                        {
                            return point.X >= 0 && point.X < nrRows
                                                && point.Y >= 0 && point.Y < nrCols;
                        }
                    }
                }
            }

            return nrIsland;
        }
    }
}