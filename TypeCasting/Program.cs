using System;

namespace TypeCasting
{

    class Program
    {


        static void Main(string[] args)
        {
            //convert double to integer number
            
            double x = 222.25;
            int y = Convert.ToInt32(x);
            
            //convert integer to double number
            int c = 456;
            double g = Convert.ToDouble(c) + 0.1278234;


            //convert integer to string

            int e = 999;
            String s = Convert.ToString(e);

            //convert string to char


            String r = "M";
            char f = Convert.ToChar(r);


            //convert string to boolean

            String w = "true";
            bool b = Convert.ToBoolean(w);


            Console.WriteLine("**convert double to integer number**");

            Console.Write("X = " + x + " ");

            Console.Write("The Type is  " + x.GetType() + "\n");

            Console.Write("Y = "+ y + " ");

            Console.Write("The type is " + y.GetType()+ "\n");
            Console.WriteLine("");



            Console.WriteLine("**convert integer to double number**");

            Console.Write("C = " + c + " ");

            Console.Write("The Type is  " + c.GetType() + "\n");

            Console.Write("G = " + g + " ");

            Console.Write("The type is " + g.GetType() + "\n");
            Console.WriteLine("");



            Console.WriteLine("**convert integer to string**");

            Console.Write("E = " + e + " ");

            Console.Write("The Type is  " + e.GetType() + "\n");

            Console.Write("S = " + s + " ");

            Console.Write("The type is " + s.GetType()+ "\n");
            Console.WriteLine("");



            Console.Write("**convert string to boolean**" + "\n");

            Console.Write("R = " + r + " ");

            Console.Write("The Type is  " + r.GetType() + "\n");

            Console.Write("F = " + f + " ");

            Console.Write("The type is " + f.GetType()+ "\n");
            Console.WriteLine("");





            Console.WriteLine("**convert integer to string**");

            Console.Write("W = " + w + " ");

            Console.Write("The Type is  " + w.GetType() + "\n");

            Console.Write("B = " + b + " ");

            Console.Write("The type is " + b.GetType() + "\n");



        }





    }






}