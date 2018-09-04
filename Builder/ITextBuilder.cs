using System.Collections.Generic;

namespace Builder
{
	public interface ITextBuilder
	{
		void BuildGreeting();

		void BuildFarewell();

		void BuildJoke(string value);

		void BuildSuggestion(string value);

		void BuildFacts(IEnumerable<string> value);

		void BuildSwearing(string value);

		void BuildHappySmile();

		void BuildSadSmile();

		string GetResult();
	}
}
