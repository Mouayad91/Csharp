namespace Methood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name = "Mouayad";
            int age = 29;
            String study = "IT";
            String hobby = "Video Games";




            mody(name, age, study, hobby);
        }

        static void mody (String name, int age, String study, String hobby)
        {

            Console.WriteLine("Hello my name is " + name);
            Console.WriteLine("I am " + age + " years old");
            Console.WriteLine("I am currently studying " + study);
            Console.WriteLine("My favorite hobby is playing " + hobby);





        }
    }
}