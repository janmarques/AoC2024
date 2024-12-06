﻿using System.Threading.Tasks.Dataflow;

var fullInput =
@"..........#.............................#...............#...........#....................#...........#............................
..............................#.......#...#.....#.....#...............#.#..#.......................#............#.................
.............#...........#.#........#............#..........................#.........#.......#......#............................
......................................................#....#..#.............#................................#...#............##..
...............#.....#....................................#......................................................#................
..................##............#......#...............................................................#...................#......
.#......#...........................................................#............................#................................
#..#.............#...............................#.....#....#.............................#....#..............................#...
#...##..........#.........................#.................................................#............#...............#........
............#...............#..............................................#.................................#..........##........
..............#...................#......##...#.....#....................#.......................................................#
.#.....#....#......................#...#........................................#.#.............#.........#.......................
#..#...............#........##.........#.....#..........#.....##.........................#.....#.#................................
...............#...............................#.....#.................................................#..##......................
......#...................#..........#...........................................#....#...........................................
...............................................#...#....##.................................................#.....#................
.................#.........#..............................#........#...#...#...................................#..................
...........#..#.....#...#.........................#..........#.#.............#....#...................##..........................
.........................................#.........................#.#............#...#...##............................#.........
.....#......................................#....................................................#..............#.................
..................................................#..................#................#.............#.#..#..................#.....
............................................#.....#......................#........#..........................................#....
.......#..........................#...#...................................#.........................#...#..........#......#.......
............#...........##........................................................................#......................#........
#.#...............................................#........#..........#.#..#...#................................#.................
..#.........................#.#........................#....##..................................................#............#....
.....................................................................................#...............#...........#..........#.....
....................#..........#................................#...............................................#.................
#..............#.#...........#.........#..........#..........................#......................##........#.........#.........
....#....#...............................................................................#...#...........#............#...#...#...
.......................................................##......................#...#................................#.............
.......#...........##...........................#..............#..............................#...................#......#........
......#.........#..............................................................#........#..#..........#.......#..#...#.....#....#.
....#.............................................#........#....#..................................#..............................
..........#......#...........#....................................#..............#.......#...#............#.......................
...........................................................................................#.......#..............................
.#..................................................#.............................#..................#...................#........
......#..#.#................#.....................#..................................#.............#...............#..............
...............................#..................#........#......................................................................
......................#..................................................................................#.........#..............
...............................................................................................................................#..
.......#..............#...........................................................#......................#.......................#
#...............................#..............................#.......#..............................#...#...#........#..........
............................#....#...#.........#....#................................................................#............
.....................#.................................................................#..#....#..................#...............
......................#.............#.............................#...................................................#...........
....#.................#.#.........##................#.....#....................................................#.............#....
...............................#...#...................#.......................................#......#...........................
....#.............................................................................................................................
...#.......................................................................................................#............#.......#.
..#.............##.............................................................#...#............................#............#....
......................#.......#............#........................................................#..................#......#...
...................#.............#..................#..............................#............#........#...................#....
....................#...........#.........................................................#......#.......#...........#.....##.....
...........#.........................................#.............................#..............#..................#............
......................#.........#...................#......#...........................................#..........................
..#....#...#.............................#..............#.....................#............#...................................#..
.....#.............................#....#..................................#...................#...#.............#................
...................#...#...........#........................#.............#........................#...#.............#..........#.
...#...........#......#.......#..............#......#..........#.....#............................................................
..#......................................................#......#...........................#...........#......#..#...............
........#............................#.#....................#...#...#......#.....#...............................................#
.............#....#........#.........................................................................................#.........#..
....................................................................................................#.............................
..#........................#....#............................................................................#....................
.......................................#.....#.#.......................................#......#........#.#...................#....
.................#........#....................................#...#..#................................#..........................
...........#.................................................................................................#....................
......................#..................#...#.............#................##................#.......#...........#.........#.....
............#..#................#.............................................#............##..................##..........#......
......#.#.......................#............#...........................................................#........................
#......................................#.#......^...............................................#.................................
........#...........................................................#...............#.............................................
...#.............................................#.................#...............#.............................#...#.#..........
....................#........#...........##.......................#.................#..................#................#.........
#.................................................................................................................................
............#.......................................................................................#.#.........#..............#..
...............#....#............#..................................................#......##.................................#...
.............................#.........#...............#......#.......#.................#........................#........#.......
......................................................#........................................................#.................#
.................#.#...............#......................................................................................#....#..
........#.............#......................#...........#...........#......................................#..............#......
......................#......................#...........#.....#.....##............................................#....#.........
.............#................................................................................#..........#.....#..................
............##...........................#.................................#..#.#....................................#............
..............................................................................................#............................#......
...#.............................#..#..#....................................#..............#....#.................................
.....#..........................................................#.....#......#.........#..........................................
....##......#.....................#..........#..............#..................#.#..............#........#...........#....#.......
.....#...#.........#............#............#.............................................................#......................
.........#...................................#...........#.....................................##.....#............#..............
.....##.#............##.....................#..........................#.................................#........#...............
.......................#..............##...#...................................................#.........#........................
..#........#.......#...#..##............#....................................................................#...........#.....#..
..#.....................................................................#..............#.............#...................#........
...........#..........#..........#.....#.................................................................#..#.....................
..........#................#........................................................##.#...............................#.#......#.
#............................................#...........................##...#.......................#.............#.............
..#............#........................................................................................................#.........
....................................................#....................#............#...............#..........................#
........................................................................#.......#.....................................#.#.........
................#..#......................#...........................................#...........................................
........................##............................................#.............##..........................#.......#....#....
.........#.......#..............................#......#....#............#..................#...#.................................
#.........#............................#....#.#..#.........................................................##.....................
.#..##...............#....#.............................#...............#........#.......................................#......#.
...#............................................................#.....................#.................#.....#...................
...#...........#..#.............................#.....#.............................................................#.............
...#.........................#..............................................................................................##....
.........................#...........................#.......................#...........#........................................
.#..................................#.............................................................................................
....................................................................#...........##.....#.#.........#.....#........................
................#...............................#........#........................................................................
......#....#.................................#...................................#.#.........#.....#....................#.........
................#..............................#.......................#...#.....#.......#................#.......................
....................#......................................#..#...........#.#.................#...#.......................#.......
.............#..#...#............................#.#...........................................#.......................#..........
.........#..........#.................#....................................#.#..........................................#.........
....#.............#......................................................#...........#...........................#................
........#.#............................#...........................................#.................#..............#..........#..
..............#..........................#............#.........#....#...#.....#.........................#....#...............##..
...................#.........................................................#.......#........#..............#..........#.........
.#........#....#..................................#..#.#...............#............#...........#.................................
...............................................................................................#.....#....#.............#.........
...........#..........#...........................................#.........#..............#................#..........#..........
............#.................................###..............#.#...............................................................#
......#...................................................................................#............#...#..........#.....#.....
.............#..................#...................#......#.........#..#.......................#....#................#..........#
..#....##................................#.................#...........................#.......#....#...#..........#..............
...............................#......................................#.........#.............#......................#..........#.";

