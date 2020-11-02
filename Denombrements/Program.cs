
/**
 * title : counting calculation
 * goal : allows 3 types of calculation : permutation, arrangement, counting
 * author : Mathieu Seligmann
 * creation date : October, 29th 2020
 * Last update : November, 2nd 2020
 * */
using System;

namespace Denombrements
{
    class Program
    {
        ///
        /// <summary>
        /// Multiplication calculation of many consecutive integers, from startValue to endValue
        /// </summary>
        /// <param name="startValue">starting value for the calculation</param>
        /// <param name="endValue">ending value for the calculation</param>
        /// <returns>result of the multiplication</returns>
        static long IntMultiplication(int startValue, int endValue)
        {
            long multiplication = 1;
            for (int k = startValue; k <= endValue; k++)
                multiplication *= k;
            return multiplication;
        }

        ///
        /// <summary>
        /// User selection control
        /// </summary>
        /// <param name="message"></param>
        /// <returns>integer selected by user</returns>
        static int UserSelection(String message)
            {
                int number = 0;
                Console.Write(message);
                try
                {
                    number = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                }

                catch
                {
                    Console.WriteLine();
                    Console.WriteLine("Wrong input, enter an integer");
                }

                return number;

            }

        ///
        /// <summary>
        /// Menu allowing to make 3 choices : permutation, arrangement, combination
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            char choice = '1';
            int nbrSubAssy = 0;
            int totalNumber = 0;
            long arrangement = 0;
            while (choice != '0')
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combination ...................... 3");
                Console.WriteLine("Quit ............................. 0");
                Console.Write("Choice :                           ");
                choice = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch(choice)
                {  
                    case '0':
                        Environment.Exit(0);
                        break;
                    case '1':
                        totalNumber = UserSelection("Total number of elements to be taken into account");
                        long permutation = IntMultiplication(1, totalNumber);
                        Console.WriteLine(totalNumber + "! = " + permutation);
                        break;
                    case '2':
                        nbrSubAssy = UserSelection("Total number of elements in the subassy to be taken into account");
                        arrangement = IntMultiplication(totalNumber - nbrSubAssy + 1, totalNumber);
                        Console.WriteLine("A(" + totalNumber + "/" + nbrSubAssy + ") = " + arrangement);
                        break;
                    case '3':
                        long combination = arrangement / IntMultiplication(1, nbrSubAssy);
                        Console.WriteLine("C(" + totalNumber + "/" + nbrSubAssy + ") = " + combination);
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
