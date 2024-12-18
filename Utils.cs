using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2024s
{
    public class Utils
    {
        public void PrintGrid<T>(T[][] grid, Func<T, string> print)
        {
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    Console.Write(print(grid[i][j]));
                }
                Console.WriteLine();
            }
        }

        public void PrintGrid2<T>(IEnumerable<T> grid, Func<T, int> X, Func<T, int> Y, Func<T, string> print)
        {
            var width = grid.Max(X);
            var height = grid.Max(Y);
            for (int i = 0; i <= width; i++)
            {
                for (int j = 0; j <= height; j++)
                {
                    var item = grid.SingleOrDefault(o => X(o) == j && Y(o) == i);
                    Console.Write(item is null ? "?" : print(item));
                }
                Console.WriteLine();
            }
        }
    }
}
