using System;

namespace Deliverable1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string restart = "yes";
            while (restart == "yes" || restart == "y")

            {
                Console.WriteLine("\nHow many people are we making PB and J sandwiches for?");
                int people = int.Parse(Console.ReadLine());

                Console.WriteLine("\nyou need:\n");

                double b = people * 2;
                double pb = people * 2;
                double j = people * 4;

                Console.WriteLine(b.ToString() + " slices of bread");
                Console.WriteLine(pb.ToString() + " tablespoons of peanut butter");
                Console.WriteLine(j.ToString() + " teaspoons of jelly");

                Console.WriteLine("\nwhich is...\n");

                double b2 = Math.Ceiling(b / 28);
                double pb2 = Math.Ceiling(pb / 32);
                double j2 = Math.Ceiling(j / 48);

                Console.WriteLine(b2.ToString() + " loaves of bread");
                Console.WriteLine(pb2.ToString() + " jars of peanut butter");
                Console.WriteLine(j2.ToString() + " jars of jelly");

                Console.WriteLine("\nWould you like to restart? Enter yes or y to continue, or enter any other key to exit");
                restart = Console.ReadLine();
            }
            {
                Console.WriteLine("\nGoodbye!");
            }
        }
    }
}