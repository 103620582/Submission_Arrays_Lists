using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("G'day! Please enter a number.");
            string input1 = Console.ReadLine();
            int num1 = int.Parse(input1);

            Console.WriteLine("Please enter another number.");
            string input2 = Console.ReadLine();
            int num2 = int.Parse(input2);

            Console.WriteLine("Aaand another one.");
            string input3 = Console.ReadLine();
            int num3 = int.Parse(input3);

            Console.WriteLine("Yeppp and another.");
            string input4 = Console.ReadLine();
            int num4 = int.Parse(input4);

            Console.WriteLine("Go on, do one more.");
            string input5 = Console.ReadLine();
            int num5 = int.Parse(input5);

            Console.WriteLine("Lucky last one...");
            string input6 = Console.ReadLine();
            int num6 = int.Parse(input6);

            
            List<int> numbers = new List<int>();
            numbers.Add(num1);
            numbers.Add(num2);
            numbers.Add(num3);
            numbers.Add(num4);
            numbers.Add(num5);
            numbers.Add(num6);

            if (num1 == num6) {
                Console.WriteLine("Hey, this number matches the first number!");
            }
                else {
                Console.Write("");
                }

            if (num2 == num6) {
                Console.WriteLine("Hey, this number matches the second number!");
            }
                else {
                Console.Write("");
                }

            if (num3 == num6) {
                Console.WriteLine("Hey, this number matches the third number!");
            }
                else {
                Console.Write("");
                }
            
            if (num4 == num6) {
                Console.WriteLine("Hey, this number matches the fourth one!");
            }
                else {
                Console.Write("");
                }
            if (num5 == num6) {
                Console.WriteLine("Hey, this number matches the fifth one!");
            }
                else {
                Console.Write("");
                }
            
            Console.WriteLine(" ");
            Console.WriteLine("Alright, you can bugger off now...");


            
            
        }
    }
}
