using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextGame.GameManager;

namespace TextGame.Scene
{
    internal class MainMenuScene : Scene
    {
        private MainMenuOption currentCursor = MainMenuOption.Default;
        public MainMenuScene(SceneManager sceneManager) : base(sceneManager)
        {

        }
        public override void Render()
        {
            switch (currentCursor)
            {
                case MainMenuOption.StartGame:
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("게임 시작");
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.WriteLine("게임 종료");
                    Console.SetCursorPosition(9, 0);
                    break;
                case MainMenuOption.QuitGame:
                    Console.WriteLine("게임 시작");
                    Console.WriteLine();
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("게임 종료");
                    Console.ResetColor();
                    Console.SetCursorPosition(9, 2);
                    break;
                default:
                    Console.WriteLine("게임 시작");
                    Console.WriteLine();
                    Console.WriteLine("게임 종료");
                    break;
            }
        }
        public override void Update()
        {
            ConsoleKeyInfo input;
            input = Console.ReadKey();
            switch (input.Key)
            {
                case ConsoleKey.UpArrow:
                    if (currentCursor == MainMenuOption.StartGame)
                    {
                        currentCursor = MainMenuOption.QuitGame;
                    }
                    else
                    {
                        currentCursor = MainMenuOption.StartGame;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (currentCursor == MainMenuOption.QuitGame)
                    {
                        currentCursor = MainMenuOption.StartGame;
                    }
                    else
                    {
                        currentCursor = MainMenuOption.QuitGame;
                    }
                    break;
                case ConsoleKey.Enter:
                    if (currentCursor == MainMenuOption.StartGame)
                    {
                        sceneManager.GotoInvasionScene();
                    }
                    else
                    {
                        sceneManager.GameManager.FinishGame();
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
