using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
	//parametres are mock to show that there are some
	//transformations in methods
	public class LanguageAdapter : ILanguageAdapter
	{
		public string GetEnglishGreeding(string msg)
		{
			return "Hello";
		}

		public string GetSpanishGreeding(string msg)
		{
			return "Hola";
		}
	}
}
