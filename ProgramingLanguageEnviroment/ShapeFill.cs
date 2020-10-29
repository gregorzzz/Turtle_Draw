using System.Drawing;

namespace ProgramingLanguageEnviroment
{
    public class ShapeFill
    {
        private Graphics g;
        public int xPos, yPos;
        public static bool fill = false;

        
        public ShapeFill(Graphics g)
        {
            this.g = g;
            xPos = yPos = 0;

        }

        public ShapeFill()
        {
            
        }
        public static void filll(bool filler)
        {
            if (filler){
                fill = true;
            }
            else
            {
                fill = false;
            }
            
        }
    }
}