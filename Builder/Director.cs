using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
	public class Director
	{
		private readonly ITextBuilder builder;

		public Director(ITextBuilder builder)
		{
			this.builder = builder;
		}
		
		public string MakeLetterToMom()
		{
			builder.BuildGreeting();
			builder.BuildSadSmile();

			builder.BuildFacts(new string[] { "у меня мало времни",  "устаю" });

			builder.BuildSwearing("буду к тебе заходить чаще");

			builder.BuildSuggestion("сходить в парк");

			builder.BuildJoke("Колобок повесился");

			builder.BuildFarewell();
			builder.BuildHappySmile();

			return builder.GetResult();
		}
	}
}