var smallInput =
@"....#.....
.........#
..........
..#.......
.......#..
..........
.#..^.....
........#.
#.........
......#...";

var smallest = "";

var input = smallInput;
input = fullInput;
//input = smallest;
var timer = System.Diagnostics.Stopwatch.StartNew();

var result = 0;

var lines = input.Split(Environment.NewLine);
var height = lines.Count();
var width = lines[0].Length;

var grid = new bool[width, height];
var start = (-1, -1);
{
    var y = 0;
    foreach (var line in lines)
    {
        var x = 0;
        foreach (var item in line)
        {
            grid[x, y] = item == '#';
            if (item == '^')
            {
                start = (x, y);
            }
            x++;
        }
        y++;
    }
}

var potentialBlockages = Evaluate().Select(x => (x.X, x.Y)).Distinct();
foreach (var potentialBlockage in potentialBlockages)
{
    var (x, y) = potentialBlockage;
    if (grid[x, y]) { continue; }
    grid[x, y] = true;
    if (Evaluate2())
    {
        result++;
    }

    grid[x, y] = false;
}

bool? TryGetNode(int x, int y)
{
    if (x < 0 || y < 0) { return null; }
    if (x >= width || y >= height) { return null; }
    return grid[x, y];
}


(int X, int Y) GetNext(int x, int y, int direction)
{
    if (direction == 0)
    {
        return (x, y - 1);
    }
    if (direction == 90)
    {
        return (x + 1, y);
    }
    if (direction == 180)
    {
        return (x, y + 1);
    }
    return (x - 1, y);
}

timer.Stop();
Console.WriteLine(result); // 1604
Console.WriteLine(timer.ElapsedMilliseconds + "ms");
//Console.ReadLine();


void PrintGrid<T>(T[][] grid)
{
    for (int i = 0; i < grid.Length; i++)
    {
        for (int j = 0; j < grid[i].Length; j++)
        {
            Console.Write(grid[i][j]);
        }
        Console.WriteLine();
    }
}

HashSet<(int X, int Y, int Direction)> Evaluate()
{
    var visitedPairs = new HashSet<(int X, int Y, int Direction)>();
    var direction = 0;
    (int X, int Y) guardPosition = (start.Item1, start.Item2);
    while (true)
    {
        bool? facingNode = true;
        (int X, int Y) facing = (0, 0);
        while (facingNode.Value)
        {
            facing = GetNext(guardPosition.X, guardPosition.Y, direction);
            facingNode = TryGetNode(facing.X, facing.Y);
            if (facingNode == null)
            {
                return visitedPairs;
            }
            if (facingNode.Value)
            {
                direction = (direction + 90) % 360;
            }
        }

        guardPosition = facing;
        var pair = (guardPosition.X, guardPosition.Y, direction);
        if (visitedPairs.Contains(pair))
        {
            return null;
        }
        visitedPairs.Add(pair);
    }
}

bool Evaluate2()
{
    var visitedPairs = new HashSet<uint>();
    var direction = 0;
    (int X, int Y) guardPosition = (start.Item1, start.Item2);
    while (true)
    {
        var facing = GetNext(guardPosition.X, guardPosition.Y, direction);
        var facingNode = TryGetNode(facing.X, facing.Y);
        if (facingNode == null)
        {
            return false;
        }
        var deepBreak = false;
        while (facingNode.Value)
        {
            direction = (direction + 90) % 360;
            facing = GetNext(guardPosition.X, guardPosition.Y, direction);
            facingNode = TryGetNode(facing.X, facing.Y);
            //if (facingNode == null) // unreachable edgecase?
            //{
            //    deepBreak = true;
            //    break; //exiting
            //}
        }
        if (deepBreak) { return false; }

        guardPosition = facing;
        var pair = (uint)(guardPosition.X + guardPosition.Y * 131 + direction * 17_161);
        if (visitedPairs.Contains(pair))
        {
            return true;
        }
        visitedPairs.Add(pair);
    }
}