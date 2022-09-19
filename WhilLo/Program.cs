namespace WhilLo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int age = 10;

            while (age >= 1)
            {
                Console.WriteLine("How old are you? ");
                age = Convert.ToInt32(Console.ReadLine());


            }
            Console.WriteLine("You are " + age + " years old");




        }
    }
}