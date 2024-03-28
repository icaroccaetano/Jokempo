using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Constants
    {
        public const int Rock = 1;
        public const int Paper = 2;
        public const int Scissors = 3;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int p1, p2;

            Console.WriteLine("Rock, Paper and Scissors!");
            
            p1_play:
            Console.WriteLine("P1 Play:");
            Console.Write("1 - Rock\n2 - Paper\n3 - Scissors\n");
            p1 = int.Parse(Console.ReadLine());
            if (p1 != 1 && p1 != 2 && p1 != 3) 
            {
                Console.WriteLine("ERROR: Invalid input");
                goto p1_play;
            }

            p2_play:
            Console.WriteLine("P2 Play:");
            Console.Write("1 - Rock\n2 - Paper\n3 - Scissors\n");
            p2 = int.Parse(Console.ReadLine());
            if (p2 != 1 && p2 != 2 && p2 != 3)
            {
                Console.WriteLine("ERROR: Invalid input");
                goto p2_play;
            }

            result (p1, p2);
        }

        static void result (int play1, int play2)
        {
            switch (play1) 
            {
                case Constants.Rock:
                    switch (play2) 
                    {
                        case Constants.Rock:
                            Console.WriteLine("Draw");
                            break;
                        case Constants.Paper:
                            Console.WriteLine("P2 wins");
                            break;
                        case Constants.Scissors:
                            Console.WriteLine("P1 wins");
                            break;
                    }
                    break;
                case Constants.Paper:
                    switch (play2)
                    {
                        case Constants.Rock:
                            Console.WriteLine("P1 wins");
                            break;
                        case Constants.Paper:
                            Console.WriteLine("Draw");
                            break;
                        case Constants.Scissors:
                            Console.WriteLine("P2 wins");
                            break;
                    }
                    break;
                case Constants.Scissors:
                    switch (play2)
                    {
                        case Constants.Rock:
                            Console.WriteLine("P2 wins");
                            break;
                        case Constants.Paper:
                            Console.WriteLine("P1 wins");
                            break;
                        case Constants.Scissors:
                            Console.WriteLine("Draw");
                            break;
                    }
                    break;

            }

        }
    }
}