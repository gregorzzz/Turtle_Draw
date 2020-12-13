using System.Drawing;

namespace ProgramingLanguageEnviroment
{
    /// <summary>
    /// Square class holds information that is displayed on the form when command is triggered by the factory
    /// </summary>
    public class Square:Shapes
    {
        int size;


        public Square() : base()
        {
            
        }

        /// <summary>
        /// Value which used to draw shape
        /// </summary>
        /// <param name="size">Width and height of square</param>
        public Square(int size) : base()
        {
            this.size = size;
        }
        
        /// <summary>
        /// Sets the value of which to use to draw the square
        /// </summary>
        /// <param name="list">given value</param>
        public override void set(params int[] list)
        {
            base.set();
            this.size = list[0];

        }
        /// <summary>
        /// Draws square graphic
        /// </summary>
        /// <param name="g">Graphic to be drawn</param>
        public override void Draw(Graphics g)
        {
            ShapeFill.fill = false; //triggers fill on or off 
            // draws rectangle from user defined points 
            g.DrawRectangle(PenColor.Pen, MoveTo.xPos , MoveTo.yPos,  size, size);
            
            using (var brush = new SolidBrush(PenColor.Pen.Color))// brush for drawing graphic filled
            {
                if (ShapeFill.fill == true) // draws filled graphic when triggered 
                {
                    g.FillRectangle(brush,MoveTo.xPos , MoveTo.yPos, size, size);
                }
            }
        }
    }
}