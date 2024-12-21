using AoC2023;
using AoC2024;
using System.IO;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;

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
@"001A
002A
003A
004A
005A
006A
007A
008A
009A";


var input = smallInput;
input = fullInput;
//input = smallest;

var legalPathsCache = new Dictionary<string, List<string>>();

var timer = System.Diagnostics.Stopwatch.StartNew();

var result = 0l;

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


var hmm = "v<A<AA^>>AA<Av>A^AvA^Av<<A^>>AAvA^Av<A^>AA<A>Av<A<A^>>AAA<Av>A^A";
var asdasd = new string(ReverseCheck(hmm, robotKeypad, null).ToArray());
var asdasd2 = new string(ReverseCheck(asdasd, robotKeypad, null).ToArray());
var asdasd3 = new string(ReverseCheck(asdasd2, doorkeypad, null).ToArray());


var codes = input.Split(Environment.NewLine).Select(x => (code: x, numeric: int.Parse(x.Substring(0, 3)))).ToList();

var betweenRobotCount = 2;
foreach (var code in codes)
{
    var d1 = GetLongCompletePaths(doorkeypad, code.code);

    for (int i = 0; i < betweenRobotCount; i++)
    {
        d1 = d1.SelectMany(x => GetLongCompletePaths(robotKeypad, x)).ToList();
        var min = d1.Min(x => x.Length);
        Console.WriteLine($"{code.code} {i} = {d1.Count}, {min}");
        d1 = d1.Where(x => x.Length == min).ToList();
        Console.WriteLine($"{code.code} {i} = {d1.Count}, {min}");
    }

    var somePath = d1.First();

    result += somePath.Length * code.numeric;
}

IEnumerable<char> ReverseCheck(string instruction, List<(int x, int y, char c)> myGrid, List<(int x, int y, char c)> nextGrid)
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


List<string> GetLongCompletePaths(List<(int x, int y, char c)> grid, string search)
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
        var target = grid.Single(x => x.c == remaining.First());
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
    var key = $"{grid.Count}|{a.x},{a.y}|{b.x},{b.y}";
    if (!legalPathsCache.ContainsKey(key))
    {
        legalPathsCache[key] = GetLegalPathsInt(a, b, grid);
    }
    return legalPathsCache[key];
}
List<string> GetLegalPathsInt((int x, int y) a, (int x, int y) b, List<(int x, int y, char c)> grid)
{
    var chars = GetLinkingCharacters(a, b).ToList();
    var paths = new List<string>();
    var forbidden = grid.Single(x => x.c == '.');

    ComposePaths("", chars, a.x, a.y);
    void ComposePaths(string s, List<char> remaining, int x, int y)
    {
        if (forbidden.x == x && forbidden.y == y) { return; }
        if (!remaining.Any())
        {
            paths.Add(s);
        }
        foreach (var item in remaining.Distinct())
        {
            var direction = directions.Single(x => x.c == item);
            var cpy = remaining.ToList();
            cpy.RemoveAt(remaining.IndexOf(item));
            ComposePaths(s + item, cpy, x + direction.x, y + direction.y);
        }
    }

    return paths;
}


IEnumerable<char> GetLinkingCharacters((int x, int y) a, (int x, int y) b)
{
    while (a.x < b.x)
    {
        yield return '>';
        a.x++;
    }
    while (a.x > b.x)
    {
        yield return '<';
        a.x--;
    }
    while (a.y < b.y)
    {
        yield return 'v';
        a.y++;
    }
    while (a.y > b.y)
    {
        yield return '^';
        a.y--;
    }
}



foreach (var line in input.Split(Environment.NewLine))
{

}

timer.Stop();
Console.WriteLine(result);
Console.WriteLine(timer.ElapsedMilliseconds + "ms");
Console.ReadLine();