namespace Condit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ? x : y use in conditional assignment either true or false


            int age = 8;
            String s;

            s = (age >= 18) ? "You are allowed to vote" : "You are not allowed to vote";
            Console.WriteLine(s);

        }
    }
}