using System;
using System.Drawing;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using ProgramingLanguageEnviroment;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rectangle = ProgramingLanguageEnviroment.Rectangle;


namespace FormTest
{
   
    [TestClass]
    public class UnitTest1
    {

        /// <summary>
        /// Test MoveTo
        /// Testing if xPos and yPos change
        /// </summary>
        [TestMethod]
        public void TestValidMoveToCommand()
        {
            String draw = "moveto 100 200";
            String[] commandList;
            commandList = draw.Split(' ');
            int xPos = 100;
            int yPos = 200;

            MoveTo.moveTo(int.Parse(commandList[1]), int.Parse(commandList[2]));

            Assert.AreEqual(xPos, MoveTo.xPos);
            Assert.AreEqual(yPos, MoveTo.yPos);

        }

        /// <summary>
        /// Test DrawTo
        /// Testing if a line is drawn of given points
        /// </summary>
        [TestMethod]
        public void TestValidDrawToCommand()
        {
            String draw = "drawto 30 80";
            String[] commandList;
            commandList = draw.Split(' ');
            int toX = 30;
            int toY = 80;

            if (commandList[0].Equals("drawto"))
            {
                MoveTo.moveTo(int.Parse(commandList[1]), int.Parse(commandList[2]));
            }

            Assert.AreEqual(toX, MoveTo.xPos);
            Assert.AreEqual(toY, MoveTo.yPos);

        }

        /// <summary>
        /// Test DrawTo
        /// Testing if exception is thrown on invalid input
        /// </summary>
        [TestMethod]
        public void TestInvalidDrawToCommand()
        {
            String command ="drawto 50" ;
            String[] commandList;
            commandList = command.Split(' ');
            
            try
            {
                if (commandList[0].Equals("drawto"))
                {
                    MoveTo.moveTo(int.Parse(commandList[1]), int.Parse(commandList[2]));
                }
            }
            catch (IndexOutOfRangeException e)
            {
                command = e.Message;
            }

            Assert.AreEqual("Index was outside the bounds of the array.", command);

        }

        /// <summary>
        /// Test ResetPen
        /// Testing to see if pen goes back to its default position
        /// </summary>
        [TestMethod]
        public void TestPenResetPosition()
        {
            String draw = "reset";
            String[] commandList;
            commandList = draw.Split(' ');
            MoveTo.xPos = 60;
            MoveTo.yPos = 90;
            int toX = 0;
            int toY = 0;

            ResetPen.resetPen(0, 0);

            Assert.AreEqual(toX, MoveTo.xPos);
            Assert.AreEqual(toY, MoveTo.yPos);
        }

        /// <summary>
        /// Test PenColor
        /// test pen colour changes by changing pens color
        /// </summary>
        [TestMethod]
        public void TestPenColorChange()
        {
            String command = "pen green";
            String[] commandList;
            commandList = command.Split(' ');
            Pen scribble;
            scribble = new Pen(Color.Green, 1);
            
            PenColor.colorPen(commandList[1]);
            
            Assert.AreEqual(scribble.Color, PenColor.Pen.Color);
        }

        /// <summary>
        /// Test Var
        /// testing to see if variable changes
        /// </summary>
        [TestMethod]
        public void TestVar()
        {
            String draw = "number 10";
            String[] commandList;
            commandList = draw.Split(' ');
            int val = 10;

            Var._Var(int.Parse(commandList[1]));
            
            Assert.AreEqual(val,Var.value);
        }
        
    }
}