namespace NestedLoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Random r = new Random();
            int[,] a = new int[5,4];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    a[i, j] = r.Next(1, 100);
                    Console.WriteLine( i , j, a[i, j]);
                      

                }


            }



        }
    }
}