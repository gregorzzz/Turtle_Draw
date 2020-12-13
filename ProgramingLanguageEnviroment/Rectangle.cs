using System.Drawing;

namespace ProgramingLanguageEnviroment
{
    /// <summary>
    /// Rectangle class holds information that is displayed on the form when command is triggered by the factory
    /// </summary>
    class Rectangle:Shapes
    {
        int width;
        int height;
        
        public Rectangle() : base()
        {
            
        }

        /// <summary>
        /// draws a rectangle at pens current position from user input
        /// </summary>
        /// <param name="width">width of rectangle to be drawn</param>
        /// <param name="height">height of rectangle to be drawn</param>
        /// <param name="colour"></param>
        public Rectangle(Color colour, int width, int height) : base(colour)
        {
            this.width = width;
            this.height = height;
        }
        
        /// <summary>
        /// Sets the values of width and height
        /// </summary>
        /// <param name="list">values of width and height</param>
        public override void set(Color colour, params int[] list)
        {
            base.set(colour);
            this.width = list[0];
            this.height = list[1];

        }
        /// <summary>
        /// Draws the graphic
        /// </summary>
        /// <param name="g">Graphic to be drawn</param>
        public override void Draw(Graphics g)
        {
            Pen Pen = new Pen(colour,1);
            // draws rectangle from user defined points 
            g.DrawRectangle(Pen, MoveTo.xPos , MoveTo.yPos,  width, height);
            
            using (var brush = new SolidBrush(PenColor.Pen.Color))// brush for drawing graphic filled
            {
                if (ShapeFill.fill == true) // draws filled graphic when triggered 
                {
                    g.FillRectangle(brush,MoveTo.xPos , MoveTo.yPos, width, height);
                }
            }
        }
    }
        
}