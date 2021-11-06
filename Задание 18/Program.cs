using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_18
{
    class Program
    {
        static void Main(string[] args)
        {
            string skoby = "({[)}]";
            string s = "([]{})[]";
            bool chet = true;
            Stack<char> stack = new Stack<char>();

            foreach (var x in s)
            {
                int f = skoby.IndexOf(x);

                if (f >= 0 && f <= 2)
                    stack.Push(x);

                if (f > 2)
                {
                    if (stack.Count == 0 || stack.Pop() != skoby[f - 3])
                        chet = false;
                }
            }
            if (stack.Count != 0)
                chet = false;
            if (chet == false)
            {
                Console.WriteLine("Скобки расставлены не верно");
            }
            else
            {
                Console.WriteLine("Скобки расставлены верно");
            }

            Console.ReadKey();
        }
    }
}
