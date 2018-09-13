using System;

namespace Lab04
{
    class Program
    {
        static void Main(string[] args)
        {


            char ch;
            Console.Write("Press a key followed by ENTER:");
            ch = Console.Read();  // get a char
            Console.WriteLine("Your key is: " + ch);



            Console.ReadKey();

        }
    }
}
