using System;

namespace Program_2b
// ISM 4300 Program #2b - Created by Brian Best
// This program gives the user what grade they will receive with their current score.
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user what score they got in thier course
            Console.WriteLine("What score do you currently have in the course?");

            // Use try catch to confirm valid input
            try
            {
                string inputdata = Console.ReadLine();
                int inputscore = int.Parse(inputdata);

                if (inputscore < 0 || inputscore > 100)
                {
                    Console.WriteLine("Please input a valid number between 0 and 100");
                    Console.WriteLine("Press any key to exit the program");
                    Console.ReadKey(true);
                }
                // Valid number responses
                if (inputscore >= 93)
                {
                    Console.WriteLine("You got the grade of A!");
                }
                else if (inputscore >= 90)
                {
                    Console.WriteLine("You got the grade of A-!");
                }
                else if (inputscore >= 87)
                {
                    Console.WriteLine("You got the grade of B+");
                }
                else if (inputscore >= 83)
                {
                    Console.WriteLine("You got the grade of B");
                }
                else if (inputscore >= 80)
                {
                    Console.WriteLine("You got the grade of B-");
                }
                else if (inputscore >= 77)
                {
                    Console.WriteLine("You got the grade of C+");
                }
                else if (inputscore >= 73)
                {
                    Console.WriteLine("You got the grade of C");
                }
                else if (inputscore >= 70)
                {
                    Console.WriteLine("You got the grade of C-");
                }
                else if (inputscore >= 67)
                {
                    Console.WriteLine("You got the grade of D+");
                }
                else if (inputscore >= 63)
                {
                    Console.WriteLine("You got the grade of D");
                }
                else if (inputscore >= 60)
                {
                    Console.WriteLine("You got the grade of D-");
                }
                else
                {
                    Console.WriteLine("You got the grade of F...");
                }

                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("Thank you for your score. I hope you got what you wanted!");
                Console.WriteLine("And if not, you can always do better.");
            }
            catch
            {
                Console.WriteLine("If you wish to see your new grade, please run again and enter your new Score!");
                Console.WriteLine("Press any key to exit the program.");
                Console.ReadKey(true);
            }
        }
    }
}
