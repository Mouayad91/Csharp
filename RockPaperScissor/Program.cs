namespace RockPaperScissor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            bool b = true;
            String player;
            String AI;

            while (b)
            {
                player = "";
                AI = "";
                while(player != "ROCK" && player != "PAPER" && player != "SCISSOR")
                {
                    Console.WriteLine("Chose ROCK, PAPER, or SCISSOR :");
                    player = Console.ReadLine();
                    player = player.ToUpper();



                }

                int rand = r.Next(1, 3);

                switch (rand)
                {

                    case 1:
                        AI = "ROCK";
                        break;
                    case 2:
                        AI = "PAPER";
                        break;
                    case 3:
                        AI = "SCISSOR";
                            break;
                
               }

                Console.WriteLine("YOU :" + player);
                Console.WriteLine("AI :" + AI);


                switch (player)
                {

                    case "ROCK":
                        
                        if (AI == "ROCK")
                        {
                            Console.WriteLine("It is a draw");

                        }else if (AI == "PAPER")
                        {
                            Console.WriteLine("You lost!");
                        }
                        else
                        {
                            Console.WriteLine("Winner winner chicken dinner!");
                        }
                        
                        break;

                    case "PAPER":
                        if (AI == "ROCK")
                        {
                            Console.WriteLine("Winner winner chicken dinner!");

                        }
                        else if (AI == "PAPER")
                        {
                            Console.WriteLine("It is a draw!");
                        }
                        else
                        {
                            Console.WriteLine("You lost!");
                        }


                        break;
                   
                    case "SCISSOR":
                        
                        if (AI == "ROCK")
                        {
                            Console.WriteLine("You Lost!");

                        }
                        else if (AI == "PAPER")
                        {
                            Console.WriteLine("Winner winner chicken dinner");
                        }
                        else
                        {
                            Console.WriteLine("it is a draw!");
                        }

                        break;


                }

            }



        }
    }
}