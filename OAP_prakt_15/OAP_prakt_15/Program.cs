using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAP_prakt_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Vvedite n");
            while(!int.TryParse(Console.ReadLine(), out n) || !(n < 0))
            {
                Console.WriteLine("Vvedite chislo");
            }
            /*n = int.Parse(Console.ReadLine());*/
            Stack s = new Stack();
            for (int i = 1; i <= n; i++)
            {
                s.Push(i);
            }
            Console.WriteLine("Razmernost staka {0}", s.Count);
            Console.WriteLine("Verhniy element staka {0}", s.Peek());
            Console.WriteLine("Razmernost staka {0}", s.Count);
            while (s.Count != 0)
            {
                Console.Write("{0} ", s.Pop());
            }
            Console.WriteLine("\nNovaya razmernost staka {0}", s.Count);
        }
    }
}
