namespace Arr
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String[] food = new string[4];

            food[0] = "Meat";
            food[1] = "Rice";
            food[2] = "Chicken";
            food[3] = "Bread";

            //String food [] = {"Meat" , "Rice" , "Chicken" , "Bread"};

            for(int i = 0; i < food.Length; i++)
            {

                Console.WriteLine(food[i]);

            }

         



        }
    }
}