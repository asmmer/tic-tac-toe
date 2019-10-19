using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe
{
    class Settings
    {
        public static byte gridSize = 3;
        public static GameMode gameMode = GameMode.PlayerVSPlayer;
        public static Theme theme = Theme.Light;

        static public void Set(byte gridSize, GameMode gameMode, Theme theme)
        {
            Settings.gridSize = gridSize;
            Settings.gameMode = gameMode;
            Settings.theme = theme;
        }
    }
}
