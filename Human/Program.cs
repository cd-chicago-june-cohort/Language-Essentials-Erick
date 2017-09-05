using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "This is to test explicit casting";

            Human gasper = new Human("Picasso");
            Console.WriteLine(gasper.name);

            Human frida = new Human("Frida", 6, 100, 23, 120);
            Console.WriteLine(frida.health);
            
            gasper.attack(test);
            Console.WriteLine(frida.health);
        }
    }
}
