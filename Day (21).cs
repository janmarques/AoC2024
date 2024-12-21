using AoC2023;
using AoC2024;
using System.IO;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using static AoC2023.Utils;

var fullInput =
@"286A
480A
140A
413A
964A";

var smallInput =
@"029A
980A
179A
456A
379A";

var smallest =
    @"1A";

var input = smallInput;
//input = fullInput;
//input = smallest;

var legalPathsCache = new Dictionary<string, List<string>>();
var longCompletePathsCache = new Dictionary<string, List<string>>();

var timer = System.Diagnostics.Stopwatch.StartNew();

var result = BigInteger.Zero;

var doorKeypadStr =
@"789
456
123
.0A";

var doorkeypad = Utils.ParseCoordGrid(doorKeypadStr).ToList();

var robotKeypadStr =
@".^A
<v>";


var directions = new List<(char c, int x, int y)> { ('^', 0, -1), ('v', 0, 1), ('<', -1, 0), ('>', 1, 0) };
var robotKeypad = Utils.ParseCoordGrid(robotKeypadStr).ToList();

var xxx = new string(ReverseCheck("v<A<AA>>^AvAA^<A>Av<<A>>^AvA^Av<A>^A<Av<A>^>AvA^Av<A<A>>^AvA^<A>A", robotKeypad).ToArray());
var xx = new string(ReverseCheck("v<<A>>^A<A>AvA^<A>Av<A>^A", robotKeypad).ToArray());
var das = new string(ReverseCheck("<A^A>^AvA", doorkeypad).ToArray());

var codes = input.Split(Environment.NewLine).Select(x => (code: x, numeric: int.Parse(new string(x.SkipLast(1).ToArray())))).ToList();


var enableCache = false;
enableCache = true;

var betweenRobotCount = 2;
foreach (var code in codes)
{
    var d1 = GetLongCompletePathsSplit(doorkeypad, code.code);

    Console.WriteLine($"{code.code} {d1.First()}");

    for (int i = 0; i < betweenRobotCount; i++)
    {
        d1 = d1.SelectMany(x => GetLongCompletePathsSplit(robotKeypad, x)).ToList();
        var min = d1.Min(x => x.Length);
        d1 = d1.Where(x => x.Length == min).ToList();
        Console.WriteLine($"{code.code} {i}");
    }

    var somePath = d1.First();

    result += new BigInteger(somePath.Length) * new BigInteger(code.numeric);
}

List<string> GetLongCompletePathsSplit(List<(int x, int y, char c)> grid, string search) //  cache not used. Can we split up?
{
    var subBlocks = new List<List<string>>();
    var blockSize = 0;
    for (int i = 0; i < search.Length; i++)
    {
        if (search[i] == 'A')
        {
            var other = GetLongCompletePaths(grid, search.Substring(i - blockSize, blockSize + 1));
            subBlocks.Add(other);
            blockSize = 0;
        }
        else
        {
            blockSize++;
        }
    }
 
    var paths = new List<string>();
    //paths.Add(string.Join("", subBlocks.SelectMany(x => x.OrderBy(y=> y.Length)).First()));


    ComposePaths("", 0);
    void ComposePaths(string res, int pos)
    {
        if (pos == subBlocks.Count)
        {
            paths.Add(res);
            return;
        }
        foreach (var item in subBlocks[pos])
        {
            ComposePaths(res + item, pos + 1);
        }
    }

    return paths;
}

