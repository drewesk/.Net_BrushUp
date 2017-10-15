// Methods, Pass-Value, Pass-Reference, Out, Params, Named-Params, Method-Overloading, and Enum! 
using System;

namespace Enum_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //===========================
            // Pass-Value
            //===========================

            //double xVar = 5;
            //double yVar = 4;

            //Console.WriteLine("5 + 4 = {0}",
            //                  GetSum(xVar, yVar));
            //Console.WriteLine("x: {0}", xVar);

            //===========================
            // Ref-Value
            //===========================

            //int solution;

            //DoubleIt(15, out solution);

            //Console.WriteLine("15 * 2 = {0}", solution);

            //

            //int num1 = 10;
            //int num2 = 20;

            //Console.WriteLine("Before Swap num1: {0}, num2: {1}", num1, num2);

            //Swap(ref num1, ref num2);

            //Console.WriteLine("After Swap num1: {0}, num2:D {1}", num1, num2);

            //===========================
            // Params
            //===========================

            //Console.WriteLine("1 + 2 + 3 = {0}",
            //                  GetSumMore(1, 2, 3));
            //// name params

            //PrintInfo(zipCode: 15147, name: "Bart");

            //===========================
            // method overloading
            //===========================

            //Console.WriteLine("5.0 + 4.5 = {0}", 
            //                  GetSum(5.0, 4.5));

            //Console.WriteLine("4 + 5 = {0}",
            //                  GetSum(4, 5));

            //Console.WriteLine("4 + 5 = {0}",
            //GetSum("4", "5"));

            //===========================
            // Enum
            //===========================

            //CarColor car1 = CarColor.Blue;
            //PaintCar(car1);

            //Console.ReadLine(); 
        }
        //===========================
        // Pass-Value
        //===========================

        //static double GetSum(double x = 1, double y = 1)
        //{
        //    double temp = x;
        //    x = y;
        //    y = temp;

        //    return x + y;
        //}

        //===========================
        // Ref-Value
        //===========================

        //static void DoubleIt(int x, out int solution)
        //{
        //    solution = x * 2;
        //}

        //public static void Swap(ref int num1, ref int num2)
        //{
        //    int temp = num1;
        //    num1 = num2;
        //    num2 = temp;
        //}

        //===========================
        // Params
        //===========================

        //static double GetSumMore(params double[] nums)
        //{
        //    double sum = 0;
        //    foreach (int i in nums)
        //    {
        //        sum += i;
        //    }

        //    return sum;
        //}

        //// name params

        //static void PrintInfo(string name, int zipCode)
        //{
        //    Console.WriteLine("{0} lives in the zip code{1}", name, zipCode);
        //}

        //===========================
        // method overloading
        //===========================

        //static double GetSum(double x = 1, double y = 1)
        //{
        //    return x + y;
        //}

        //static double GetSum(string x = "1", string y = "1")
        //{
        //    double dblX = Convert.ToDouble(x);
        //    double dblY = Convert.ToDouble(y);
        //    return dblX + dblY;
        //}

        //===========================
        // Enum
        //===========================

        //enum CarColor : byte
        //{
        //    Orange = 1,
        //    Blue,
        //    Green,
        //    Red,
        //    Yellow
        //}

        //static void PaintCar(CarColor cc)
        //{
        //    Console.WriteLine("The Car was painted {0} with the code {1}", 
        //                      cc, (int)cc);
        //}
    }
}

