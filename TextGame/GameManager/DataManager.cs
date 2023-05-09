﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextGame.Unit.Soldier;

namespace TextGame.GameManager
{
    public static class DataManager
    {
        private static char[,] tileMap;
        public static char[,] TileMap { get { return tileMap; } }
        private static Point villagePosition;
        private static List<Soldier> allyPosition;
        public static void Init()
        {
            tileMap = new char[,]
            {
                {'■', '■', '■', '■', '■', '■', '■', '■', '■', '■', '■', '■', '■', '■', '■', '■', '■', '■', '■', '■', '■', '■', '■', '■'},
                {'■','▩','▩','▩','▩', '▩','▩','▩','▩','▩','▩' ,'▩','▩','▩','▩', '▩','▩','▩','▩','▩','▩', '▩','▩','■'},
                {'■','▩','▩','♣','▩', '▩','▩','▩','♣','▩','▩' ,'▩','▩','▩','▩', '♣','▩','▩','▩','▩','▩', '▩','▩','■'},
                {'■','▩','▩','♣','▩', '▩','▩','▩','♣','▩','▩' ,'▩','▩','▩','♣', '♣','♣','▩','▩','▩','▩', '▩','▩','■'},
                {'■','▩','▩','♣','♣', '▩','▩','▩','♣','♣','▩' ,'▩','▩','▩','♣', '♣','♣','▩','▩','▩','▩', '▩','▩','■'},
                {'■','▩','▩','♣','♣', '▩','▩','▩','♣','♣','▩' ,'▩','▩','▩','▩', '▩','▩','▩','♣','♣','▩', '▩','▩','■'},
                {'■','▩','▩','♣','♣', '▩','▩','▩','♣','♣','▩' ,'▩','▩','▩','▩', '▩','▩','▩','♣','♣','▩', '▩','▩','■'},
                {'■','▩','♣','♣','♣', '▩','▩','▩','♣','♣','▩' ,'▩','♣','♣','♣', '▩','▩','▩','♣','♣','♣', '▩','▩','■'},
                {'■','▩','♣','♣','♣', '▩','▩','▩','♣','▩','▩' ,'▩','♣','♣','♣', '▩','▩','▩','♣','♣','♣', '▩','▩','■'},
                {'■','▩','♣','♣','▩', '▩','▩','▩','▩','▩','♣' ,'♣','♣','♣','♣', '♣','▩','▩','▩','♣','♣', '▩','▩','■'},
                {'■','▩','♣','♣','▩', '▩','▩','▩','▩','▩','♣' ,'♣','♣','♣','♣', '♣','▩','▩','▩','▩','♣', '▩','▩','■'},
                {'■','▩','♣','♣','▩', '▩','▩','▩','▩','▩','♣' ,'♣','♣','♣','♣', '♣','♣','▩','▩','▩','▩', '▩','▩','■'},
                {'■','▩','▩','▩','▩', '♣','♣','♣', '♣', '♣','♣' ,'♣','♣','♣','♣', '♣','♣','♣','▩','▩','▩', '▩','▩','■'},
                {'■','▩','▩','▩','▩', '♣','♣','♣', '♣', '♣','♣' ,'♣','♣','♣','♣', '♣','♣','♣','♣','▩','▩', '♣','▩','■'},
                {'■','▩','♣','♣','▩', '▩','▩','▩','▩','▩','♣' ,'♣','♣','♣','♣', '♣','♣','♣','♣','▩','♣', '♣','▩','■'},
                {'■','♣','♣','♣','▩', '▩','▩','▩','▩','▩','▩' ,'♣','♣','♣','♣', '♣','♣','♣','♣','▩','♣', '♣','▩','■'},
                {'■','♣','♣','♣','▩', '▩','▩','▩','▩','▩','▩' ,'♣','♣','♣','♣', '♣','♣','♣','▩','▩','▩', '♣','▩','■'},
                {'■','♣','▩','▩','▩', '▩','▩','▩','▩','▩','▩' ,'▩','♨','♨','♣', '♣','▩','▩','♨','♨','▩', '▩','▩','■'},
                {'■','▩','▩','▩','♣', '▩','▩','▩','▩','▩','▩' ,'♨','♨','♨','♨', '♣','▩','▩','♨','♨','▩', '▩','▩','■'},
                {'■','▩','▲','▩','♣', '▩','▩','▩','▩','▩','▩' ,'♨','♨','♨','♨', '♨','▩','▩','▩','▩','▩', '▩','▩','■'},
                {'■','▲','▼','▲','♣', '♣','▩','▩','▩','▩','▩' ,'♨','♨','♨','♨', '♨','♨','▩','▩','▩','▩', '♨','▩','■'},
                {'■','П','П','П','♣', '♣','▩','▩','▩','▩','♨' ,'♨','♨','♨','♨', '♨','♨','▩','▩','▩','▩', '▩','▩','■'},
                {'■', '■', '■', '■', '■', '■', '■', '■', '■', '■', '■', '■', '■', '■', '■', '■', '■', '■', '■', '■', '■', '■', '■', '■'},
            };
            villagePosition = new Point(2, 19);
        }
        // ■   ♣   ▦   ♨   ▲   ◎   
        public struct Wave1
        {

        }
    }
}