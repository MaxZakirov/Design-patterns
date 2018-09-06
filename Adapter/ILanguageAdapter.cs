using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
	public interface ILanguageAdapter
	{
		string GetEnglishGreeding(string greeding);

		string GetSpanishGreeding(string greeding);
	}
}
