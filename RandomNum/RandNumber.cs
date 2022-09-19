namespace RandomNum
{
    internal class RandNumber
    {
        static void Main(string[] args)
        {

            Random r = new Random();

            int num1 = r.Next(1, 100);
            double num2 = r.NextDouble(1.0,66.66);

            Console.WriteLine(num1);
            Console.WriteLine(num2);




        }
    }
}