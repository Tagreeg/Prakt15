using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAP_prakt_15._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q1 = new Queue();
            int n, upper;
            Console.WriteLine("Vvedite n");
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Vvedite chislo");
            }
            if (n < 0)
            {
                for(int i = 1; i >= n; i--)
                {
                    q1.Enqueue(i);
                }
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    q1.Enqueue(i);
                }
            }

            Console.WriteLine("Razmernostocheredi {0}", q1.Count);

            if (n < 0)
            {
                Console.WriteLine("Verhniy element ocheredi -{0}", q1.Count-2);
            }
            else
            {
                Console.WriteLine("Verhniy element ocheredi {0}", q1.Count);
            }
            
            Console.WriteLine("Soderjimoe ocheredi: ");
            while(q1.Count != 0)
            {
                Console.Write("{0} ", q1.Dequeue());
            }
            
            Console.WriteLine("\nNovaya razmernost {0}", q1.Count);
        }
    }
}
