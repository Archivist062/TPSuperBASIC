using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBASIC.Functions
{
	public class Pi : IFunction
	{
		float IFunction.Apply(List<BasicNumber> arguments)
		{
			return (float)Math.PI;
		}
	}
	public class Euler : IFunction
	{
		float IFunction.Apply(List<BasicNumber> arguments)
		{
			return (float)Math.E;
		}
	}
	public class GRatio : IFunction
	{
		static readonly float value = (1f + (float)Math.Sqrt(5)) / 2f;
		float IFunction.Apply(List<BasicNumber> arguments)
		{
			return value;
		}
	}
}
