using System.Drawing;

namespace ProgramingLanguageEnviroment
{
    /// <summary>
    /// Rectangle class holds information that is displayed on the form when command is triggered
    /// </summary>
    class Rectangle:Shapes
    {
        int width;
        int height;

        public Rectangle() : base()
        {
            
        }

        public Rectangle(int width, int height) : base()
        {
            this.width = width;
            this.height = height;
        }
        
        public override void set(params int[] list)
        {
            base.set();
            this.width = list[0];
            this.height = list[1];

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
            PenColor.Pen = new Pen(Color.Black, 1);//default pen
            // draws rectangle from user defined points 
            g.DrawRectangle(PenColor.Pen, MoveTo.xPos , MoveTo.yPos,  width, height);
            
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