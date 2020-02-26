using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Completely_Random_Password_Generator
{
    class Program
    {
        static string[] ch = new string[] {
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z",
            "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z",
            "1", "2", "3", "4", "5", "6", "7", "8", "9", "0",
        };

        static void Main(string[] args)
        {
            for (; ; )
            {
                try
                {
                    Random r = new Random();

                    Console.WriteLine("Welcome to the Not So Random Password Generator!!");

                    Console.Write("This is ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("NOT");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(" recommended for using as your actual password, as it uses all the letters and numbers available.");

                    Console.WriteLine("There are {0} different characters that are used in generating.", ch.Length);

                    for (; ; )
                    {
                        Console.WriteLine("---------------------------------------------------------------------------");
                        Console.Write("So, how much characters do you want in your Completely Random Password? ");
                        int characters = Convert.ToInt32(Console.ReadLine());

                        double Permutations = Math.Pow(ch.Length, characters);

                        Console.WriteLine("You will have {0} characters in your Password, so there can be {1} possible passwords generated.", characters, Permutations);

                        string password = "";
                        for (int i = 0; i < characters; i++)
                        {
                            password += ch[r.Next(0, ch.Length)];
                        }

                        Console.Write("Done! Here's your password: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(password);
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                }

                catch (Exception e)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You wronged.");
                    Console.WriteLine(e);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                }
            }
        }
    }
}
