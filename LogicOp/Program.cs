namespace LogicOp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is the temperature outside ?");
            Double c = Convert.ToDouble(Console.ReadLine()); 

            if (c >= 15  && c <= 30 )
            {

                Console.WriteLine("it is fine to go shopping.");


            }else if (c < -10  || c >= 45){


                Console.WriteLine("In my opinion you should stay home.");

            }



        }
    }
}