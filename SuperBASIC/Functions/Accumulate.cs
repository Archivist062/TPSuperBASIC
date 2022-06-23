using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperBASIC.Functions
{
    public class Accumulate : IFunction
    {
        static public float Function(short indexStart, short indexEnd)
        {
            return Memory.ValuesBetween(indexStart, indexEnd).Sum();
        }

        float IFunction.Apply(List<BasicNumber> arguments)
        {
            // Verifier le nombre d'arguments
            if (arguments.Count != 2) return float.NaN ;
            var toFloat = arguments.Select(x => x.GetValue());

            // Verifier que les arguments sont compatibles
            if (toFloat.All(x => x == Math.Floor(x))) {
                if (toFloat.All(x => x <= Int16.MaxValue))
                {
                    var toInt = toFloat.Select(x => (short)x);

                    return Function(toInt.First(), toInt.Last());
                }
            }
            return float.NaN;
        }
    }
}
