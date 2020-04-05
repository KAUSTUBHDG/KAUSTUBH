using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = new List<string>();
            
            
            while(true)
            {
                Console.WriteLine("Enter a name");
                var input = Console.ReadLine();
                
                if (!string.IsNullOrEmpty(input))
                {
                    name.Add(input);
                   
                }
                else
                {
                    break;
                }
              /*  Console.WriteLine("How many likes would you like to give?");
                int Like = Console.Read();
                var like = new List<int>();
                like.Add(Like);
                */

                if (name.Count > 2)
                    Console.WriteLine("{0}, {1} and {2} others like your post", name[0], name[1], name.Count - 2);
                else if (name.Count == 2)
                    Console.WriteLine("{0} and {1} like your post", name[0], name[1]);
                else if (name.Count == 1)
                    Console.WriteLine("{0} likes your post.", name[0]);
                else
                    Console.WriteLine();

            }


        }
    }
}
