using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_dz2
{
    class Program
    {
        class Book
        {
            public void FindNext(string str)
            {
                Console.WriteLine("Поиск строки : " + str);
            }

            public class Notes
            {
                public void saveNote(string str)
                {
                    Console.WriteLine("Saving \"{0}\"", str);
                }
            }
        }

        static void Main(string[] args)
        {
            Book.Notes a = new Book.Notes();
            a.saveNote("hello");

            Console.ReadLine();
        }
    }
}
