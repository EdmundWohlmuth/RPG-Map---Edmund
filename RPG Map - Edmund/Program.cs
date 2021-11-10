using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Map___Edmund
{
    class Program
    {
        static char[,] map1 = new char[,]
                 {
        {'^','^','^','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\''},
        {'^','^','\'','\'','\'','\'','*','*','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','~','~','~','\'','\'','\''},
        {'^','^','\'','\'','\'','*','*','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','~','~','~','\'','\'','\'','\'','\''},
        {'^','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\''},
        {'\'','\'','\'','\'','~','~','~','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\''},
        {'\'','\'','\'','\'','~','~','~','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\''},
        {'\'','\'','\'','~','~','~','~','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','^','^','\'','\'','\'','\'','\'','\''},
        {'\'','\'','\'','\'','\'','~','~','~','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','^','^','^','^','\'','\'','\'','\'','\''},
        {'\'','\'','\'','\'','\'','~','~','~','~','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','^','^','^','^','\'','\'','\''},
        {'\'','\'','\'','\'','\'','\'','\'','~','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\''},
        {'\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'',},
        {'\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'',},
                 };


        static int rows = map1.GetLength(0);
        static int columns = map1.GetLength(1);

        static void Main(string[] args)
        {

            DisplayMap();
            Console.WriteLine(" ");
            DisplayMap(2);

            Console.ReadKey(true);
        }

        static void DisplayMap()
        {

            //top border
            Console.Write("┌");
            for (int i = 0; i <= columns - 1; i++)
            {
                Console.Write("─");
            }
            Console.Write("┐");
            Console.WriteLine("");

            //map
            for (int x = 0; x <= rows - 1; x++)
            {
                for (int y = 0; y <= columns - 1; y++)
                {
                    if (y == 0)
                    {
                        Console.Write("│");
                    }
                    Console.Write(map1[x, y]);                    
                }
                Console.Write("│");
                Console.WriteLine();
            }

            //bottom border
            Console.Write("└");
            for (int i = 0; i <= columns - 1; i++)
            {
                Console.Write("─");
            }
            Console.Write("┘");
            Console.WriteLine("");        
        }

        static void DisplayMap(int scale)
        {

            //top Border
            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("┌");
            for (int i = 0; i <= columns * scale - 1; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("─");
            }
            Console.Write("┐");
            Console.WriteLine("");

            //map
            for (int x = 0; x <= rows - 1; x++)
            {
                for (int j = 0; j < scale; j++)
                {
                    for (int y = 0; y <= columns - 1; y++)
                    {
                        DisplayColour(x, y);
                        if (y == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("│");
                        }
                        DisplayColour(x, y);
                        for (int i = 0; i < scale; i++)
                        {                           
                            Console.Write(map1[x, y]);                            
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("│");
                    Console.WriteLine();
                }               
            }
            

            // bottom border
            Console.Write("└");
            for (int i = 0; i <= columns * scale - 1; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("─");
            }
            Console.Write("┘");
        }

        static void DisplayColour(int x, int y)
        {
            if (map1[x, y] == '\'')
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (map1[x, y] == '*')
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
            }
            else if (map1[x, y] == '~')
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (map1[x, y] == '^')
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
            }
        }
    }
}
