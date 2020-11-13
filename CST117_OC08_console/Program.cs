//use for IC08
//Lydia's code
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST117_IC08_console
{
    class Program
    {
        static void Main(string[] args)
        {
            //make some sets
            Set A = new Set();
            Set B = new Set();

            //put some stuff in the sets
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                // A.addElement(r.Next(4));
                // B.addElement(r.Next(12));
                A.add(r.Next(4));
                B.add(r.Next(12));
            }

            //display each set and the union
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);
            //The union method has changed, this line must change to accomodate
            //the updated method call
            //Console.WriteLine("A union B: " + A.union(B));
            Console.WriteLine("A union B: " + Set.union(A, B));

            //display original sets (should be unchanged)
            Console.WriteLine("After union operation");
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);
        }
    }
}
