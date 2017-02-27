using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test
{
    public class Leetcode463
    {
        public static int IslandPerimeter(int[,] grid)
        {
            int islands = 0;
            int neighbours = 0;
            for(int i =0;i<grid.GetLength(0);i++)
            {
                for(int j=0;j<grid.GetLength(1);j++)
                {
                    if (grid[i, j] == 1)
                    {
                        islands++;
                        if (i < grid.GetLength(0) - 1 && grid[i + 1, j] == 1) neighbours++;
                        if (j < grid.GetLength(1) - 1 && grid[i, j + 1] == 1) neighbours++;
                    }
                }
            }

            return 4*islands - 2*neighbours;
        }
    }
}
