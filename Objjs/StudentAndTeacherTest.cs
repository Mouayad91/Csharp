namespace Objjs
{
    internal class StudentAndTeacherTest
    {



        static void Main(String[] args)
        {

            Person p = new Person();
            p.Greeting();

            Students s1 = new Students();
            s1.SetAge(21);
            s1.Greeting();
            s1.ShowAge();

            Teacher t1 = new Teacher();
            t1.SetAge(30);
            t1.Greeting();
            t1.Explain();




        }

    }

     class Person
    {
        public int age;
       
        public void SetAge (int n)
        {
            age = n;

        }

        public void Greeting()
        {
            Console.WriteLine("Hello, ");
        }

    }

    class Students : Person
    {



        public void GoToClasses()
        {

            Console.WriteLine("I am going to class");
        }

        public void ShowAge()
        {

            Console.WriteLine("My age is:" + age + " years old");
        }

    }

    class Teacher : Person
    {
        private String subject;

        public void Explain()
        {

            Console.WriteLine("Explanation begins ");


        }



    }

    
    

}