using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
    public class LinearEquation : IFunction
    {
        float IFunction.Apply(List<BasicNumber> arguments)
        {
            if (arguments[0] == 0) throw new ConstantPolynomialException();

            return arguments[2] - arguments[1] / arguments[0];


        }
    }
}
