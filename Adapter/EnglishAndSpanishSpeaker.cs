using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
	public class EnglishAndSpanishSpeaker
	{
		public string GetGreeding(string greeding)
		{
			if (greeding == "Hello")
				return "ooo, Hi! ))";
			if (greeding == "Hola")
				return "ooo, Hola! ))";
			throw new Exception("Don't understand you!");
		}
	}
}
