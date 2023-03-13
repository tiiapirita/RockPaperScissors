using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool again = true;
            int player;


            while (again)
            {
                Console.WriteLine("Rock-Paper-Scissors. \nPlease make your choice 1-5:\n1) Rock \n2) Paper \n3) Scissors \n4) Exit \n5) Clear the screen\n");
                player = Convert.ToInt32(Console.ReadLine());

                if (player == 1)
                {
                    Console.WriteLine("You chose: Rock");
                }
                else if (player == 2)
                {
                    Console.WriteLine("You chose: Paper");
                }
                else if (player == 3)
                {
                    Console.WriteLine("You chose: Scissors");
                }
                else if (player == 4)
                {
                    Console.WriteLine("Exit");
                    break;
                } else if (player == 5)
                {
                    Console.Clear();
                }

                int computer = random.Next(1, 4);
                if (computer == 1)
                {
                    Console.WriteLine("Computer chose: Rock");
                }
                else if (computer == 2)
                {
                    Console.WriteLine("Computer chose: Paper");
                }
                else if (computer == 3)
                {
                    Console.WriteLine("Computer chose: Scissors");
                }

                switch (player)
                {
                    case 1:
                        if (computer == 1)
                        {
                            Console.WriteLine("It's a tie!\n\n");
                        }
                        else if (computer == 2)
                        {
                            Console.WriteLine("Computer won!\n\n");
                        }
                        else if (computer == 3)
                        {
                            Console.WriteLine("You won!\n\n");
                        }
                        break;

                    case 2:
                        if (computer == 1)
                        {
                            Console.WriteLine("You won!\n\n");
                        }
                        else if (computer == 2)
                        {
                            Console.WriteLine("It's a tie!\n\n");
                        }
                        else if (computer == 3)
                        {
                            Console.WriteLine("Computer won!\n\n");
                        }
                        break;

                    case 3:
                        if (computer == 1)
                        {
                            Console.WriteLine("Computer won!\n\n");
                        }
                        else if (computer == 2)
                        {
                            Console.WriteLine("You won!\n\n");
                        }
                        else if (computer == 3)
                        {
                            Console.WriteLine("It's a tie!\n\n");
                        }
                        break;

                }
            }
        }

    }

}