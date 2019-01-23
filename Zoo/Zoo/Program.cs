using System;
using Zoo.Interfaces;
using Zoo.Classes;


namespace Zoo
{
    public class Program
    {
        static void Main(string[] args)
        {   
            //new gecko
            Console.WriteLine("Welcome to to the Zoo!!");
            Gecko gecko = new Gecko();
            Console.WriteLine("                        ");
            Console.WriteLine("        The Gecko ");
            Console.WriteLine("                        ");
            Console.WriteLine($" I have {gecko.Legs} legs.");
            Console.WriteLine(gecko.GrowTailBack());
            Console.WriteLine("                        ");
            Console.WriteLine("                        ");

            //new golden monkey
            Golden_Monkey monkey = new Golden_Monkey();
            Console.WriteLine("                        ");
            Console.WriteLine("      Golden Monkey  ");
            Console.WriteLine("                        ");
            Console.WriteLine("                        ");
            Console.WriteLine($" I have {monkey.Legs} legs.");
            Console.WriteLine("                        ");
            Console.WriteLine(monkey.Swing());
            Console.WriteLine("                        ");

            // new Reindeer
            Reindeer reindeer = new Reindeer();
            Console.WriteLine("                        ");
            Console.WriteLine("         Reindeer    ");
            Console.WriteLine("                        ");
            Console.WriteLine($" I have {reindeer.Legs} legs.");
            Console.WriteLine("                        ");

            //new Deer
            Elk elk = new Elk();
            Console.WriteLine("                        ");
            Console.WriteLine("          Elk    ");
            Console.WriteLine("                        ");
            Console.WriteLine($" I have {elk.Legs} legs.");
            Console.WriteLine("                        ");

            // new sea turtle
            Sea_turtle turtle = new Sea_turtle();
            Console.WriteLine("                        ");
            Console.WriteLine("          Sea Turtle    ");
            Console.WriteLine("                        ");
            Console.WriteLine($" I have {turtle.Legs} legs.");
            Console.WriteLine("                        ");



















        }
    }
}
