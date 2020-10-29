using System.Drawing;

namespace ProgramingLanguageEnviroment
{
    public class Circle
    {
        public Graphics g;
        public ShapeFill filler;
        public PenColor colour;
        public int xPos, yPos;
        
        public Circle(Graphics g)
        {
            this.g = g;
            xPos = yPos = 0;
            filler = new ShapeFill();
            ShapeFill.fill = false;
            colour = new PenColor();
            PenColor.Pen = new Pen(Color.Black, 1);
        }
        
        public void DrawCircle(float radius)
        {
            g.DrawEllipse(PenColor.Pen, MoveTo.xPos , MoveTo.yPos, radius + radius, radius + radius);
            
            using (var brush = new SolidBrush(PenColor.Pen.Color))
            {
                if (ShapeFill.fill == true)
                {
                    g.FillEllipse(brush,MoveTo.xPos , MoveTo.yPos, radius + radius, radius + radius);
                }
            }
        }
    }
}