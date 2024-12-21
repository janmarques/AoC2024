using AoC2023;
using System.Runtime.ConstrainedExecution;

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


var input = smallInput;
//input = fullInput;
//input = smallest;

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

var robotKeypad = Utils.ParseCoordGrid(robotKeypadStr).ToList();


var hmm = "v<A<AA^>>AA<Av>A^AvA^Av<<A^>>AAvA^Av<A^>AA<A>Av<A<A^>>AAA<Av>A^A";
var asdasd = new string(ReverseCheck(hmm, robotKeypad, null).ToArray());
var asdasd2 = new string(ReverseCheck(asdasd, robotKeypad, null).ToArray());
var asdasd3 = new string(ReverseCheck(asdasd2, doorkeypad, null).ToArray());


var codes = input.Split(Environment.NewLine).Select(x => (code: x, numeric: int.Parse(x.Substring(0, 3)))).ToList();

foreach (var code in codes)
{
    var d1 = new string(Type(code.code, doorkeypad).ToArray());
    var d2 = new string(Type(d1, robotKeypad).ToArray());
    var d3 = new string(Type(d2, robotKeypad).ToArray());

    Console.WriteLine(d3);
    Console.WriteLine(d2);
    Console.WriteLine(d1);
    Console.WriteLine(code.code);

    //var aaa = new string(ReverseCheck(d1, doorkeypad, null).ToArray());
    //var bbb = new string(ReverseCheck(d2, robotKeypad, null).ToArray());
    //var ccc = new string(ReverseCheck(d3, robotKeypad, null).ToArray());
    //Console.WriteLine($"{aaa == code.code}");
    //Console.WriteLine($"{bbb == d1}");
    //Console.WriteLine($"{ccc == d2}");


    Console.WriteLine($"{code.code}: {d3}");

    result += d3.Length * code.numeric;
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

IEnumerable<char> Type(string instruction, List<(int x, int y, char c)> grid)
{
    var currentLinking = default(char);
    var pointer = grid.Single(x => x.c == 'A');
    var forbidden = grid.Single(x => x.c == '.');
    for (int i = 0; i < instruction.Length; i++)
    {
        var target = grid.Single(x => x.c == instruction[i]);

        var lastLink = default(char);
        if (i + 1 < instruction.Length)
        {
            var next = grid.Single(x => x.c == instruction[i + 1]);
            var links = GetLinkingCharacters(target, next).Distinct().Where(x => x != currentLinking).ToList(); // mss moet dat niet except, en indien genoeg chars kan het aan begin en einde gebruikt worden
            lastLink = links.LastOrDefault();
        }

        var todo = new[] { 'v', '^', '<', '>' };

        var order = new List<char>();
        order.Add(currentLinking);
        order.AddRange(todo.Where(x => x != lastLink));
        if (lastLink != default) { order.Add(lastLink); }

        currentLinking = lastLink;

        while ((pointer.x, pointer.y) != (target.x, target.y))
        {
            foreach (var item in order)
            {
                foreach (var link in Do(item))
                {
                    yield return link;
                }
            }
        }


        IEnumerable<char> Do(char c)
        {

            bool IsForbidden(int x, int y) => forbidden.x == x && forbidden.y == y;
            if (c == '>')
            {
                while (pointer.x < target.x)
                {
                    if (IsForbidden(pointer.x + 1, pointer.y)) { break; }
                    yield return '>';
                    pointer.x++;
                }
            }
            if (c == '<')
            {
                while (pointer.x > target.x)
                {
                    if (IsForbidden(pointer.x - 1, pointer.y)) { break; }
                    yield return '<';
                    pointer.x--;
                }
            }
            if (c == 'v')
            {
                while (pointer.y < target.y)
                {
                    if (IsForbidden(pointer.x, pointer.y + 1)) { break; }
                    yield return 'v';
                    pointer.y++;
                }
            }
            if (c == '^')
            {
                while (pointer.y > target.y)
                {
                    if (IsForbidden(pointer.x, pointer.y - 1)) { break; }
                    yield return '^';
                    pointer.y--;
                }
            }
        }

        if ((pointer.x, pointer.y) != (target.x, target.y)) { throw new Exception(); }


        yield return 'A';
        pointer = target;
    }
}

IEnumerable<char> GetLinkingCharacters((int x, int y, char c) pointer, (int x, int y, char c) target)
{
    while (pointer.x < target.x)
    {
        yield return '>';
        pointer.x++;
    }
    while (pointer.x > target.x)
    {
        yield return '<';
        pointer.x--;
    }
    while (pointer.y < target.y)
    {
        yield return 'v';
        pointer.y++;
    }
    while (pointer.y > target.y)
    {
        yield return '^';
        pointer.y--;
    }
}



foreach (var line in input.Split(Environment.NewLine))
{

}

timer.Stop();
Console.WriteLine(result);
Console.WriteLine(timer.ElapsedMilliseconds + "ms");
Console.ReadLine();