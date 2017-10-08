using System;

using System.Numerics;


namespace string_builder
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool canIVote = true;
            //         decimal decPiVal = 3.1415926M;
            //         decimal decBigNum = 3.0000000000000000000000000011m;

            //         double dblNumSample = 4000342323;

            //         float fltValue = 5.64543F;
            //float fltTooLong = 5.00000000021F;


            //Console.WriteLine("DEC : PI + bigNum = {0}", decPiVal + decBigNum);
            //         Console.WriteLine(" DBL = {0} ", dblNumSample);

            //Console.WriteLine("Biggest and Smallest integers: {0}, {1}", int.MaxValue, int.MinValue);
            //// 64 bit
            //Console.WriteLine("Biggest and Smallest long: {0}, {1}", long.MaxValue, long.MinValue);
            //// 128bit for the decimals and accurate to 28 digits
            //Console.WriteLine("Biggest and Smallest Dec: {0}, {1}", Decimal.MaxValue, Decimal.MinValue);
            //// 64 bit for the double
            //Console.WriteLine("Biggest and Smallest DBL: {0}, {1}", Double.MaxValue.ToString("#"), Double.MinValue);

            //Console.WriteLine("Biggest Float and test up to 6 digits: {0}, {1}", float.MaxValue.ToString("#"), fltValue + fltTooLong);

            //Other Data Types 
            // byte : 8-bit unsigned int 0 to 255
            // char : 16-bit unicode charachter
            // sbyte : 8-bit signed int 128 to 127
            // short : 16-bit signed int -32,768 to 32,767
            // uint : 32-bit unsigned int 0 to 4,294,967,295
            // ulong : 64-bit unsigned int 0 to 18,446,744,073,709,551,615
            // ushort : 16-bit unsigned int 0 to 65,535

            ///////////////////////////////
            //Console.WriteLine("Hello World!");

            //for (int i = 0; i < args.Length; i++)
            //{
            //    Console.WriteLine("Args {0} : {1}", i, args[i]);
            //}

            //string[] myArgs = Environment.GetCommandLineArgs();

            //Console.WriteLine(string.Join(", ", myArgs));

            //SayHello();
            ////////////////////////////////
            //bool boolFromStr = bool.Parse("true");
            //int intFromStr = int.Parse("100");
            //double dblFromString = double.Parse("1.234");
            //////////// DateTime

            //DateTime awesomeDate = new DateTime(1993, 02, 05);
            //Console.WriteLine("Day of week: {0}", awesomeDate.DayOfWeek);

            ////awesomeDate = awesomeDate.AddDays(4);
            ////awesomeDate = awesomeDate.AddMonths(1);
            ////awesomeDate = awesomeDate.AddYears(1);

            //Console.WriteLine("New Date: {0}", awesomeDate.Date);

            //TimeSpan lunchTime = new TimeSpan(12, 30, 0);
            //lunchTime = lunchTime.Subtract(new TimeSpan(0, 15, 0));
            //lunchTime = lunchTime.Add(new TimeSpan(1, 0, 0));

            //Console.WriteLine("New Time: {0}", lunchTime.ToString());

            //BigInteger bigNum = BigInteger.Parse("12345678912345678903456");
            //Console.WriteLine("Big Num * 2 = {0}", bigNum * 2);

            //Console.WriteLine("Currency: {0:c}", 23.455);
            //Console.WriteLine("padding: {0:d4}", 23);
            //Console.WriteLine("3 decimals: {0:f3}", 23.4554);
            //Console.WriteLine("Commas: {0:n4}", 2300);

            string randString = "  This is a String  ";
            Console.WriteLine("String Length: {0}", randString.Length);
            Console.WriteLine("String Contains 'is': {0}", 
                              randString.Contains("is"));
            Console.WriteLine("Index of is: {0}", 
                              randString.IndexOf("is"));
			Console.WriteLine("Remove: {0}",
                              randString.Remove(0, 4));
			Console.WriteLine("Insert: {0}",
                              randString.Insert(10, "a short "));
			Console.WriteLine("Replace String: {0}",
                              randString.Replace("string", "sentence"));
			Console.WriteLine("Compare a to b: {0}",
                              String.Compare("a", "b", StringComparison.OrdinalIgnoreCase));
			Console.WriteLine("Compare A = a: {0}",
                              String.Equals("A", "a", StringComparison.OrdinalIgnoreCase));
			Console.WriteLine("Pad left: {0}",
                              randString.PadLeft(20, '.'));
			Console.WriteLine("Pad right: {0}",
							  randString.PadRight(20, '.'));
			Console.WriteLine("Trim: {0}",
							  randString.Trim());
			Console.WriteLine("Uppercase: {0}",
                              randString.ToUpper());
			Console.WriteLine("Lowercase: {0}",
                              randString.ToLower());

            string newString = String.Format("\\ \a {0} saw a {1} {2} in the {3}",
                                             "Jennifer", "rabbit", "eating", "field");
            Console.Write(@"Exactly What I Typed ' \  {0}", newString);

			Console.ReadLine();
		}

        private static void SayHello()
        {
            string name = "";
            Console.Write("What is your name? : ");
            name = Console.ReadLine();
            Console.WriteLine("Welcome {0}", name);
        }
    }
}
