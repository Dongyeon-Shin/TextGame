using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame.GameManager
{
    public enum Direction { Up, Down, Left, Right }
    public enum MainMenuOption { Default, StartGame, QuitGame}
    public struct Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
