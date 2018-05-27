using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_dz
{
    class Program
    {
        class Book
        {
            public void FindNext(string str)
            {
                Console.WriteLine("Поиск строки : " + str);
            }
        }
        static class FindAndReplaceManager
        {
            public static void FindNext(string str)
            {
                new Book().FindNext(str);
            }
        }

        static void Main(string[] args)
        {

            FindAndReplaceManager.FindNext("hello");

            Console.ReadLine();
        }
    }
}
