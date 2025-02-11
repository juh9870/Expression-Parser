using System;
using System.Globalization;

namespace CodeWriter.ExpressionParser
{
    public class IntExpressionParser : ExpressionParser<int>
    {
        public static readonly ExpressionParser<int> Instance = new IntExpressionParser();

        protected override int False { get; } = 0;
        protected override int True { get; } = 1;

        protected override int Parse(string input) =>
            int.Parse(input, NumberStyles.Any, CultureInfo.InvariantCulture);

        protected override int Negate(int v) => -v;
        protected override int Add(int a, int b) => a + b;
        protected override int Sub(int a, int b) => a - b;
        protected override int Mul(int a, int b) => a * b;
        protected override int Div(int a, int b) => a / b;
        protected override int Mod(int a, int b) => a % b;
        protected override int Pow(int a, int b) => throw new NotImplementedException();
        protected override int Equal(int a, int b) => a == b ? 1 : 0;
        protected override int NotEqual(int a, int b) => a != b ? 1 : 0;
        protected override int LessThan(int a, int b) => a < b ? 1 : 0;
        protected override int LessThanOrEqual(int a, int b) => a <= b ? 1 : 0;
        protected override int GreaterThan(int a, int b) => a > b ? 1 : 0;
        protected override int GreaterThanOrEqual(int a, int b) => a >= b ? 1 : 0;
        protected override bool IsTrue(int v) => v != 0;
        protected override int Round(int v) => throw new NotImplementedException();
        protected override int Ceiling(int v) => throw new NotImplementedException();
        protected override int Floor(int v) => throw new NotImplementedException();
        protected override int Log10(int v) => throw new NotImplementedException();

        protected override int Log(int v, int newBase) => throw new NotImplementedException();
    }
}