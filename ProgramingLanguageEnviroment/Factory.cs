using System;
using System.Drawing;

namespace ProgramingLanguageEnviroment
{
    /// <summary>
    /// Factory for drawing shapes
    /// </summary>
    public class Factory
    {
        public Factory(Graphics fromImage)
        {
        }

        /// <summary>
        /// Commands which use the appropriate classes to draw the shapes
        /// </summary>
        /// <param name="shapeType">type of shape to be drawn</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">Exception for shape types which do not exist in factory</exception>
        public Shapes getCommand(String shapeType)
        {
            shapeType = shapeType.ToLower().Trim();

            if (shapeType.Equals("circle"))
            {
                return new Circle();
            }
            else if (shapeType.Equals("rectangle"))
            {
                return new Rectangle();
            }
            else if (shapeType.Equals("triangle"))
            {
                return new Triangle();
            }
            else if (shapeType.Equals("square"))
            {
                return new Square();
            }
            else
            {
                ArgumentException argEx = new ArgumentException("Factory error: " +shapeType+ " does not exist");
                throw argEx;
            }
        }
    }
    }
