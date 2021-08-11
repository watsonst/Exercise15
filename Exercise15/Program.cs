using System;

namespace Exercise14
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "";


            do
            {

                Console.Write("Enter a number: ");
                int input = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= input ; i++)
                {
                    
                   int cube = (int)Math.Pow(i, 3);
                   Console.Write($"{cube} ");
                }
      
                Console.Write("\nWould you like to continue? y/n: ");
                answer = Console.ReadLine();
                if (answer == "n")
                {
                    Console.WriteLine("Goodbye!");
                }

            }
            while (answer == "y");
        }

    }
}