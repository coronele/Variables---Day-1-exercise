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
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
            while (exitProg != 6);
        }

        public static void exercise1()
        {
            string sample;
            Console.WriteLine("Enter a string");
            sample = Console.ReadLine();
            Console.WriteLine(sample);
        }

        public static void exercise2()
        {
            int usernum;
            Console.WriteLine("Enter a number");
            usernum = int.Parse(Console.ReadLine());
            usernum++;
            Console.WriteLine(usernum);
        }

        public static void exercise3()
        {
            double usernum;
            Console.WriteLine("Enter a number");
            usernum = double.Parse(Console.ReadLine());
            usernum = usernum + 0.5;
            Console.WriteLine(usernum);
        }

        public static void exercise4()
        {
            double usernum1, usernum2;
            Console.WriteLine("Enter a number:");
            usernum1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number:");
            usernum2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"The sum is {usernum1 + usernum2}");
        }

        public static void exercise5()
        {
            double usernum1, usernum2;
            Console.WriteLine("Enter a number:");
            usernum1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number:");
            usernum2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"The product is {usernum1 * usernum2}");
        }

    }

}
