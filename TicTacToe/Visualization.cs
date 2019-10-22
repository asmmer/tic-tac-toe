using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe
{
    static class Visualization
    {
        readonly static Color LIGHT_COLOR_1 = Color.FromArgb(247, 247, 247);
        readonly static Color LIGHT_COLOR_2 = Color.FromArgb(255, 255, 255);

        readonly static Color DARK_COLOR_1 = Color.FromArgb(36, 36, 36);
        readonly static Color DARK_COLOR_2 = Color.FromArgb(24, 24, 24);

        public static void SetTheme(Control control, Theme theme, byte colorType)
        {
            if (theme == Theme.Light)
            {
                if (colorType == 0)
                {
                    control.BackColor = LIGHT_COLOR_1;
                }
                if (colorType == 1)
                {
                    control.BackColor = LIGHT_COLOR_2;
                }
                control.ForeColor = Color.Black;
            }
            if (theme == Theme.Dark)
            {
                if (colorType == 0)
                {
                    control.BackColor = DARK_COLOR_1;
                }
                if (colorType == 1)
                {
                    control.BackColor = DARK_COLOR_2;
                }
                control.ForeColor = Color.FromArgb(247, 247, 247);
            }
        }
    }
}
