using System;

namespace ProgramingLanguageEnviroment
{
    public class Factory
    {
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
            else
            {
                ArgumentException argEx = new ArgumentException("Factory error: " +shapeType+ " does not exist");
                throw argEx;
            }
        }
    }
    }
