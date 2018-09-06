using System;

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
