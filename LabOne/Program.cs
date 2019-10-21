using System;

namespace LabOne
{
    class Program
    {
        static void Main(string[] args)

        {
            // string name;
            // int length;
            // int width;
            // Console.WriteLine("Please enter your name.");
            // name = Console.WriteLine();
            // Console.WriteLine($"Welcome {name} please input your data.");

            string name;

            double length;

            double width;


            Console.Write("Please enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine($"Welcome {name} please input your data.");

            Start:

            Console.Write("Please enter your length: ");

            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Please enter your width: ");

            width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();


            Console.WriteLine();


            //Show the details that the user entered

            Console.WriteLine($"Hello again {name} here are your results!");

            Console.WriteLine($"The area of the room is {length * width}.");

            Console.WriteLine($"The perimiter of the room is {2 * length + 2 * width}.");

            Start2:

            Console.WriteLine("Would you like to continue? Press (Y/N).");

            ConsoleKey answer;

            answer = Console.ReadKey(false).Key;

            if (answer != ConsoleKey.Y && answer != ConsoleKey.N)
            {
                Console.WriteLine("Incorrect answer");
                Console.ReadLine();
                goto Start2;
            }
            if (answer == ConsoleKey.N)
            {
                Console.WriteLine("Goodbye!");
            }
            if (answer == ConsoleKey.Y)
            {
                goto Start;
            }



        }


     }
}
