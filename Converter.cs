using System;
using System.Collections.Generic;
using System.Linq;

namespace koryagin1
{
	internal class Converter
	{
		private List<string> words;

		public int Convert(string str)
		{
			ParseStringToList(str);
			Number number = new Number();

			for (int i = 0; i < words.Count; i++)
			{
				//Особые случаи
				if (words[i] == "cent")
				{
					if (i == 0) { number.TryAddValue(100); continue; }
					else if (Dictionaries.Digits.ContainsKey(words[i - 1])) continue;
					else throw new ArgumentException("Перед \"cent\" ожидается цифра от 2 до 9");
				}

				if (words[i] == "et")
				{
					if (i == 0) throw new ArgumentException("Недопустимо наличие \"et\" в начале слова");
					else if (Dictionaries.Tens.ContainsKey(words[i - 1])) continue;
					else throw new ArgumentException("Перед \"et\" ожидается число десятичного формата");
				}

				if (words[i] == "vingts")
				{
					if (i == 0) throw new ArgumentException("Недопустимо наличие \"vingts\" в начале слова");
					else if (words[i - 1] == "quatre") continue;
					else throw new ArgumentException("Перед \"vingts\" ожидается \"quatre\"");
				}

				if (words[i] == "vingt" && i != 0 && words[i - 1] == "quatre") continue;

				if (words[i] == "quatre" && i + 1 < words.Count && (words[i + 1] == "vingts" || words[i + 1] == "vingt"))
				{ number.TryAddValue(80); continue; }

				//Основная часть
				if (!Dictionaries.AllWords.ContainsKey(words[i])) throw new ArgumentException("Неудалось определить слово: " + words[i]);

				if (i + 1 < words.Count && words[i + 1] == "cent" && Dictionaries.Digits.ContainsKey(words[i]))
					number.TryAddValue(Dictionaries.AllWords[words[i]] * 100);
				else
					number.TryAddValue(Dictionaries.AllWords[words[i]]);
			}
			return number.Value;
		}

		private void ParseStringToList(string str)
		{
			words = str.Trim().ToLower().Split(new[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries).ToList();
			if (words.Count == 0) throw new ArgumentException("Для начала введите строковое представление числа");
		}
	}
}
