using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextGame.GameManager;

namespace TextGame.Scene
{
    internal class InvasionScene : Scene
    {
        public InvasionScene(SceneManager sceneManager) : base(sceneManager)
        {
            
        }
        public override void Render()
        {
            PrintMap();
        }
        // TODO: 여기서부터 다시
        public override void Update()
        {
            Console.ReadLine();
        }
        private void PrintMap()
        {
            for (int y = 0; y < DataManager.TileMap.GetLength(0); y++)
            {
                for (int x = 0; x < DataManager.TileMap.GetLength(1); x++)
                {
                    switch (DataManager.TileMap[y, x])
                    {
                        case '▩':
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(DataManager.TileMap[y, x]);
                            Console.Write(DataManager.TileMap[y, x]);
                            break;
                        case '■':
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write(DataManager.TileMap[y, x]);
                            break;
                        case '♨':
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write(DataManager.TileMap[y, x]);
                            Console.Write(DataManager.TileMap[y, x]);
                            break;
                        case '♣':
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write(DataManager.TileMap[y, x]);
                            Console.Write(DataManager.TileMap[y, x]);
                            break;
                        case '▲':
                        case '▼':
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(DataManager.TileMap[y, x]);
                            Console.Write(DataManager.TileMap[y, x]);
                            break;
                        case 'П':
                            Console.Write(DataManager.TileMap[y, x]);
                            Console.Write(DataManager.TileMap[y, x]);
                            break;
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }
    }
}
