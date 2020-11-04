using System;
using System.Drawing;
using ProgramingLanguageEnviroment;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rectangle = ProgramingLanguageEnviroment.Rectangle;


namespace FormTest
{
    [TestClass]
    public class UnitTest1
    {
        Rectangle MyRectangle = new Rectangle();
        private readonly Bitmap OutputBitMap = new Bitmap(840, 680); // set up new bitmap

        [TestInitialize]
        public void Initilize()
        {
            MyRectangle = new Rectangle(Graphics.FromImage(OutputBitMap));
        }
        
        [TestMethod]
        public void TestValidMoveToCommand()
        {
            String draw = "moveto 100 200";
            String[] commandList;
            commandList = draw.Split(' ');
            int xPos = 40;
            int yPos = 40;

            MoveTo.moveTo(int.Parse(commandList[1]), int.Parse(commandList[2]));
            
            Assert.AreEqual(100, MoveTo.xPos);
            Assert.AreEqual(200, MoveTo.yPos);
            
        }

        [TestMethod]
        public void TestValidDrawToCommand()
        {
            String draw = "drawto 30 80";
            String[] commandList;
            commandList = draw.Split(' ');
            int toX = 30;
            int toY = 80;
            
            MoveTo.moveTo(int.Parse(commandList[1]), int.Parse(commandList[2]));
                
            Assert.AreEqual(toX, MoveTo.xPos);
            Assert.AreEqual(toY, MoveTo.yPos);
                
        }

        
        
    }
}