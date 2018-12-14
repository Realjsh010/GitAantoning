using System;

namespace GitAantoning
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomClass _rc = new RandomClass(9);

            Console.WriteLine("Hello World!");
            // Commit 1
            int getal = _rc.MaakGetalletje(5);
            Console.WriteLine(getal);
        }
    }
}
