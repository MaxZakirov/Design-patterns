using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
	public class SpanishChatService : IChatService
	{
		public string GetGreeding(string greeding)
		{
			if (greeding == "Holla")
				return "Gracias!)";

			return "No te entiendo";
		}
	}
}
