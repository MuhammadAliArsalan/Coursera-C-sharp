//using System;
//using System.Collections.Generic;
//using System.Linq;  // Needed for .Count(), .Where(), etc.

//public class LambdaExp
//{
//    public static void Main()
//    {
//        //  Expression Lambda
//        var numbers = new int[] { 2, 5, 6, 7, 10, 11 };
//        var count = numbers.Count(x => x == 11);  // Expression lambda: x => x == 5
//        Console.WriteLine("Expression Lambda Count: " + count);  // Output: 1

//        // Statement Lambda
//        List<int> numbers2 = new List<int> { 2, 3, 5, 6, 7, 10, 11 };
//        var count2 = numbers2.Count(x =>
//        {
//            return x == 5;  // Statement lambda (has return inside curly braces)
//        });
//        Console.WriteLine("Statement Lambda Count: " + count2);  // Output: 1
//    }
//}
