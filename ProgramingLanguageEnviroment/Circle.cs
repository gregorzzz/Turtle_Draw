using System.Drawing;

namespace ProgramingLanguageEnviroment
{
    /// <summary>
    /// Circle class holds information that is displayed on the form when command is triggered
    /// </summary>
   public class Circle
    {
        public Graphics g;
        public ShapeFill filler;
        public PenColor colour;
        public int xPos, yPos;
        
        /// <summary>
        /// Constructor initialises Triangle to Pen or ShapeFill 
        /// </summary>
        /// <param name="g">Graphics place to draw on</param>
        public Circle(Graphics g)
        {
            this.g = g;
            xPos = yPos = 0;
            filler = new ShapeFill();//triggers fill on or off 
            ShapeFill.fill = false;
            colour = new PenColor();
            PenColor.Pen = new Pen(Color.Black, 1);//default pen
        }

        /// <summary>
        /// Draws a circle of defined size
        /// </summary>
        /// <param name="radius">length from center to outside edge </param>
        public void DrawCircle(float radius)
        {
            //draws circle from given points
            g.DrawEllipse(PenColor.Pen, MoveTo.xPos , MoveTo.yPos, radius + radius, radius + radius);
            
            using (var brush = new SolidBrush(PenColor.Pen.Color))//brush for drawing filled graphic 
            {
                if (ShapeFill.fill == true)//draws filled circle
                {
                    g.FillEllipse(brush,MoveTo.xPos , MoveTo.yPos, radius + radius, radius + radius);
                }
            }
        }
    }
}