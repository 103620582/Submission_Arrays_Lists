using System;

namespace Arrays_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int [] numbers = new int [10];

            numbers [0] = 34;
            numbers [1] = 5;
            numbers [2] = 67;
            numbers [3] = 1;
            numbers [4] = 99;
            numbers [5] = 34;
            numbers [6] = 44;
            numbers [7] = 78;
            numbers [8] = 34;
            numbers [9] = 0;

            int total = 0;

            for (int index = 0; index < numbers.Length; index = index + 1) {
                Console.WriteLine(numbers[index] + total);

                total += numbers[index];

            
            }
            
          

        }
    }
}
