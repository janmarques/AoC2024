//var fullInput =
//@"2701 64945 0 9959979 93 781524 620 1";

//var smallInput =
//@"125 17";

//var smallest = "0 1 10 99 999";

//var input = smallInput;
//input = fullInput;
////input = smallest;
//var depth = 75;


//var timer = System.Diagnostics.Stopwatch.StartNew();

//var result = 0l;

//var stones = input.Split(' ').Select(long.Parse).ToList();

//var dct = new Dictionary<(string, int), long>();

//for (int i = 0; i <= depth; i++)
//{
//    //Console.WriteLine($"depth {i}");

//    result = 0;
//    foreach (var stone in stones)
//    {
//        result += (long)DeepBlink(new[] { stone }, i);
//    }
//    //Console.WriteLine($" | Stones = {result}");

//}


//long DeepBlink(IEnumerable<long> numbers, int depthLeft)
//{
//    var key = (string.Join("|", numbers), depthLeft);
//    if (!dct.ContainsKey(key))
//    {
//        long cacheResult;
//        if (depthLeft == 0)
//        {
//            //Console.Write(" " + string.Join(" ", numbers));
//            cacheResult = numbers.Count();
//        }
//        else
//        {
//            cacheResult = numbers.Sum(x => DeepBlink(Blink(x), depthLeft - 1));
//        }
//        dct[key] = cacheResult;
//    }
//    return dct[key];
//}

//IEnumerable<long> Blink(long number)
//{
//    if (number == 0)
//    {
//        yield return 1;
//        yield break;
//    }
//    var digits = Math.Ceiling(Math.Log10(number + 1));
//    if (digits % 2 == 0)
//    {
//        yield return number / (long)Math.Pow(10, digits / 2);
//        yield return number % (long)Math.Pow(10, digits / 2);
//    }
//    else
//    {
//        yield return number * 2024;
//    }
//}

//timer.Stop();
//Console.WriteLine();
//Console.WriteLine(result); // 154498 too low
//Console.WriteLine(timer.ElapsedMilliseconds + "ms");
//Console.ReadLine();
