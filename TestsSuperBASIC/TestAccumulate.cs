using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperBASIC;
using SuperBASIC.Functions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsSuperBASIC
{
    [TestClass]
    public class TestAccumulate
    {
        [TestMethod]
        public void MyTestMethod()
        {

			Library lib = new Library();
            var output = new Mock.MockPrint();
            lib.AddFunction(output, 1, "PRINT");

            lib.AddFunction(new MemoryStore(), 2, "MEMSTORE");
            lib.AddFunction(new Accumulate(), 2, "ACCUMULATE");

            Runtime r = new Runtime(lib);
			r.OpenFile(Directory.GetCurrentDirectory() + "\\CasDeTest\\TestAccumulate-MyTestMethod.basic");
			r.Run();
			
			Assert.AreEqual(1f+2f+3f+4f, output.output[0]);
		}
    }
}
