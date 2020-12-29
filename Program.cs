using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicNumberGuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Please choose difficulty: Easy Medium Hard");
            string difficultySelection = Console.ReadLine().ToLower();
            for (; ; )
            {
                if (difficultySelection == "easy")
                {
                    int numbercomputer = random.Next(1, 10);
                    byte rights = 6;
                    for (; ; )
                    {
                        Console.WriteLine("Guess between 1-10");
                        int numberuser = Convert.ToInt32(Console.ReadLine());

                        if (numberuser == numbercomputer)
                        {
                            Console.WriteLine("You guess right keep on playing again");
                            break;
                        }
                        else
                        {
                            rights--;
                            Console.WriteLine("You have {0} rights", rights);
                            if (rights == 0)
                            {
                                Console.WriteLine("You use all rights but you can try again");
                                break;
                            }
                        }
                    }

                }
                else if (difficultySelection == "medium")
                {
                    int numbercomputer = random.Next(1,25);
                    byte rights = 8;
                    for (; ; )
                    {
                        Console.WriteLine("Guess between 1-25");
                        int numberuser = Convert.ToInt32(Console.ReadLine());

                        if (numberuser == numbercomputer)
                        {
                            Console.WriteLine("You guess right keep on playing again");
                            break;
                        }
                        else
                        {
                            rights--;
                            Console.WriteLine("You have {0} rights", rights);
                            if (rights == 0)
                            {
                                Console.WriteLine("You use all rights but you can try again");
                                break;
                            }
                        }
                    }
                }
                else if (difficultySelection == "hard")
                {
                    int numbercomputer = random.Next(1,50);
                    byte rights = 6;
                    for (; ; )
                    {
                        Console.WriteLine("Guess between 1-50");
                        int numberuser = Convert.ToInt32(Console.ReadLine());

                        if (numberuser == numbercomputer)
                        {
                            Console.WriteLine("You guess right keep on playing again");
                            break;
                        }
                        else
                        {
                            rights--;
                            Console.WriteLine("You have {0} rights", rights);
                            if (rights == 0)
                            {
                                Console.WriteLine("You use all rights but you can try again");
                                break;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("You can only use one of them : Easy Medium Hard");
                    Console.ReadLine();
                    break;
                }
            }
        }
    }
}
