using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCode
{
    internal class Hello
    {
        public static void ShowHello()
        {
            string name = "Robin Sträng";
            int age = 36;
            char[] initials = { 'R', 'S' };

            Console.WriteLine("Hello " + name);
            Console.WriteLine("Your age is " + age);
            Console.Write("And your initials are ");
            foreach (var item in initials)
            {
                Console.Write(item + ".");
            }
        }
    }
}
