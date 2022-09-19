using System;

namespace UserInput
{



    class Uinput
    {

        static void Main (string[] args)
        {
            Console.WriteLine("What is your name? ");
            String name = Console.ReadLine();
            
            Console.WriteLine("How old are you? ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Where do you live? ");
            String country = Console.ReadLine();


            Console.Write("So your name is " + name);
            Console.Write(", and you are " + age + " years old");
            Console.Write(", and you are from " + country + ".");


            Console.ReadKey();
        }


    }


}