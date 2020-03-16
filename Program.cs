using System;

namespace Robots_Vs._Dinosaurs
{
    class Program
    {
        static void Main(string[] args)
        {
            Battlefield battle = new Battlefield();

            Console.WriteLine("Robots Vs. Dinosaurs\n" + "Press Enter to Begin\n" + "------------------------------------");
            Console.ReadLine();
            battle.Fight();
        }
    }
}
