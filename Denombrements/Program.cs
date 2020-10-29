using System;

namespace Denombrements
{
    class Program
    {

        public static int ShowElement()
        {
            Console.Write("Total number of elements to be managed = ");
            int n = int.Parse(Console.ReadLine());
            return n;
        }

        public static int ShowSubElement()
        {
            Console.Write("Number of elements in the subassy = ");
            int n = int.Parse(Console.ReadLine());
            return n;
        }

        public static long Permutation(int n)
        {
            long r = 1;
            for (int k = 1; k <= n; k++)
                r *= k;
            return r;
        }

        public static long Arrangement(int t, int n)
        {
            long r = 1;
            for (int k = (t - n + 1); k <= t; k++)
                r *= k;
            return r;
        }
        static void Main(string[] args)
        {
            char choice = '1';
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
                        // number of elements selection
                        int n1 = ShowElement();
                        // permutation calculation
                        long rPermutation = Permutation(n1);
                        Console.WriteLine(n1 + "! = " + rPermutation);
                        break;
                    case '2':
                        // number of elements selection
                        int t2 = ShowElement();
                        // number of elements in the subassy
                        int n2 = ShowSubElement();
                        // Arrangement calculation
                        long rArrangement = Arrangement(t2, n2);
                        //Console.WriteLine("result = " + (r1 / r2));
                        Console.WriteLine("A(" + t2 + "/" + n2 + ") = " + rArrangement);
                        break;
                    case '3':
                        // number of elements selection
                        int t3 = ShowSubElement();
                        // number of elements in the subassy
                        int n3 = ShowSubElement();
                        // Arrangement calculation
                        long r1 = Arrangement(t3, n3);
                        // permutation calculation 
                        long r2 = Permutation(n3);
                        // combination calculation
                        //Console.WriteLine("result " + (r1 / r2));
                        Console.WriteLine("C(" + t3 + "/" + n3 + ") = " + (r1 / r2));
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
