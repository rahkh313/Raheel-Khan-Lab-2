using System;

namespace Raheel_Khan_Lab_Number_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus’ Room Detail Generator!\n");
            //string answerLength;
            //string answerWidth;
            double length;
            double width;
            int i = 0;

            string answer;
            do 
            {
                
                Console.WriteLine("Enter Length:");
                length = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Width:");
                width = double.Parse(Console.ReadLine());
                Console.WriteLine("Area: " + (length * width));

                Console.WriteLine("Permiter: " + (2*length) + (2*width) );
                Console.WriteLine("Continue?(y/n):");
                answer = Console.ReadLine();


                if (answer == "y" || answer == "Y")
                {
                    i = 0;
                }
                else
                {
                    i = 1;
                }

            } while (i == 0);

            return;

       


        }
    }
}
