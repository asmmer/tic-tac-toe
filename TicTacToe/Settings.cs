namespace TicTacToe
{
    class Settings
    {
        public static byte gridSize = Properties.Settings.Default.gridSize;
        public static GameMode gameMode = (GameMode)Properties.Settings.Default.gameMode;
        public static Theme theme = (Theme)Properties.Settings.Default.theme;

        static public void Set(byte gridSize, GameMode gameMode, Theme theme)
        {
            Settings.gridSize = gridSize;
            Settings.gameMode = gameMode;
            Settings.theme = theme;

            Save();
        }

        static public void Save()
        {
            Properties.Settings.Default.gridSize = Settings.gridSize;
            Properties.Settings.Default.gameMode = (byte)Settings.gameMode;
            Properties.Settings.Default.theme = (byte)Settings.theme;

            Properties.Settings.Default.Save();
        }
    }
}
