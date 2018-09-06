using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				string msg = "Привет";
				IChatService service = new ChatAdapter(new EnglishChatService());
				Console.WriteLine(service.GetGreeding(service.GetGreeding(msg)));
				service = new ChatAdapter(new SpanishChatService());
				Console.WriteLine(service.GetGreeding(service.GetGreeding(msg)));
				service = new SpanishChatService();
				Console.WriteLine(service.GetGreeding(msg));
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
