using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koryagin1
{
	internal class Number
	{
		public bool WasDigits { get; private set; }
		public bool WasTens { get; private set; }
		public bool WasHundreds { get; private set; }
		public int Value { get; private set; }

		public Number()
		{
			Value = 0;
			WasDigits = false;
			WasTens = false;
			WasHundreds = false;
		}

		public void TryAddValue(int value)
		{
			switch (GetRankByValue(value))
			{
				case NumberRank.Digit:
					if (WasDigits)
						throw new ArgumentException("Разряд единиц введен несколько раз");
					WasDigits = true;
					break;
				case NumberRank.Ten:
					if (WasTens)
						if (value / 10 == 1 && (Value % 100 / 10 == 6 || Value % 100 / 10 == 8))
						{
							if (value % 10 != 0) WasDigits = true;
						}
						else
							throw new ArgumentException("Разряд десяков введен несколько раз");
					if (WasDigits)
						throw new ArgumentException("Разряд десятков должен указываться перед единицами");
					WasTens = true;
					break;
				case NumberRank.Houndred:
					if (WasHundreds)
						throw new ArgumentException("Разряд сотен введен несколько раз");
					if (WasTens || WasDigits)
						throw new ArgumentException("Разряд сотен должен указываться перед десятками и единицами");
					WasHundreds = true;
					break;
				default:
					throw new InvalidOperationException("Как это вообще появилось?)))");
			}
			Value += value;
		}
		private NumberRank GetRankByValue(int value)
		{
			if (value / 10 == 0) return NumberRank.Digit;
			else if (value / 100 == 0 && value % 100 != 0) return NumberRank.Ten;
			else return NumberRank.Houndred;
		}
	}
}
