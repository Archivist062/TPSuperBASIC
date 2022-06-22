using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperBASIC;
using System.IO;
using System.Linq;

namespace TestsSuperBASIC
{
    [TestClass]
    public class Cylinder_volTest
    {
        [TestMethod]
        public void Cylinder_vol() 
        {
            Mock.MockPrint print = new Mock.MockPrint();
            Library lib = new Library();

            lib.AddFunction(new SuperBASIC.Functions.Cylinder_vol(), 2, "CYLINDER_VOL");
            lib.AddFunction(print, 1, "PRINT");

            Runtime r = new Runtime(lib);
            r.OpenFile(Directory.GetCurrentDirectory() + "\\CasDeTest\\Cylinder_volTest1.txt");
            r.Run();

            Assert.AreEqual((float)print.output[0], 37,699112);
        }
    }
}
