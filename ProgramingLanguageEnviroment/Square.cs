using System.Drawing;

namespace ProgramingLanguageEnviroment
{
    public class Square:Shapes
    {
        int size;


        public Square() : base()
        {
            
        }

        public Square(int size) : base()
        {
            this.size = size;
        }
        
        public override void set(params int[] list)
        {
            base.set();
            this.size = list[0];

        }
        /// <summary>
        /// Constructor initialises Rectangle to Pen or ShapeFill 
        /// </summary>
        /// <param name="g">Graphics place to draw on</param>

        /// <summary>
        /// draws a rectangle at pens current position from user input
        /// </summary>
        /// <param name="width">width of rectangle to be drawn</param>
        /// <param name="height">height of rectangle to be drawn</param>
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