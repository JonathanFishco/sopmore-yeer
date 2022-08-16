using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace freaked_up_a_little
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y=0;
            Console.WriteLine("enter your age");
            x=int.Parse(Console.ReadLine());
            Console.Write(x);
            Console.ReadKey();
            Console.WriteLine("your age is " + x);
            Console.ReadLine();
            Console.WriteLine("your age is {0}.",x);
            Console.ReadLine();
            Console.WriteLine($"your age is {x}");
            Console.ReadLine();
            string answer = "d";
            Console.WriteLine("how dumb is mr clarke\n" + 
                " a.very\n" +
                " b.very\n" +
                " c.very\n" +
                " d.super very dumb");
           if (answer == "d")
            {
                y++;
            }
                
            Console.ReadLine();
            Console.WriteLine("how cool is mr clarke\n" +
                " a.not\n" +
                " b.not\n" +
                " c.not\n" +
                " d.as cool as my grandma");
            if (answer == "d")
            {
                y++;
            }

            Console.ReadLine();
            Console.WriteLine("what grade is mr clarke gonna give me\n" +
                " a.F\n" +
                " b.B\n" +
                " c.A\n" +
                " d.the best grade he can");
            Console.ReadLine();
            if (answer == "d")
            {
                y++;
            }
            Console.WriteLine("Amount correct: " + y);
            Console.ReadLine();
        }
    }
}
