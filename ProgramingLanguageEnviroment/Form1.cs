using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramingLanguageEnviroment
{
    public partial class Form1 : Form
    {
        private String[] commandList;
        Bitmap OutputBitmap = new Bitmap(640, 480);
        private Canvas MyCanvas;
        public Form1()
        {
            InitializeComponent();
            MyCanvas = new Canvas(Graphics.FromImage(OutputBitmap));
        }
        

        private void command_line_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                String command = command_line.Text.Trim().ToLower();
                commandList = command.Split(' ');
                //Console.WriteLine(commandList[0]+ commandList[1]);
                if (commandList[0].Equals("line") == true)
                {
                    MyCanvas.DrawLine(Int32.Parse(commandList[1]), Int32.Parse(commandList[2]));
                }
                else if (commandList[0].Equals("square") == true)
                {
                    MyCanvas.DrawSquare(Int32.Parse(commandList[1]));
                }
                else if (commandList[0].Equals("circle") == true)
                {
                    MyCanvas.DrawCircle(Int32.Parse(commandList[1]));
                }
                else if (commandList[0].Equals("move") == true)
                {
                    MyCanvas.moveTo(Int32.Parse(commandList[1]), Int32.Parse(commandList[2]));
                    
                }
              
                Refresh();
            }
            

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImageUnscaled(OutputBitmap,0,0);
        }


        
    }
    
}