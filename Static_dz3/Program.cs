using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_dz3
{
    static class ExtensionClass
    {
        public static void MySort(this int[] a)
        {
            Array.Sort(a);
        }
    }

    class Program
    {
        public static void print(int[] a)
        {
            for(int i = 0; i < a.Length;i++)
                Console.Write("{0} ", a[i]);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] a = new int[] { 5, 7, 1, 9, 0 };

            Console.WriteLine("Before: ");
            print(a);
            a.MySort();
            Console.WriteLine("\nAfter:");
            print(a);

            Console.ReadLine();
        }
    }
}
