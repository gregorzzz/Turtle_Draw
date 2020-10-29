using System.Drawing;

namespace ProgramingLanguageEnviroment
{
    public class MoveTo
    {
        public Graphics g;
        public ShapeFill filler;
        public PenColor colour; 
        public static int xPos, yPos;
        
        public MoveTo(Graphics g)
        {
            this.g = g;
            xPos = yPos = 0;
            filler = new ShapeFill();
            ShapeFill.fill = false;
            colour = new PenColor();
            PenColor.Pen = new Pen(Color.Black, 1);
        }
        
        public static void moveTo(int toX, int toY)
        {
            xPos = toX;
            yPos = toY;
        }
    }
}