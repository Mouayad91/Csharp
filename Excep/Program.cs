namespace Excep
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x;
            int y;
            int result;
            bool b = true;
            String play;

            while (b)
            {
                play = "";
                try
                {

                    Console.WriteLine("Enter your first number : ");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter your second number : ");
                    y = Convert.ToInt32(Console.ReadLine());

                    result = x / y;


                    Console.WriteLine("Result : " + result);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Please enter a number");
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("You can not divide by zero!!!");
                }
                catch (Exception e)
                {

                    Console.WriteLine("Something went wrong!!!");

                }


                Console.WriteLine("Do you wanna Calculate again : Y/N");
                play = Console.ReadLine();
                play = play.ToUpper();
                if (play == "Y")
                {
                    b = true;

                }
                else
                {

                    b = false;
                }
            }
           


        }
    }
}