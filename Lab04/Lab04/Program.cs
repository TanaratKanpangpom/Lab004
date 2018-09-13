using System;

namespace Lab04
{
    class Program
    {
        static void Main(string[] args)
        {


            String name, Lastname;
            int SID;
            double GPA;
            Console.WriteLine("plsea name");
            name = Console.ReadLine();
            Console.WriteLine("plsea Lastname");
            Lastname = Console.ReadLine();
            Console.WriteLine("plsea sid");
            int.TryParse(Console.ReadLine(), out SID);
            Console.WriteLine("plsea gpa");
            double.TryParse(Console.ReadLine(), out GPA);

            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Age: {0}", Lastname);
            Console.WriteLine("Height: {0}", SID);
            Console.WriteLine("Height: {0}", GPA);





            Console.ReadKey();

        }
    }
}
