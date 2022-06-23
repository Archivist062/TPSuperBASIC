using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperBASIC.Functions
{
#if MEMORY
	static public class Memory
	{
		internal static float[] memory = new float[Int16.MaxValue];

		public static float MemoryGet(Int16 pos) => memory[pos];
		public static float MemorySet(Int16 pos, float value)
		{
			memory[pos] = value;
			return value;
		}

		public static IEnumerable<float> ValuesBetween(short start, short last)
        {
			
			return memory.Skip(start).Take(last - start + 1);
			/*return Enumerable
				.Range(start, last - start + 1)
				.Cast<short>()
				.Select(x => MemoryGet(x));*/
        }

		[Serializable]
		public class BadMemoryAccess : Exception
		{
			public BadMemoryAccess() { }
			public BadMemoryAccess(string message) : base(message) { }
			public BadMemoryAccess(string message, Exception inner) : base(message, inner) { }
			protected BadMemoryAccess(
			  System.Runtime.Serialization.SerializationInfo info,
			  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
		}
	}


	public class MemoryLoad : IFunction
	{
		float IFunction.Apply(List<BasicNumber> arguments)
		{
			float value = arguments[0].GetValue();
			if(value == (int)value && value >= 0 && value < Int16.MaxValue)
			{
				return Memory.MemoryGet((short)value);
			}
			throw new Memory.BadMemoryAccess("Could not access requested memory");
		}
	}
	public class MemoryStore : IFunction
	{
		float IFunction.Apply(List<BasicNumber> arguments)
		{
			float value = arguments[0].GetValue();
			if (value == (int)value && value >= 0 && value < Int16.MaxValue)
			{
				return Memory.MemorySet((short)value, arguments[1]);
			}
			throw new Memory.BadMemoryAccess("Could not access requested memory");
		}
	}
#endif
}
