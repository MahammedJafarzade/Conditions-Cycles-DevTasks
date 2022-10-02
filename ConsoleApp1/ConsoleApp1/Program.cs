using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Conditions/Task1
            //Console.Write("a=");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("b=");
            //int b = int.Parse(Console.ReadLine());
            //if (a > b)
            //{
            //Console.WriteLine(a+b);
            //}
            //else if (a < b)
            //{
            //    Console.WriteLine(a - b);
            //}
            //else
            //{
            //    Console.WriteLine(a * b);

            //}
            #endregion
            #region Task2
            // Console.Write("Enter number x: ");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter number y: ");
            //int y = Convert.ToInt32(Console.ReadLine());
            //if (x > 0 && y > 0)
            //{
            //    Console.WriteLine("Point is in 1st quadrant");
            //}
            //else if (x < 0 && y > 0)
            //{
            //    Console.WriteLine("Point is in 2nd quadrant");
            //}
            //else if (x < 0 && y < 0)
            //{
            //    Console.WriteLine("Point is in 3rd quadrant");
            //}
            //else if (x > 0 && y < 0)
            //{
            //    Console.WriteLine("Point is in 4th quadrant");
            //}
            //else
            //{
            //    Console.WriteLine("Point is in (0,0) coordinate");
            //}

            #endregion
            #region Task3
            //Console.Write("a=");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("b=");
            //int b = int.Parse(Console.ReadLine());
            //Console.Write("c=");
            //int c = int.Parse(Console.ReadLine());
            //if (a > b && b > c && a>c) 
            //{
            //    Console.WriteLine($"c,b,a");
            //}
            //else if (b > c && b > a && a<c)
            //{
            //    Console.WriteLine($"a,c,b");
            //}
            //else if (b < c && b > a && c > a)
            //{
            //    Console.WriteLine($"a,b,c");
            //}
            //else if (c>b && a>b && c>a)
            //{
            //    Console.WriteLine($"b,a,c");
            //}
            //else if (a > b && a > c && c > b)
            //{
            //    Console.WriteLine($"b,c,a");
            //}
            //else if (c<a && a<b && c<b)
            //{
            //    Console.WriteLine($"c,a,b");
            //}
            #endregion

            #region Task5
            //Console.Write("Please input Numner: ");
            //int input_number = Convert.ToInt32(Console.ReadLine());


            //string[] numbers_1_9 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //string[] numbers_10_90 = { "ten", "twenty", "thirty", "forty", "fivety", "sixty", "seventy", "eighty", "ninety" };

            //if (input_number == 11)
            //{
            //    Console.WriteLine("Eleven");
            //}
            //if (input_number == 12)
            //{
            //    Console.WriteLine("Twelve");
            //}
            //if (input_number == 13)
            //{
            //    Console.WriteLine("thirteen");
            //}
            //if (input_number == 14)
            //{
            //    Console.WriteLine("fourteen");
            //}
            //if (input_number == 15)
            //{
            //    Console.WriteLine("fifteen");
            //}
            //if (input_number == 16)
            //{
            //    Console.WriteLine("sixteen");
            //}
            //if (input_number == 17)
            //{
            //    Console.WriteLine("seventeen");
            //}
            //if (input_number == 18)
            //{
            //    Console.WriteLine("eighteen");
            //}
            //else if (input_number == 19)
            //{
            //    Console.WriteLine("nineteen");
            //}

            //else if (input_number % 10 == 0)
            //{

            //    int whole_number = input_number / 10;
            //    Console.WriteLine(numbers_10_90[whole_number - 1]);

            //}
            //else if (input_number < 10)
            //{
            //    int whole_number = input_number / 10;

            //    Console.WriteLine(numbers_1_9[whole_number - 1]);
            //}

            #endregion
            #region Task7
            //Console.WriteLine("Choose option:");
            //string option = Console.ReadLine();
            ////a.Take a 3 - digit number as input,
            ////and say if square of this number equals
            ////sum of all it’s digits to the power of 3.
            //if (option == "a")
            //{
            //    Console.WriteLine("Enter 3 digit number:");

            //}

            #endregion
            //Cycles
            #region Task1
            //1.User gives 2 numbers a, b. Output a to the power of b(not using Math.pow)
            //Console.Write("a=");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("b=");
            //int b = Convert.ToInt32(Console.ReadLine());
            //int result = 1;
            //for (int i = 1; i <= b; i++)
            //{
            //    result = result * a;
            //}
            //Console.WriteLine(result);

            #endregion
            #region Task2
            //Console.Write("a=");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int count = 0;
            //for (int i = 1; i <= 1000; i++)
            //{
            //    if (i%a==0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);
            #endregion
            #region Task3
            //Console.Write("a=");
            //int a = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < a; i++)
            //{
            //    if (i * i < a)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion
            #region Task4
            //Console.Write("a=");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int result = 1;
            //for (int i = 1; i < a; i++)
            //{
            //    if (a % i == 0)
            //    {
            //        result = i;
            //    }
            //}
            //Console.WriteLine(result);
            #endregion
           
           
        }
    }
}
