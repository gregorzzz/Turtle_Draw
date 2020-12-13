using System;
using System.Drawing;

namespace ProgramingLanguageEnviroment
{
    /// <summary>
    /// Circle class holds information that is displayed on the form when command is triggered by factory
    /// </summary>
   class Circle:Shapes
    {
        int radius;
        public PenColor colour;
        

        public Circle() : base()
        {
        }
        
       /// <summary>
       /// Parameter used for setting the shape size 
       /// </summary>
       /// <param name="radius">size of the circle</param>
        public Circle (int radius) : base()
        {
            this.radius = radius;
        }
        
       /// <summary>
       /// Sets value of which circle will be drawn by 
       /// </summary>
       /// <param name="list">gets the value of radius</param>
        public override void set(params int[] list)
        {
            base.set();
            this.radius = list[0];
        }
        
        

        /// <summary>
        /// Draws circle of give size 
        /// </summary>
        /// <param name="g">Graphic to be drawn</param>
        public override void Draw(Graphics g)
        {
            colour = new PenColor();
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
        
        public override string ToString() //all classes inherit from object and ToString() is abstract in object
        {
            return base.ToString()+ "  "+this.radius;
        }
        
    }
}