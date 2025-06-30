namespace _21_ProblemNo_463
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Solution solution = new Solution();
            int[][] grid = new int[][]
             {
                new int[] { 0, 1, 0, 0 },
                new int[] { 1,1,1,0 },
                new int[] { 0,1,0,0 },
                new int[] { 1, 1, 0, 0 }
             };
             solution.IslandPerimeter(grid);
        }
    }

    public class Solution
    {
        public int IslandPerimeter(int[][] grid)
        {
            int perimeter = 0;
            int maxRows = grid.Count();
            int maxColumns = grid[0].Length;

            for(int i =0; i < maxRows; i++)
            {
                for(int j = 0; j < maxColumns; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        //// CHECK LEFT OF CURRENT ROW
                        int currentRowPreviousColumnn = j - 1;
                        CalculatePermeter(grid,ref perimeter,i, currentRowPreviousColumnn);

                        //// CHECK RIGHT OF CURRENT ROW
                        int currentRowNextColumn = j + 1;
                        CalculatePermeter(grid,ref perimeter,i, currentRowNextColumn);


                        //////// CHECK TOP of CURRENT COLUMN
                        int previousRow = i - 1;
                        CalculatePermeter(grid, ref perimeter, previousRow, j);

                        //////// CHECK DOWN of CURRENT COLUMN 
                        int nextRow = i + 1;
                        CalculatePermeter(grid, ref perimeter, nextRow, j);
                    }
                }
            }

            return perimeter;
        }

        private void CalculatePermeter(int[][] grid, ref int perimeter, int row, int column)
        {
            bool isWithinBound = this.IsArrayWithinBounds(grid, row, column);
            if (isWithinBound)
            {
                if (grid[row][column] == 0)
                {
                    perimeter++;
                }
            }
            else
            {
                perimeter++;
            }
        }

        private bool IsArrayWithinBounds(int[][] array, int row, int col)
        {
            if (row >= 0 && row < array.Length &&
    col >= 0 && col < array[row].Length)
            {
                return true;
            }

            return false;
        }
    }

}