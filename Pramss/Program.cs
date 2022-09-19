namespace Pramss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double t = Checks(5.22, 4.55, 10, 20);
            Console.WriteLine("Total is : "+t+"$");



        }
        static double Checks(params double[] price)
        {

            double t = 0;

            foreach(double d in price)
            {

                t += d;
            }

            return t;
        }
    
    }


}