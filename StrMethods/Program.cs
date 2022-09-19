namespace StrMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String s = "Mouayad H.Omar";
            String bd = "04.01.1992";

            

            s = s.ToLower();
            Console.WriteLine(s);
            
            s = s.ToUpper();
            Console.WriteLine(s);

            bd = bd.Replace(".", "/");
            Console.WriteLine(bd);

            s = s.Insert(0, "Mr.");
            Console.WriteLine(s);

            String str = s.Substring(0, 10);
            Console.WriteLine(str);

            s = s.Remove(0, 3);
            Console.WriteLine(s);




        }
    }
}