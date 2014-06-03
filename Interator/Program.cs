using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interator
{
    class Program
    {
        static void Main(string[] args)
        {
            ILista<string> a = new Lista<string>();
            a[0] = "Item A";
            a[1] = "Item B";
            a[2] = "Item C";
            a[3] = "Item D";

            // Create Iterator and provide aggregate 
            IInterador<string> i = new Interador<string>(a);

            Console.WriteLine("Iterating over collection:");

            var item = i.Primeiro();
            while (item != null)
            {
                Console.WriteLine(item);
                item = i.Proximo();
            }
            // Wait for user 
            Console.Read();
        }
    }
}
