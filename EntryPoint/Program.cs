using System;

namespace EntryPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program that knows how to give a remainder consisting of the largest notes
            Console.WriteLine("Welcome to Lidl");
            Console.Write("Enter the value of the voucher: ");
            double voucher = Convert.ToDouble(Console.ReadLine()); // 118.57
            Console.Write("Enter the money into the device: ");
            double moneyEntered = double.Parse(Console.ReadLine()); // 500
            double rest = moneyEntered - voucher;
            if (moneyEntered > voucher)
            {
                Console.WriteLine($"Your balance is : {rest} euros");
                while (rest >= 200)
                {
                    Console.Write("200_");
                    rest -= 200;
                }
                while (rest >= 100)
                {
                    Console.Write("100_");
                    rest -= 100;
                }
                while (rest >= 50)
                {
                    Console.Write("50_");
                    rest -= 50;
                }
                while (rest >= 20)
                {
                    Console.Write("20_");
                    rest -= 20;
                }
                while (rest >= 10)
                {
                    Console.Write("10_");
                    rest -= 10;
                }
                while (rest >= 5)
                {
                    Console.Write("5_");
                    rest -= 5;
                }
                while (rest >= 2)
                {
                    Console.Write("2_");
                    rest -= 2;
                }
                while (rest >= 1)
                {
                    Console.Write("1_");
                    rest -= 1;
                }
                while (rest >= 0.50)
                {
                    Console.Write("0.50_");
                    rest -= 0.50;
                }
                while (rest >= 0.10)
                {
                    Console.Write("0.10");
                    rest -= 0.10;
                }
            }
            else
            {
                Console.WriteLine($"Insufficient funds! You have {rest * -1} euros to enter");
            }
            Console.ReadKey();
        }
    }
}
