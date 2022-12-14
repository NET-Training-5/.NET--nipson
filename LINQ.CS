
// LINQ - Language Integrated Query

using System;
using System.Collections.Generic;
using System.Linq;

class LINQ
{
int[] numbers = { 3, 4, 6, 8, 1, 3, 4, 51, 45, 67, 12, 34, 35 };

 public void LearnToQuery()
 {
        // List all even numbers from "numbers" array

        // Declarative
 var evenNumbers = numbers.Where(x => x % 2 == 0); 
 PrintValues(evenNumbers, "Even Numbers: "); 

        // List all odd numbers which are divisible by 3
 var oddNumbers = numbers.Where(x => x % 2 != 0 && x % 3 == 0);
 PrintValues(oddNumbers, "Odd Numbers divisible by 3: ");

        // List multiples of 5 and 7 from "numbers"
 var multipleOf5And7 = numbers.Where(x => x % 5 == 0 && x % 7 == 0); 
 PrintValues(multipleOf5And7, "Multiple of 5 and 7: ");

        // List all items less than 100 and ends with 0, from "numbers"
 }

 void PrintValues(IEnumerable<int> items, string label)
 {
 Console.Write($"\n{label}");
foreach(var item in items)
 Console.Write(item + " "); 
}
}

