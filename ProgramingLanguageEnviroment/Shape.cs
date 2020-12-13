using System.Drawing;

namespace ProgramingLanguageEnviroment
{
    /// <summary>
    /// Interface for shapes inheritance 
    /// </summary>
    public interface Shape
    {
        void set(params int[] list);
        void Draw(Graphics g);

    }
}