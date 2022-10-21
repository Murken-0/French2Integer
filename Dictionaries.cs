using System.Collections.Generic;

namespace koryagin1
{
	internal static class Dictionaries
	{
		public static Dictionary<string, int> AllWords = new Dictionary<string, int>
		{
			{"zero", 0}, {"un", 1}, {"deux", 2}, {"trois", 3},
			{"quatre", 4}, {"cinq", 5}, {"six", 6}, {"sept", 7},
			{"huit", 8}, {"neuf", 9}, {"onze", 11}, {"douze", 12},
			{"treize", 13}, {"quatorze", 14}, {"quinze", 15}, {"seize", 16},
			{"dix", 10}, {"vingt", 20}, {"trente", 30}, {"quarante", 40},
			{"cinquante", 50}, {"soixante", 60},
		};

		public static Dictionary<string, int> Tens = new Dictionary<string, int>
		{
			{"dix", 10}, {"vingt", 20},
			{"trente", 30}, {"quarante", 40},
			{"cinquante", 50}, {"soixante", 60},
		};

		public static Dictionary<string, int> Digits = new Dictionary<string, int>
		{
			{"deux", 2}, {"trois", 3},
			{"quatre", 4}, {"cinq", 5},
			{"six", 6}, {"sept", 7},
			{"huit", 8}, {"neuf", 9}
		};
	}
}
