using System;
namespace ConsoleApp38
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Skriv sidolängden på triangeln");
            int side = int.Parse(Console.ReadLine());

            for (int i = 0; i < side; i++) 
            {

                for (int j = 0; j <= i; j++) 
                {
                    Console.Write("*");
                }

                if (i != side - 1) 
                {
                    Console.WriteLine();
                }
            }
        }
    }
}