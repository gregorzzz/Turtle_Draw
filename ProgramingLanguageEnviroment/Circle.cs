using System;
using System.Drawing;

namespace ProgramingLanguageEnviroment
{
    /// <summary>
    /// Circle class holds information that is displayed on the form when command is triggered
    /// </summary>
   class Circle:Shapes
    {
        int radius;
        public PenColor colour;
        

        public Circle() : base()
        {
        }
        
        /// <summary>
        /// Constructor initialises Triangle to Pen or ShapeFill 
        /// </summary>
        /// <param name="g">Graphics place to draw on</param>
        public Circle (int radius) : base()
        {
            this.radius = radius;
        }
        
        public override void set(params int[] list)
        {
            base.set();
            this.radius = list[0];

            

        }
        
        

        /// <summary>
        /// Draws a circle of defined size
        /// </summary>
        /// <param name="radius">length from center to outside edge </param>
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