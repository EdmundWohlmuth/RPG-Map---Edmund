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
            static void Main(string[] args)
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

                Console.Write(map1);
                Console.ReadKey(true);
            }
        }
    }
}
