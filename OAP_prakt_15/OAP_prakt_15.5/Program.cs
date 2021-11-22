using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace OAP_prakt_15._5
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader r1 = new StreamReader("text1.txt");
            ArrayList list = new ArrayList();
            ArrayList sortedList = new ArrayList();

            while (!r1.EndOfStream)
            {
                string str = r1.ReadLine();
                list.AddRange(new string[] { str });
            }
            r1.Close();

            foreach (string s in list)
            {
                Console.WriteLine("Vivod bez sortirovki");
                Console.WriteLine(s);
            }

            StreamReader r2 = new StreamReader("text1.txt");
            for (int i = 0; i < list.Count; i++)
            {
                while (!r2.EndOfStream)
                {

                }
            }
        }
    }
}
