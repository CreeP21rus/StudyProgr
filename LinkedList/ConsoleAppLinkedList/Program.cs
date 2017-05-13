using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Linked_List L = new Linked_List();
            for(int i=0;i<5;i++)
            {
                L.Add(i);
            }
            foreach (int x in L)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
            L.Delete(2);
            foreach (int x in L)
            {
                Console.Write(x+" ");
            }
            Console.WriteLine();
            L.Add(3, 7);
            foreach (int x in L)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine(L.Contains(7));
            Console.WriteLine();
            L.Clear();
            foreach (int x in L)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
