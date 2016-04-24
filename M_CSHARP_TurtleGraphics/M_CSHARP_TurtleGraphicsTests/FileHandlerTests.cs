using NUnit.Framework;
using M_CSHARP_TurtleGraphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M_CSHARP_TurtleGraphics.Tests
{
    [TestFixture()]
    public class FileHandlerTests
    {
        public OpenFileDialog Dialog { get; }
        public ListBox ListBox { get; }

        public FileHandlerTests(OpenFileDialog dialog, ListBox listBox)
        {
            Dialog = dialog;
            ListBox = listBox;
        }


        [Test()]
        public void GetSplittedCommandTest()
        {

            Assert.Fail();
        }
    }
}