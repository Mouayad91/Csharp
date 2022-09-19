namespace CircleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const double pi = 3.14;

            Console.WriteLine("Enter the radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double result = (pi * (radius * radius));

            Console.WriteLine("The area of the circle is : " + result);


        }
    }
}