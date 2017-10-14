using System;

namespace conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            //Relation Operations: > < >= <= == !=
            //Logical Operators: && || !

            //int age = 17;

            //if ((age > 4) && (age < 8))
            //{
            //    Console.WriteLine("Go to Elementary School");
            //} else if ((age > 7) && (age < 13))
            //{
            //    Console.WriteLine("Go to Middle School");
            //} else if ((age > 13) && (age < 19))
            //{
            //    Console.WriteLine("Go to High School");
            //} else 
            //{
            //    Console.WriteLine("Go to College");
            //}

            //if ((age < 14) || (age < 19))
            //{
            //    Console.WriteLine("You should work illegally without a contract");
            //}


            //Console.WriteLine("! true = " + (!true));

            //===============================
            //===============================

            //    int age = 17;

            //    bool canDrive = age >= 16 ? true : false;

            //    Console.WriteLine(canDrive);

            //    switch (age)
            //    {
            //        case 2:
            //            Console.WriteLine("Go to Day Care");
            //            break;
            //        case 4:
            //            Console.WriteLine("Go to Preschool");
            //            break;
            //        case 5:
            //            Console.WriteLine("Go to Kindergarten");
            //            break;
            //        default:
            //            Console.WriteLine("this is the default!");
            //            goto OtherSchool; //bad practice
            //    }

            //OtherSchool:
            //Console.WriteLine("!true " + (!true));
            ////Console.WriteLine(" Elementary, Middle, HighSchool "); \

            //string name = "Derek";
            //string name2 = "Derek";

            //if (name.Equals(name2, StringComparison.Ordinal)) 
            //{
            //    Console.WriteLine("Names are Equal.");
            //}

            //===============================
            //===============================

            //int i = 1;

            //while(i <= 10)
            //{
            //    if(i % 2 == 0) 
            //    {
            //        i++;
            //        continue; 
            //    }

            //    if (i == 9) break;

            //    Console.WriteLine(i);
            //    i++;
            //}

            //===============================
            //===============================

            //Random rnd = new Random();
            //int secretNumber = rnd.Next(1, 11);
            //int numberGuessed = 0;

            //do
            //{
            //    Console.WriteLine("Enter a number between 1 & 10: ");
            //    numberGuessed = Convert.ToInt32(Console.ReadLine());

            //} while (secretNumber != numberGuessed);

            //Console.WriteLine("You guessed it!");

            //===============================
            //===============================

            double num1 = 5;
            double num2 = 0;

            try
            {
                Console.WriteLine("5 / 0 = {0}",
                                  DoDivision(num1, num2));
            }
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("You can't divide by zero");
            //    Console.WriteLine(ex.GetType().Name);
            //    Console.WriteLine(ex.Message);
            //}

            catch (Exception ex)
            {
                Console.WriteLine("An error occured...");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.WriteLine("Cleaning Up");
            }


            Console.ReadLine();

        }
        static double DoDivision(double x, double y)
        {
            if (y == 0) {
                throw new System.DivideByZeroException();
            }
            return (x / y);
        }
    }
}
