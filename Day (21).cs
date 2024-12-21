using AoC2023;

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

var smallest = "";

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


    //Console.WriteLine($"{code.code}: {d3}");

    result += d3.Length * code.numeric;
}

IEnumerable<char> Type(string instruction, List<(int x, int y, char c)> grid)
{
    var pointer = grid.Single(x => x.c == 'A');
    foreach (var item in instruction)
    {
        var target = grid.Single(x => x.c == item);
        //while ((pointer.x, pointer.y) != (target.x, target.y))
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

        if ((pointer.x, pointer.y) != (target.x, target.y)) { throw new Exception(); }


        yield return 'A';
        pointer = target;
    }
}


foreach (var line in input.Split(Environment.NewLine))
{

}

timer.Stop();
Console.WriteLine(result);
Console.WriteLine(timer.ElapsedMilliseconds + "ms");
Console.ReadLine();