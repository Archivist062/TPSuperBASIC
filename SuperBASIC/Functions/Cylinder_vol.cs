﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
    public class Cylinder_vol : IFunction
    {
        float IFunction.Apply(List<BasicNumber> arguments)
        {
            return (float)(Math.PI * arguments[0] * arguments[1] * arguments[0]);
        }
    }
}