using SuperBASIC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsSuperBASIC.Mock
{
   public class MockPrint : SuperBASIC.IFunction
    {
        public List<float> output = new List<float>();

        float IFunction.Apply(List<BasicNumber> arguments)
        {
            output.Add(arguments[0]);
            return 0;
        }
    }
}
