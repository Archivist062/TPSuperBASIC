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
    public class TestMemoryValuesBetween
    {
        [TestMethod]
        public void MyTestMethod()
        {

			Library lib = new Library();

            lib.AddFunction(new MemoryStore(), 2, "MEMSTORE");

			Runtime r = new Runtime(lib);
			r.OpenFile(Directory.GetCurrentDirectory() + "\\CasDeTest\\TestMemoryValuesBetween-MyTestMethod.basic");
			r.Run();
			var values = Memory.ValuesBetween(128, 131);
			var expecteds = Enumerable.Range(1, 4);
			foreach(var (expected, value) in expecteds.Zip(values))
            {
				Assert.AreEqual(expected, value);
            }
		}
    }
}
