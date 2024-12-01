//using System.Collections.Generic;

//var fullInput =
//@"Time:        46     82     84     79
//Distance:   347   1522   1406   1471";

//var smallInput =
//@"Time:      7  15   30
//Distance:  9  40  200";

//var smallest = "";

//var input = smallInput;
//input = fullInput;
////var input = smallest;
//var timer = System.Diagnostics.Stopwatch.StartNew();

//var result = 0;

//var numbers = input.Split(Environment.NewLine).Select(x => x.Split(":")).Select(x => long.Parse(x[1].Replace(" ", "")));
//var T = numbers.First();
//var D = numbers.Last();

//var disc = Math.Sqrt(Math.Pow(T, 2) - 4 * D);
//var zero1 = (-1 * T + disc) / 2;
//var zero2 = (-1 * T - disc) / 2;

//result = (int)Math.Floor(zero1 - zero2);


//Console.WriteLine(result);

//timer.Stop();
//Console.WriteLine(timer.ElapsedMilliseconds + "ms");
//Console.ReadLine();
////28360140
////8ms

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