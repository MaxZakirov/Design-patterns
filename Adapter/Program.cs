﻿using System;
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
				ILanguageAdapter adapter = new LanguageAdapter();
				EnglishAndSpanishSpeaker man = new EnglishAndSpanishSpeaker();
				Console.WriteLine(man.GetGreeding(adapter.GetEnglishGreeding("Привет")));
				Console.WriteLine(man.GetGreeding(adapter.GetSpanishGreeding("Привет")));
				man.GetGreeding("Привет");
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}