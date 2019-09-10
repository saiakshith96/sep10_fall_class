using System;

namespace sep10_fall_class
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("How many years of experience do you have?");
                int a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 0:
                        Console.WriteLine("Needs lot of practise");
                        break;

                    case 1:
                        Console.WriteLine("Looks like you have a littler expereince");
                        break;

                    case 2:
                        Console.WriteLine("WOW! You have been doing this for a little while");
                        break;

                    default:
                        Console.WriteLine("You are an expert");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Enter an integer and try again");
            }
        }
    }
}
