namespace TwoDarr
{
    internal class Program
    {
        static void Main(string[] args)
        {

           /* String[] s1 = { "Ahmad", "IT", "6" };
            String[] s2 = { "Mouayad", "Game Development", "5" };
            String[] s3 = { "Muthanna", "Medical Engineering", "5" };
            String[] s4 = { "Monzer", "Game Art", "3" };
           */
            String[,] students = { { "Ahmad", "IT", "6" } ,
                                    { "Mouayad", "Game Development", "5" },
                                        { "Muthanna", "Medical Engineering", "5" },
                                            { "Monzer", "Game Art", "3" } };

            for (int i = 0; i < students.GetLength(0); i++)
            {

                for(int j = 0; j < students.GetLength(1); j++)
                {

                    Console.Write( students[i , j] + " ");

                }
                Console.WriteLine();
            }

        }
    }
}