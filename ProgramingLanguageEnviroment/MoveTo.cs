using System.Drawing;

namespace ProgramingLanguageEnviroment
{
    /// <summary>
    /// MoveTo class hold information on where to move pen command is triggered 
    /// </summary>
    public class MoveTo
    {
        public static int xPos, yPos;
        
        /// <summary>
        /// changes pen postion
        /// </summary>
        /// <param name="toX">x position to move pen to</param>
        /// <param name="toY">y position to move pen to</param>
        public static void moveTo(int toX, int toY)
        {
            xPos = toX;
            yPos = toY;
        }
    }
}