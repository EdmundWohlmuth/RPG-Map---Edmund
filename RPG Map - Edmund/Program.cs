using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Map___Edmund
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayMap();

            Console.ReadKey(true);
        }

        static void DisplayMap()
        {
            char[,] map1 = new char[8, 8]
                 {
                {'a','a','a','a','a','a','a','a' },
                {'a','a','a','a','a','a','a','a' },
                {'a','a','a','a','a','a','a','a' },
                {'a','a','a','a','a','a','a','a' },
                {'a','a','a','a','a','a','a','a' },
                {'a','a','a','a','a','a','a','a' },
                {'a','a','a','a','a','a','a','a' },
                {'a','a','a','a','a','a','a','a' },
                 };

            for ( char x = ' '; x <= 7; x++)
            {
                for ( char y = ' '; y <= 7; y++)
                {
                    map1[x, y] = ' ';

                    Console.WriteLine(+ x + "," + y);
                }
            }

        }

        void DisplayMap(int scale)
        {

        }
    }
}
