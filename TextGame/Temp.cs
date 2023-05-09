using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
    public class Temp
    {
        static void PrintResult(in char[,] map, in List<GameManager.Point> path)
        {
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    switch (map[y, x])
                    {
                        case '▩':
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(map[y, x]);
                            Console.Write(map[y, x]);
                            break;
                        case '■':
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write(map[y, x]);
                            break;
                        case '♨':
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write(map[y, x]);
                            Console.Write(map[y, x]);
                            break;
                        case '♣':
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write(map[y, x]);
                            Console.Write(map[y, x]);
                            break;
                        case '▲':
                        case '▼':
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(map[y, x]);
                            Console.Write(map[y, x]);
                            break;
                        case 'П':
                            Console.Write(map[y, x]);
                            Console.Write(map[y, x]);
                            break;
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();
            }

            foreach (GameManager.Point point in path)
            {
                map[point.y, point.x] = '*';
            }

            GameManager.Point start = path.First();
            GameManager.Point end = path.Last();
            map[start.y, start.x] = 'S';
            map[end.y, end.x] = 'E';

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
