using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
	public class ChatAdapter : IChatService
	{
		private readonly IChatService service;

		public ChatAdapter(IChatService service)
		{
			this.service = service;
		}

		public string GetGreeding(string greeding)
		{
			if(service.GetType() == typeof(EnglishChatService))
				return service.GetGreeding("Hello");

			if (service.GetType() == typeof(SpanishChatService))
				return service.GetGreeding("Holla");

			return "Unhandled language";
		}
	}
}
