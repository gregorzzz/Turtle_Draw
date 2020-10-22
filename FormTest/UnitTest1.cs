using System;
using System.Drawing;
using System.Windows.Forms;
using ProgramingLanguageEnviroment;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace FormTest
{
    [TestClass]
    public class UnitTest1
    {
        private Canvas MyCanvas = new Canvas();

        private readonly Bitmap OutputBitMap = new Bitmap(840, 680);

        [TestInitialize]
        public void Initialize()
        {
            MyCanvas = new Canvas(Graphics.FromImage(OutputBitMap));
        }

        [TestMethod]
        public void TestMethod1()
        {
            String draw = "line 50 60";
            String[] commandList;
            commandList = draw.Split(' ');
            int xPos = 40;
            int yPos = 40;

            MyCanvas.DrawLine(int.Parse(commandList[1]), int.Parse(commandList[2]));
            
            if (commandList[0].Equals("line"))
            {
                Assert.IsTrue(MyCanvas.DrawLine(int.Parse(commandList[1]) < xPos);
                Assert.IsTrue(MyCanvas.DrawLine(int.Parse(commandList[2]) < yPos);
            }



        }


    }
}