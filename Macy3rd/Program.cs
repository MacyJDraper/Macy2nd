using System;

namespace Macy3rd
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberExample = 0;

            //while
            //Will only run if true
            while (numberExample < 10)
            {
                Console.WriteLine("hey");
                numberExample = numberExample + 1;
                //Other ways to write
                //numberExample++;
                //numberExample += 1;
            }
            int numberForDoWhileLoop = 0;
            // do-while
            // will run once with out checking
            do
            {
                Console.WriteLine("hello");
            } while (numberForDoWhileLoop < 0);

            // for
            //Will only run if true

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("yo");
            }

            


        }
    }
}
