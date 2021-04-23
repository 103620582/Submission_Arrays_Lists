using System;

namespace ListsArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            string [] names = new string [5];

            Console.WriteLine("G'day! Please enter 5 names.");
            names [0] = Console.ReadLine();
            names [1] = Console.ReadLine();
            names [2] = Console.ReadLine();
            names [3] = Console.ReadLine();
            names [4] = Console.ReadLine();

            foreach (string NameEntry in names)
            Console.WriteLine("Cheers " + NameEntry);

            
            
        
            


        

        }
    }
}
