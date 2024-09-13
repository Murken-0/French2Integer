using System;

namespace French2Integer

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
                        throw new ArgumentException("Недопустим ввод двух слов единичного формата");
                    WasDigits = true;
                    break;
                case NumberRank.Ten:
                    if (WasDigits)
                        throw new ArgumentException("Слово десятичного формата должно идти перед словом единичного формата");
                    if (WasTens)
                        if (value / 10 == 1 && (Value % 100 / 10 == 6 || Value % 100 / 10 == 8))
                        {
                            if (value % 10 != 0) WasDigits = true;
                        }
                        else
                            throw new ArgumentException("Недопустим ввод двух слов десятичного формата");
                    WasTens = true;
                    break;
                case NumberRank.Houndred:
                    if (WasHundreds)
                        throw new ArgumentException("Недопустим ввод двух слов формата сотен");
                    if (WasDigits)
                        throw new ArgumentException("Слово формата сотен должно идти перед словом единичного формата");
                    if (WasTens)
                        throw new ArgumentException("Слово формата сотен должно идти перед словом десятичного формата");
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
