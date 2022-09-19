using System.Security.AccessControl;

namespace FrEach
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // for each is a simple way to iterate over an array (bad flexiblity sometimes)

            String[] fr = { "Apple", "Orange", "Banana" };

            foreach (String fru in fr)
            {

                Console.WriteLine(fru);

            }

        


        }
    }
}