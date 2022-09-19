namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do {
                double num1;
                double num2;
                double result;
                char op;
                Console.WriteLine("Simple Calculator");
                Console.WriteLine("*******************");

                Console.WriteLine("Enter your first number :");
                num1 = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("Enter your sceond number :");
                num2 = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("Chose an operation + , - , / , * : ");
                op = Convert.ToChar(Console.ReadLine());

                switch (op)
                {


                    case '+':

                        result = num1 + num2;
                        Console.WriteLine(result);

                        break;


                    case '-':

                        result = num1 - num2;
                        Console.WriteLine(result);

                        break;

                    case '/':

                        result = num1 / num2;
                        Console.WriteLine(result);

                        break;
                    case '*':

                        result = num1 * num2;
                        Console.WriteLine(result);

                        break;

                }

                Console.WriteLine("Do you want to calculate something else: Y,N");

            }

            while (Console.ReadLine().ToUpper() == "Y");






            

        }
    }
}