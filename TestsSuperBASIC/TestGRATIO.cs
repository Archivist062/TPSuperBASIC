using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperBASIC;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsSuperBASIC
{
    [TestClass]
    public class TestGRATIO
    {
        [TestMethod]
        public void MyTestMethod()
        {

			Library lib = new Library();
			var printer = new Mock.MockPrint();
			lib.AddFunction(printer, 1, "PRINT");

			lib.AddFunction(new SuperBASIC.Functions.GRatio(), 0, "GRATIO");
			Runtime r = new Runtime(lib);
			r.OpenFile(Directory.GetCurrentDirectory() + "\\CasDeTest\\TestGRATIO-MyTestMethod.basic");
			r.Run();
			Assert.AreEqual(1.61803f, printer.output[0], 0.00001f);
		}
    }
}
