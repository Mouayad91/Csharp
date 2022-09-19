namespace Elifs
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, How old are you ?");
            int age = Convert.ToInt32(Console.ReadLine());





                if (age > 70)
            {

                Console.WriteLine("Bro, you will break your bones, pls go watch TV ");

            }
            else if (age >= 18)
            {

                Console.WriteLine("You are allowed to enter the club");


            }
         



            else if (age <= 0)
            {


                Console.WriteLine("Are you serious????");
            }
            else if(age < 18)
            {

                Console.WriteLine("You are not allowed to enter the club!!");


            }

        




        }
    }
}