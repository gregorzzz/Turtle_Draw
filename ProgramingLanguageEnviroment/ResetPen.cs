using System.Drawing;

namespace ProgramingLanguageEnviroment
{
    public class ResetPen
    {
        public Graphics g;

        public ResetPen(Graphics g)
        {
            this.g = g;
        }
        
        public static void resetPen(int toX, int toY)
        {
            MoveTo.xPos = toX;
            MoveTo.yPos = toY;
        }
    }
}