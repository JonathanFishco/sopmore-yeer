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
            int y = 0;
            Console.WriteLine("enter your age");
            x = int.Parse(Console.ReadLine());
            Console.Write(x);
            Console.ReadKey();
            Console.WriteLine("your age is " + x);
            Console.ReadLine();
            Console.WriteLine("your age is {0}.", x);
            Console.ReadLine();
            Console.WriteLine($"your age is {x}");
            Console.ReadLine();
            string answer = "d";
            ShowQuestion("How dumb is Mr Clarke?", "a)so very dumb", "b)smart",
"c)teacher smart", "d)literally the dumbest person ever", "d");
            answer = Console.ReadLine();
            if (answer == "d")
            {
                y++;
            }

            Console.ReadLine();
            ShowQuestion("How old is Mr Clarke?", "a)42", "b)23", "c)73", "d) I actually dont know", "d");
            answer = Console.ReadLine();
            if (answer == "d")
            {
                y++;
            }
            Console.ReadLine();
            ShowQuestion("How cool is Mr Clarke?", "a)very", "b)super cool",
"c)amazing", "d)as cool as my grandma", "d");
            answer = Console.ReadLine();
            if (answer == "d")
            {
                y++;
            }
            Console.WriteLine("Amount correct: " + y);
            Console.ReadLine();
            ShowQuestion("What is 1+1?", "a)1", "b)2", "c) 0", "d) 6", "b");
            Console.ReadKey();
        }
        public static void ShowQuestion(string question,
                                        string answer1,
                                        string answer2,
                                        string answer3,
                                        string answer4,
                                        string correct)
        {
            Console.WriteLine(question);
            Console.WriteLine(answer1);
            Console.WriteLine(answer2);
            Console.WriteLine(answer3);
            Console.WriteLine(answer4);
            string answer = Console.ReadLine();
            if (answer.Equals(correct))
            {
                Console.WriteLine("you got it correct");
            } 
        }
    }
}