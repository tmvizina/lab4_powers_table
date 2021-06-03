using System;

namespace Lab4_Powers_Table
{
    
    class Program
    {
        static void Main(string[] args)
        {
            bool goOn = true;

            while (goOn==true)
            {

                int userInput = GetUserInput("Please enter an Integer ");


                bool rightvalue = RangeCheck(1, 1291, userInput);

                if (rightvalue == true)
                {
                    int square;

                    int cube;



                    Console.WriteLine("\t  Powers Table");
                    for (int i = 1; i <= userInput; i++)

                    {
                        square = (int)Math.Pow(i, 2);


                        cube = (int)Math.Pow(i, 3);

                        Console.WriteLine("\t" + cube + "\t" + square);

                    }

                    Console.WriteLine("Would you like to continue (y/n)?");
                    string usercont = Console.ReadLine();

                    if (usercont != "y")
                    {
                        goOn = false;
                    }

                }
                else
                {
                    Console.WriteLine("That input was invalid");
                    Console.WriteLine("Would you like to continue (y/n)?");
                    string usercont1 = Console.ReadLine();

                    if (usercont1 != "y")
                    {
                        goOn = false;
                    }
                }


            }
        }



        public static int GetUserInput(string message)
        {
            
            
                Console.WriteLine(message);

                int input = int.Parse(Console.ReadLine());

                return input;
            
        }


        public static bool RangeCheck(int min, int max, int numToCheck)
        {
            if (numToCheck > min && numToCheck <= max)
            {
                return true;

            }
            else
            {
                return false;
            }
        }


 
    }




}
