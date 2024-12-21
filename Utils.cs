using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AoC2023;

public static class Utils
{
    public record Direction(char icon, int x, int y);
    public static Direction[] Directions = new[] {
        new Direction('E', 1, 0),
        new Direction('W', -1, 0),
        new Direction('N', 0, -1),
        new Direction('S', 0, 1),
    };
    public static char InverseDirection(char x)
        => x switch
        {
            'E' => 'W',
            'W' => 'E',
            'S' => 'N',
            'N' => 'S',
            _ => throw new NotImplementedException()
        };

    static public void PrintGrid<T>(T[][] grid, Func<T, string> print = null)
    {
        print ??= x => x.ToString();
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                Console.Write(print(grid[i][j]));
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine();
    }

    static public char[][] RotateClockwise(char[][] input)
    {
        var height = input.Length;
        var width = input[0].Length;

        var target = Enumerable.Range(0, width).Select(x => new char[height]).ToArray();

        for (var i = 0; i < height; i++)
        {
            for (var j = 0; j < width; j++)
            {
                target[j][i] = input[height - 1 - i][j];
            }
        }
        return target;
    }


    static public void PrintGrid<T>(IEnumerable<T> grid, Func<T, int> X, Func<T, int> Y, Func<T, string> print = null, int? width = null, int? height = null)
    {
        print ??= x => x.ToString();
        width ??= grid.Max(X);
        height ??= grid.Max(Y);
        for (int j = 0; j <= height; j++)
        {
            for (int i = 0; i <= width; i++)
            {
                var item = grid.SingleOrDefault(o => X(o) == i && Y(o) == j);
                Console.Write(item is null ? "?" : print(item));
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine();
    }

    static public (char[][] grid, int height, int width) Parse2DGrid(string input)
    {
        return Parse2DGrid(input, x => x);
    }
    static public (T[][] grid, int height, int width) Parse2DGrid<T>(string input, Func<char, T> parse)
    {
        var grid = input.Split(Environment.NewLine).Select(x => x.Select(y => parse(y)).ToArray()).ToArray();
        return (grid, grid.Length, grid[0].Length);
    }

    static public IEnumerable<(int x, int y, char c)> ParseCoordGrid(string input) => ParseCoordGrid(input, x => (x.x, x.y, x.c));

    static public IEnumerable<T> ParseCoordGrid<T>(string input, Func<(int x, int y, char c), T> init) where T : new()
    {
        (char[][] grid, int height, int width) = Parse2DGrid(input);
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                yield return init((x, y, grid[y][x]));
            }
        }

    }

    static public int Manhatten((int x, int y) from, (int x, int y) to) => Math.Abs(from.x - to.x) + Math.Abs(from.y - to.y);

    static Dictionary<string, int> Counters = new Dictionary<string, int>();
    static public void Counter(string name, int threshold = 10000)
    {
        if (!Counters.ContainsKey(name)) { Counters[name] = 0; }
        Counters[name]++;
        if (Counters[name] % threshold == 0)
        {
            Console.WriteLine($"{name} {Counters[name]}");
        }
    }

    public static string ReplaceFirst(string input, string search, string replacement) => new Regex(Regex.Escape(search)).Replace(input, replacement, 1);
}