using System.Drawing;

namespace ProgramingLanguageEnviroment
{
    /// <summary>
    /// DrawTo class holds information that is displayed on the form when command is triggered
    /// </summary>
    public class DrawTo
    {
        public Graphics g;
        public ShapeFill filler;
        public PenColor colour;

        /// <summary>
        /// Constructor initialises 
        /// </summary>
        /// <param name="g">Graphics place to draw on</param>
        public DrawTo(Graphics g)
        {
            this.g = g;
            colour = new PenColor();//changing color 
            PenColor.Pen = new Pen(Color.Black, 1);// default pen 
        }
        
        /// <summary>
        /// draws a line form current pen pos 
        /// </summary>
        /// <param name="toX">x position to draw to</param>
        /// <param name="toY">y position to draw to</param>
        public void DrawLine(int toX, int toY)
        {
            g.DrawLine(PenColor.Pen, MoveTo.xPos, MoveTo.yPos, toX, toY); // draws line
            MoveTo.xPos = toX;
            MoveTo.yPos = toY;//update pens end pos after move
        }
    }
}