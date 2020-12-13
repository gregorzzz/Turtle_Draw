using System.Drawing;

namespace ProgramingLanguageEnviroment
{
    /// <summary>
    /// Class inherits all of the shape classes 
    /// </summary>
   public abstract class Shapes:Shape
    {
        protected Color colour;
       protected int xPos, yPos;

       /// <summary>
       /// Predefined values
       /// </summary>
       /// <param name="colour"></param>
       public Shapes()
        {
            colour = Color.Black;
            xPos = yPos = 100;
        }
        
       public Shapes(Color colour)
       {
           this.colour = colour;
       }
        /// <summary>
        /// Method which needs to be implemented
        /// </summary>
        /// <param name="g">Graphic which will be drawn</param>
        public abstract void Draw(Graphics g);

        /// <summary>
        /// Used for setting shape specific values 
        /// </summary>
        /// <param name="list">stored parameters</param>
        public virtual void set(Color colour,params int[] list)
        {
            this.colour = colour;
        }
        
    }
}