List<string> GetLongCompletePaths(List<(int x, int y, char c)> grid, string search) //  cache not used. Can we split up?
{
    if (!enableCache) { return GetLongCompletePathsInt(grid, search); }
    var key = $"{grid.Count}|{search}";
    if (!longCompletePathsCache.ContainsKey(key))
    {
        longCompletePathsCache[key] = GetLongCompletePathsInt(grid, search);
    }
    else
    {
        //Utils.Counter("cachehit-GetLongCompletePaths", 100);
    }
    return longCompletePathsCache[key];
}
List<string> GetLongCompletePathsInt(List<(int x, int y, char c)> grid, string search)
{
    var start = grid.Single(x => x.c == 'A');
    var forbidden = grid.Single(x => x.c == '.');

    var pq = new PriorityQueue<(string remaining, string path, int x, int y, int length), int>();
    pq.Enqueue((search, "", start.x, start.y, 0), 0);

    var paths = new List<string>();
    while (pq.Count > 0)
    {
        (string remaining, string path, int x, int y, int length) = pq.Dequeue();
        if (remaining == "") { paths.Add(path); continue; }
        var target = grid.Single(x => x.c == remaining[0]);
        foreach (var item in GetLegalPaths((x, y), (target.x, target.y), grid))
        {
            var newPath = path + item + "A";
            pq.Enqueue((remaining.Substring(1), newPath, target.x, target.y, newPath.Length), newPath.Length);
        }
    }

    var shortest = paths.Min(x => x.Length);

    return paths.Where(x => x.Length == shortest).ToList();
}

List<string> GetLegalPaths((int x, int y) a, (int x, int y) b, List<(int x, int y, char c)> grid)
{
    if (!enableCache) { return GetLegalPathsInt(a, b, grid); }
    var key = $"{grid.Count}|{a.x},{a.y}|{b.x},{b.y}";
    if (!legalPathsCache.ContainsKey(key))
    {
        legalPathsCache[key] = GetLegalPathsInt(a, b, grid);
    }
    else
    {
        //Utils.Counter("cachehit-GetLegalPaths", 1000000);
    }
    return legalPathsCache[key];
}
List<string> GetLegalPathsInt((int x, int y) a, (int x, int y) b, List<(int x, int y, char c)> grid)
{
    (int up, int down, int left, int right) = GetLinkingCharacters(a, b);
    var paths = new List<string>();
    var forbidden = grid.Single(x => x.c == '.');

    ComposePaths("", up, down, left, right, a.x, a.y);
    void ComposePaths(string s, int up, int down, int left, int right, int x, int y)
    {
        if (forbidden.x == x && forbidden.y == y)
        {
            return;
        }
        if (up == 0 && down == 0 && left == 0 && right == 0)
        {
            paths.Add(s);
        }
        else
        {
            if (up > 0)
            {
                ComposePaths(s + '^', up - 1, down, left, right, x, y - 1);
            }
            if (down > 0)
            {
                ComposePaths(s + 'v', up, down - 1, left, right, x, y + 1);
            }
            if (left > 0)
            {
                ComposePaths(s + '>', up, down, left - 1, right, x + 1, y);
            }
            if (right > 0)
            {
                ComposePaths(s + '<', up, down, left, right - 1, x - 1, y);
            }
        }
    }

    return paths;
}


(int up, int down, int left, int right) GetLinkingCharacters((int x, int y) a, (int x, int y) b)
{
    var up = Math.Max(0, a.y - b.y);
    var down = Math.Max(0, b.y - a.y);
    var right = Math.Max(0, a.x - b.x);
    var left = Math.Max(0, b.x - a.x);
    return (up, down, left, right);
}

timer.Stop();
Console.WriteLine(result);
Console.WriteLine(timer.ElapsedMilliseconds + "ms");
Console.ReadLine();

IEnumerable<char> ReverseCheck(string instruction, List<(int x, int y, char c)> myGrid)
{
    var pointer = myGrid.Single(x => x.c == 'A');
    for (int i = 0; i < instruction.Length; i++)
    {
        switch (instruction[i])
        {
            case 'A':
                yield return myGrid.Single(x => x.x == pointer.x && x.y == pointer.y).c;
                break;
            case 'v': pointer.y++; break;
            case '^': pointer.y--; break;
            case '>': pointer.x++; break;
            case '<': pointer.x--; break;
            default: throw new NotImplementedException();
        }

    }
}
