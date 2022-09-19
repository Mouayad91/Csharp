namespace NumberGuess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            bool play = true;
            int min = 1;
            int max = 10;
            int g;
            int num;
            int gs;
            String repeat;
            while (play)
            {
                //Reset

                g = 0;
                gs = 0;
                repeat = "";
                num = r.Next(min, max + 1);

                while ( g != num)
                {

                    Console.WriteLine(" Guess a number between 1 and 10 :");
                    g = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Guess :" + g);
                
                    if(g > num)
                    {
                        Console.WriteLine(g + " Is Too high");


                    }else if (g < num)
                    {

                        Console.WriteLine(g + " Is Too low");
                    }
                    gs++;
                
                }

                Console.WriteLine("Number : " + num);
                Console.WriteLine(num + " Is The Correct Number");
                Console.WriteLine("Guesses :" + gs);
                Console.WriteLine("----------------------------");
                Console.WriteLine("Do you wann play again? (Y/N) :");
                repeat = Console.ReadLine();
                repeat = repeat.ToUpper();
          
            
                if(repeat == "Y")
                {

                    play = true;
                }else 
                {

                    play = false;
                }
            
            }



        }
    }
}