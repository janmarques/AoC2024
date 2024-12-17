//using System.Globalization;
//using System.Text;

//var fullInput =
//@"Register A: 30886132
//Register B: 0
//Register C: 0

//Program: 2, 4,1,1, 7,5,0, 3,1,4, 4,4,5, 5,3,0";

//var smallInput =
//@"Register A: 729
//Register B: 0
//Register C: 0

//Program: 0,1,5,4,3,0";

//var smallest =
//@"Register A: 0
//Register B: 0
//Register C: 0

//Program: 0,0,0";

//smallest =
//@"Register A: 2024
//Register B: 0
//Register C: 0

//Program: 0,3,5,4,3,0 ";

//var input = smallInput;
//input = fullInput;
////input = smallest;

//var timer = System.Diagnostics.Stopwatch.StartNew();
//var result = 0l;

//var program = input.Split(Environment.NewLine).Last().Split(":").Last().Split(",", StringSplitOptions.TrimEntries).Select(long.Parse).ToArray();

//// Heavily based on https://github.com/dmitry-shechtman/aoc2024/blob/main/day17/Program.cs
//for (int depth = 1; depth <= program.Length; depth++)
//{
//    result *= 8;
//    var needle = program.TakeLast(depth);
//    while (!needle.SequenceEqual(Play(result)))
//    {
//        result++;
//    }
//}

//IEnumerable<long> Play(long a)
//{
//    var b = 0L;
//    var c = 0L;

//    for (long i = 0; i < program.Length; i = i + 2)
//    {
//        long GetValue(long n)
//        {
//            if (n < 4) { return n; }
//            if (n == 4) { return a; }
//            if (n == 5) { return b; }
//            if (n == 6) { return c; }
//            return long.MaxValue;
//        }
//        var opcode = program[i];
//        var literalOperant = program[i + 1];
//        var comboOperant = GetValue(literalOperant);

//        switch (opcode)
//        {
//            case 0: a /= (int)Math.Pow(2, comboOperant); break;
//            case 1: b ^= literalOperant; break;
//            case 2: b = comboOperant % 8; break;
//            case 3: if (a != 0) { i = literalOperant - 2; }; break;
//            case 4: b ^= c; break;
//            case 5: yield return comboOperant % 8; break;
//            case 6: b = a / (int)Math.Pow(2, comboOperant); break;
//            case 7: c = a / (int)Math.Pow(2, comboOperant); break;
//        }
//    }
//}



//timer.Stop();
//Console.WriteLine(result); // until 553400000
//Console.WriteLine(timer.ElapsedMilliseconds + "ms");
//Console.ReadLine();

//void PrintGrid<T>(T[][] grid)
//{
//    for (int i = 0; i < grid.Length; i++)
//    {
//        for (int j = 0; j < grid[i].Length; j++)
//        {
//            Console.Write(grid[i][j]);
//        }
//        Console.WriteLine();
//    }
//}