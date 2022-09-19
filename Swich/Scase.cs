namespace Swich
{
    internal class Scase 
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your name ?");
            String day = Console.ReadLine();


            switch (day)
            {

                case "Saturday":
                    Console.WriteLine("Today is a holiday");
                    break;
                
                case "Sunday":
                    Console.WriteLine("Today is a holiday");
                    break;

                case "Monday":
                        
                    Console.WriteLine("I have to work today");
                    break;

                case "Tuesday":

                    Console.WriteLine("I have to work today");
                    break;

                case "Wednesday":

                    Console.WriteLine("I have to work today");
                    break;

                case "Friday":

                    Console.WriteLine("I have to work today");
                    break;

                default:
                    Console.WriteLine(day + "is not a day");
                    break;





            }




        }
    }
}