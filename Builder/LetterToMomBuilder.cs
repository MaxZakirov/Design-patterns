using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
	public class LetterToMomBuilder : ITextBuilder
	{
		private StringBuilder stringBuilder;

		public LetterToMomBuilder()
		{
			stringBuilder = new StringBuilder();
		}

		public void BuildFacts(IEnumerable<string> value)
		{
			stringBuilder.Append("В последнее время я: \n");
			int i = 0;
			foreach(var s in value)
			{
				stringBuilder.Append(i++ + ". Я -" + s+ ".\n");
			}
		}

		public void BuildFarewell()
		{
			stringBuilder.Append("\n\n Отпиши как сможешь, мам. Люблю тебя! ");
		}

		public void BuildGreeting()
		{
			stringBuilder.Append("Привет, мам. Я очень соскучился! \n\n");
		}

		public void BuildHappySmile()
		{
			stringBuilder.Append(" :) ");
		}

		public void BuildJoke(string value)
		{
			stringBuilder.Append(value + "))00)). ");
		}

		public void BuildSadSmile()
		{
			stringBuilder.Append(" :( ");
		}

		public void BuildSuggestion(string value)
		{
			stringBuilder.Append("Как тебе предложение " +value +"? ");
		}

		public void BuildSwearing(string value)
		{
			stringBuilder.Append("Обещаю, я "+value + ",честно-честно. ");
		}

		public string GetResult()
		{
			return stringBuilder.ToString();
		}
	}
}
