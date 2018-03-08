using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("guess_what?");
            string ans = Console.ReadLine();
            
            if (ans == "BANG")
            {
                Console.WriteLine("BANG");
            }
            Console.Read();
        }
    }
}
