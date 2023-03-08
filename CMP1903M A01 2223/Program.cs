using System;
namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args){

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("|          Start of test             |");
            Console.WriteLine("--------------------------------------\n\n");

            /*We run the Method that contains the instructions to test out our classes.*/
            Testing.MethodTests();
            
            Console.WriteLine("\n\n--------------------------------------");
            Console.WriteLine("|            End of test             |");
            Console.WriteLine("--------------------------------------");

            /*We then pause the program by waiting for an input so we can 
             * observe the output of the method we called above         */
            Console.ReadLine();
        }

    }
}

