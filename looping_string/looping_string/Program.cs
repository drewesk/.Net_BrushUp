using System;

using System.Text;

using System.Globalization;

namespace looping_string
{
    class Program
    {
        static void Main(string[] args)
        {
            //var intVal = 1234;

            //Console.WriteLine("intVal type: {0}", 
            //intVal.GetType());

            ////////////

            //         int[] favoriteNums = new int[3];

            //         favoriteNums[0] = 23;

            //         Console.WriteLine("faveNum 0 : {0}",
            //                           favoriteNums[0]);

            //         string[] customers = { "Bob", "Sally", "Sue" };

            //         var employees = new[] { "Mike", "Paul", "Rick" };

            //         object[] randomArray = { "Paul", 45, 1.234 };


            //         Console.WriteLine("randomArray 0 {0}",
            //                           randomArray[0].GetType());

            //Console.WriteLine("ArraySize {0}",
            //                  randomArray.Length);

            //for (int i = 0; i < randomArray.Length; i++)
            //{
            //    Console.WriteLine("Array: {0} Value: {1}",
            //                      i, randomArray[i]);
            //}
            //////////

            //         string[,] custNames = new string[2, 2] {{"Bob",
            //                 "Smith"}, {"Sally", "Marks"}};
            //         Console.WriteLine("custNames {0}",
            //                          custNames.GetValue(1, 1));
            //         for (int i = 0; i < custNames.GetLength(0); i++)
            //         {
            //             for (int j = 0; j < custNames.GetLength(1); j++)
            //             {
            //                 Console.WriteLine("{0}",
            //                                   custNames[i, j]);
            //             }

            //         }

            //         //arrNames[2, 2, 3];

            //         int[] randomNums = { 1, 4, 9, 2 };

            //         Array.Sort(randomNums,(x, y) => y.CompareTo(x)); // ascending

            //         Array.Reverse(randomNums);


            //PrintArray(randomNums, "A generic message");

            //randomNums.SetValue(0, 1);

            //Console.WriteLine("1 at index: {0}",
            //                  Array.IndexOf(randomNums, 1));
            //int[] srcArray = { 1, 2, 3 };
            //int[] destArray = new int[2];
            //int StartingIndex = 0;
            //int length = 2;

            //Array.Copy(srcArray, StartingIndex, destArray, StartingIndex, length);

            //PrintArray(destArray, "Copy ");

            //Array anotherArray = Array.CreateInstance(typeof(int), 10);

            //srcArray.CopyTo(anotherArray, 5);

            //foreach(int m in anotherArray)
            //{
            //    Console.WriteLine("CopyTo: {0}", m);
            //}

            //int[] numArray = { 1, 11, 22, 5, 8 };
            //Console.WriteLine("> 10: {0}",
            //Array.Find(numArray, GT10));

            ////////// String Builder

            //         StringBuilder sb = new StringBuilder("Random Text");

            //         StringBuilder sb2 = new StringBuilder("More Stuff that is Important", 256);

            //         Console.WriteLine("Capacity: {0}", sb.Capacity);
            //Console.WriteLine("Capacity: {0}", sb2.Capacity);

            //Console.WriteLine("length: {0}", sb.Length);

            //sb2.AppendLine("\nMore important text");

            //CultureInfo enUS = CultureInfo.CreateSpecificCulture("en-US");

            //string bestCustomer = "Bob Smith";
            //sb2.AppendFormat(enUS, "Best Customer: {0}",
            //                bestCustomer);

            //Console.WriteLine(sb2.ToString());

            //sb2.Replace("text", "characters");

            //sb2.Clear();

            //sb2.Append("Random Text");

            //Console.WriteLine(sb.Equals(sb2));

            //sb2.Insert(11, "; an added string for the builder");

            //Console.WriteLine(sb2.ToString());

            //sb2.Remove(12, 9);

            //Console.WriteLine(sb2.ToString());

            //////// Casting or Conversion

            long num1 = 1234;
            int num2 = (int)num1;

            Console.WriteLine("Cast long to int orig: {0} cast: {1}", num1.GetType(), num2.GetType());

			Console.ReadLine();

        }
        static void PrintArray(int[] intArray, string message)
        {
            foreach (int k in intArray)
            {
                Console.WriteLine("Value: {0} Message: {1}", k, message);
            }
        }

        private static bool GT10(int val) 
        {
            return val > 10;
        }
    }
}
