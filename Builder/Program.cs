using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
	class Program
	{
		static void Main(string[] args)
		{
			Director director = new Director(new LetterToMomBuilder());

			Console.WriteLine(director.MakeLetterToMom());
		}
	}
}
