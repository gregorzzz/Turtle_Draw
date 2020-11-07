using System.Drawing;

namespace ProgramingLanguageEnviroment
{
    /// <summary>
    /// Rectangle class holds information that is displayed on the form when command is triggered
    /// </summary>
    public class Rectangle
    {
        public Graphics g;
        public ShapeFill filler;
        public PenColor colour; 
        public int xPos, yPos;

        /// <summary>
        /// Constructor initialises Rectangle to Pen or ShapeFill 
        /// </summary>
        /// <param name="g">Graphics place to draw on</param>
        public Rectangle(Graphics g)
        {
            this.g = g;
            xPos = yPos = 0;
            filler = new ShapeFill();
            ShapeFill.fill = false; //triggers fill on or off 
            colour = new PenColor();
            PenColor.Pen = new Pen(Color.Black, 1);//default pen

        }

        /// <summary>
        /// draws a rectangle at pens current position from user input
        /// </summary>
        /// <param name="width">width of rectangle to be drawn</param>
        /// <param name="height">height of rectangle to be drawn</param>
        public void DrawSquare(int width, int height)
        {
            // draws rectangle from user defined points 
            g.DrawRectangle(PenColor.Pen, MoveTo.xPos , MoveTo.yPos, xPos + width, yPos + height);
            
            using (var brush = new SolidBrush(PenColor.Pen.Color))// brush for drawing graphic filled
            {
                if (ShapeFill.fill == true) // draws filled graphic when triggered 
                {
                    g.FillRectangle(brush,MoveTo.xPos , MoveTo.yPos, xPos + width, yPos + height);
                }
            }
        }
    }
        
}