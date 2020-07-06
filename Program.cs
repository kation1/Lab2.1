using System;

namespace Lab2._1
{
    class Program
    {
        static void CalculateRoomSize()
        {
            string userAgree = "Y";
            Console.WriteLine("Running Room Calculator");
            while (userAgree == "Y")
            {
                //prompts for length and width
                Console.WriteLine("Enter Length: ");
                double length = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Width: ");
                double width = double.Parse(Console.ReadLine());

                double area = (length * width);
                double perimeter = ((length * 2) + (width * 2));
                //display area and perimeter
                Console.WriteLine($"The area is {area}.");
                Console.WriteLine($"The perimeter is {perimeter}.");

                //Tells if room is small or large

                if (area >= 650)
                {
                    Console.WriteLine("This room is large.");
                }
                else if (area > 250)
                {
                    Console.WriteLine("This room is medium.");
                }
                else
                {
                    Console.WriteLine("This room is small.");
                }
                //prompt user to continue
                Console.WriteLine("Do you want to run again? (Y/N)");
                userAgree = Console.ReadLine();
            }

            Console.WriteLine("Thank you for using the Room Detail Generator");
        }

        static void Main(string[] args)
        {



            CalculateRoomSize();

        }
    }
}

