using System.Drawing;

namespace ProgramingLanguageEnviroment
{
    /// <summary>
    /// ResetPen class handles rest of pen 
    /// </summary>
    public class ResetPen
    {
        /// <summary>
        /// Resets pen to starting position 
        /// </summary>
        /// <param name="toX">x position to move pen to</param>
        /// <param name="toY">y position to move pen to</param>
        public static void resetPen(int toX, int toY)
        {
            MoveTo.xPos = toX;
            MoveTo.yPos = toY;
        }
    }
}