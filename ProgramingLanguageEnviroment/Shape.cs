using System.Drawing;

namespace ProgramingLanguageEnviroment
{
    public interface Shape
    {
        void set(Color c, params int[] list);
        void draw(Graphics g);
        double calcArea();
        double calcPerimeter();
    }
}