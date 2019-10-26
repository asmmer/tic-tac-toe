namespace TicTacToe
{
    internal class Settings
    {
        public static byte gridSize = Properties.Settings.Default.gridSize;
        public static GameMode gameMode = (GameMode)Properties.Settings.Default.gameMode;
        public static Theme theme = (Theme)Properties.Settings.Default.theme;

        public static void Set(byte gridSize, GameMode gameMode, Theme theme)
        {
            Settings.gridSize = gridSize;
            Settings.gameMode = gameMode;
            Settings.theme = theme;

            Save();
        }

        public static void Save()
        {
            Properties.Settings.Default.gridSize = Settings.gridSize;
            Properties.Settings.Default.gameMode = (byte)Settings.gameMode;
            Properties.Settings.Default.theme = (byte)Settings.theme;

            Properties.Settings.Default.Save();
        }
    }
}
