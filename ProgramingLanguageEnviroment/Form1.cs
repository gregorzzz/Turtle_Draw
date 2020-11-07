using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramingLanguageEnviroment
{
    
    public partial class Form1 : Form
    {
        private String[] commandList;
        //bitmap which is draw on and displayed in picturebox 
        Bitmap OutputBitmap = new Bitmap(640, 480);
        private Circle MyCircle;
        private Rectangle MyRectangle;
        private Triangle MyTriangle;
        private DrawTo MyLine;
        public Form1()
        {
            InitializeComponent();
            MyCircle = new Circle(Graphics.FromImage(OutputBitmap));//class for handling the drawing of circle 
            MyRectangle = new Rectangle(Graphics.FromImage(OutputBitmap));//class for handling the drawing of rectangle
            MyTriangle = new Triangle(Graphics.FromImage(OutputBitmap));//class for handling the drawing of Triangle 
            MyLine = new DrawTo(Graphics.FromImage(OutputBitmap));//class for handling the drawing of a line to move the pen 
            
            
        }
        /// <summary>
        /// Method for handling and triggering commands
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void command_line_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //extract user input from textbox
                String line = inputBox.Text;
                //extract command from command line
                String command = command_line.Text.Trim().ToLower();
                commandList = command.Split(',',' ');
                command_line.Clear();

                // run command for executing commands in user input text area
                if (commandList[0].Equals("run") == true)
                {
                    using (StringReader reader = new StringReader(inputBox.Text))
                    {
                        while ((line = reader.ReadLine()) !=null)
                        {
                            commandList =line.Split(' ',',');
                            drawShape();
                        }
                    }
                }
                drawShape();
                Refresh();
            }
        }

        /// <summary>
        /// draws graphics on pictureBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImageUnscaled(OutputBitmap,0,0);
        }

        /// <summary>
        /// method for clearing bitmap
        /// </summary>
        public void ClearImage()
        {
            Graphics myGraphics = Graphics.FromImage(OutputBitmap);
            myGraphics.Clear(Color.White);
            
        }

        /// <summary>
        /// method ResetPos resets pen position
        /// </summary>
        public void ResetPos()
        {
            ResetPen.resetPen(0, 0);
        }

        /// <summary>
        /// method SaveFiles saves text from input box uses dialog 
        /// </summary>
        public void SaveFiles()
        {
            SaveFileDialog saveFileBox = new SaveFileDialog();

            saveFileBox.DefaultExt = "*.txt";
            saveFileBox.Filter = "Text Document|*.txt";

            if (saveFileBox.ShowDialog() == System.Windows.Forms.DialogResult.OK && 
                saveFileBox.FileName.Length > 0)
            {
                inputBox.SaveFile(saveFileBox.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        /// <summary>
        /// method LoadFiles loads text to input box uses dialog  
        /// </summary>
        public void LoadFiles()
        {
            OpenFileDialog loadFileBox = new OpenFileDialog();

            loadFileBox.DefaultExt = "*.txt";
            loadFileBox.Filter = "Text Document|*.txt";

            if (loadFileBox.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                loadFileBox.FileName.Length > 0)
            {
                inputBox.LoadFile(loadFileBox.FileName, RichTextBoxStreamType.PlainText);
            }
        }
        
        /// <summary>
        /// method drawShape handles running commands
        /// </summary>
        public void drawShape()
        {
             if (commandList[0].Equals("drawto") == true)
             {
                 if(commandList.Length != 3)
                 {
                     MessageBox.Show("Wrong amount of values.\\n Example: drawTo 50 50", "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
                 MyLine.DrawLine(Int32.Parse(commandList[1]), Int32.Parse(commandList[2]));
             }
             else if (commandList[0].Equals("rectangle") == true)
             {
                 if(commandList.Length != 3)
                 {
                     MessageBox.Show("Wrong amount of values.\\n Example: rectangle 50 50", "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
                 
                 MyRectangle.DrawSquare(Int32.Parse(commandList[1]), Int32.Parse(commandList[2]));
             }
             else if (commandList[0].Equals("circle") == true)
             {
                 if(commandList.Length != 2)
                 {
                     MessageBox.Show("Wrong amount of values.\\n Example: circle 50", "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }

                 MyCircle.DrawCircle(Int32.Parse(commandList[1]));
             }
             else if (commandList[0].Equals("moveto") == true)
             {
                 if(commandList.Length >3 )
                 {
                     MessageBox.Show("Wrong amount of values.\\n Example: moveto 50 50", "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
                    
                 MoveTo.moveTo(Int32.Parse(commandList[1]), Int32.Parse(commandList[2]));
                 
             }
             else if (commandList[0].Equals("triangle") == true)
             {
                 if(commandList.Length != 5)
                 {
                     MessageBox.Show("Wrong amount of values.\\n xample: triangle 150 150 100 30", "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }

                 MyTriangle.DrawTriangle(Int32.Parse(commandList[1]),Int32.Parse(commandList[2]),Int32.Parse(commandList[3]), Int32.Parse(commandList[4]));
             }
             else if (commandList[0].Equals("clear") == true)
             {
                 ClearImage();
                 canvas.Refresh();
             }
             else if(commandList[0].Equals("reset") == true)
             {
                 ResetPos();
                 canvas.Refresh();
             }
             else if (commandList[0].Equals("pen") == true)
             {
                 PenColor.colorPen(commandList[1]);
             }
             else if (commandList[0].Equals("fill_on"))
             {
                 ShapeFill.filll(true);
             }
             else if (commandList[0].Equals("fill_off"))
             {
                 ShapeFill.filll(false);
             }
             else if (commandList[0].Equals("save"))
             {
                 SaveFiles();
             }
             else if (commandList[0].Equals("load"))
             {
                 LoadFiles();
             }
             else
             {
                 throw new ApplicationException( "That is not a valid command");
             }
        }
        
        /// <summary>
        /// button to run commands form inputbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void runButton_Click(object sender, EventArgs e)
        {
            String line = inputBox.Text;
            
            using (StringReader reader = new StringReader(inputBox.Text))
            {
                while ((line = reader.ReadLine()) !=null)
                {
                    commandList =line.Split(' ',',');
                    drawShape();
                }
            }
            Refresh();
        }
    }
    
}