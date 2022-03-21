using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The client code.
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Singleton works!");
                s1.setNumber(5, 9, 2);
                Console.WriteLine(s1.Delta());
                Console.WriteLine("Square root: "+s1.SqrtDelta());
            }
            else
            {
                Console.WriteLine("Holy potatoes!");
            }
        }
    }
}