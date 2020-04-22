using System;

namespace Day_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int exitProg = 0;
            do
            {
                Console.WriteLine("Choose an exercise to run:");
                Console.WriteLine("1) Echo some text");
                Console.WriteLine("2) Enter a number, get +1 back");
                Console.WriteLine("3) Enter a number, get +0.5 back");
                Console.WriteLine("4) Enter two numbers, output the sum");
                Console.WriteLine("5) Enter two numbers, output the product");
                Console.WriteLine("6) Exit");
                Console.Write("Make a selection: ");
                exitProg = int.Parse(Console.ReadLine());
                switch (exitProg)
                {
                    case 1:
                        exercise1();
                        break;
                    case 2:
                        exercise2();
                        break;
                    case 3:
                        exercise3();
                        break;
                    case 4:
                        exercise4();
                        break;
                    case 5:
                        exercise5();
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("\nInvalid Choice\n");
                        break;
                }
            }
            while (exitProg != 6);
        }

        public static void exercise1()
        {
            string sample;
            Console.WriteLine("Enter a string:");
            sample = Console.ReadLine();
            Console.WriteLine(sample);
        }

        public static void exercise2()
        {
            Console.WriteLine("Enter a number: ");
            bool goodnum = int.TryParse(Console.ReadLine(), out int usernum);
            if (goodnum)
            {
                usernum++;
                Console.WriteLine(usernum);
            }
            else
            {
                Console.Write("Invalid number. Try again with a valid integer. ");
                exercise2();
            }
            
        }

        public static void exercise3()
        {
            double usernum;

            Console.WriteLine("Enter a number: ");
            bool goodnum = double.TryParse(Console.ReadLine(), out usernum);
            if (goodnum)
            {
                usernum = usernum + 0.5;
                Console.WriteLine(usernum);
            }
            else
            {
                Console.Write("Invalid number. Try again with a valid number. ");
                exercise3();
            }
        }

        public static void exercise4()
        {
            double userNum1 = 0;
            double userNum2 = 0;
            bool goodNum1 = false;
            bool goodNum2 = false;
            while (goodNum1 == false)
            {
                Console.WriteLine("Enter a number:");
                goodNum1 = double.TryParse(Console.ReadLine(), out userNum1);
                if (goodNum1 == false)
                {
                    Console.Write("Invalid number.  Try again. ");
                }
            }
            while (goodNum2 == false)
            {
                Console.WriteLine("Enter another number: ");
                goodNum2 = double.TryParse(Console.ReadLine(), out userNum2);
                if (goodNum2 == false)
                {
                    Console.Write("Invalid number.  Try again. ");
                }
            }

            Console.WriteLine($"The sum is {userNum1 + userNum2}.");
        }

        public static void exercise5()
        {
            double userNum1 = 0;
            double userNum2 = 0;
            bool goodNum1 = false;
            bool goodNum2 = false;
            while (goodNum1 == false)
            {
                Console.WriteLine("Enter a number:");
                goodNum1 = double.TryParse(Console.ReadLine(), out userNum1);
                if (goodNum1 == false)
                {
                    Console.Write("Invalid number.  Try again. ");
                }
            }
            while (goodNum2 == false)
            {
                Console.WriteLine("Enter another number:");
                goodNum2 = double.TryParse(Console.ReadLine(), out userNum2);
                if (goodNum2 == false)
                {
                    Console.Write("Invalid number.  Try again. ");
                }
            }

            Console.WriteLine($"The product is {userNum1 * userNum2}.");
        }
    }

}


