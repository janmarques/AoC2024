﻿var fullInput =
@"2701 64945 0 9959979 93 781524 620 1";

var smallInput =
@"125 17";

var smallest = "0 1 10 99 999";

var input = smallInput;
input = fullInput;
//input = smallest;
var depth = 25;


var timer = System.Diagnostics.Stopwatch.StartNew();

var result = 0ul;

var stones = input.Split(' ').Select(ulong.Parse).ToList();


foreach (var stone in stones)
{
    result += (ulong)DeepBlink(new[] { stone }, depth);
    Console.WriteLine(stone);
}


int DeepBlink(ulong[] numbers, int depthLeft)
{
    if (depthLeft == 0)
    {
        return numbers.Count();
    }
    return numbers.Sum(x => DeepBlink(Blink(x).ToArray(), depthLeft - 1));
}

IEnumerable<ulong> Blink(ulong number)
{
    if (number == 0)
    {
        yield return 1;
        yield break;
    }
    var digits = Math.Ceiling(Math.Log10(number + 1));
    if (digits % 2 == 0)
    {
        yield return number / (ulong)Math.Pow(10, digits / 2);
        yield return number % (ulong)Math.Pow(10, digits / 2);
    }
    else
    {
        yield return number * 2024;
    }
}

timer.Stop();
Console.WriteLine();
Console.WriteLine(result); // 154498 too low
Console.WriteLine(timer.ElapsedMilliseconds + "ms");
Console.ReadLine();
